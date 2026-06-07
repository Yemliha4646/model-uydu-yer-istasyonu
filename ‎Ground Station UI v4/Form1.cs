using Accord.Video.FFMPEG;
using AForge.Video;
using AForge.Video.DirectShow;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static WinForm_AutoSize.Form1;
using System.Text;


namespace WinForm_AutoSize
{
    public partial class Form1 : Form
    {
        // SerialPort ve sabit ayarlar
        private SerialPort serialPort1;
        private const int FixedBaudRate = 115200;
        private string receivedData = string.Empty;

        // Grafik ve veri nesneleri
        private Random random = new Random();
        //private int lastYValue = 500;
        private string[] previousPorts;
       // private FilterInfoCollection videoDevices;

        // Açı değerleri jiroskop verileriyle güncellenecek
       // private float angleX = 0, angleY = 0, angleZ = 0;

        // Telemetri veri yapısı
        public struct TelemetryData
        {
            public string PacketNumber { get; set; }
            public string SatelliteStatus { get; set; }
            public string ErrorCode { get; set; }
            public string SendTime { get; set; }
            public string Pressure1 { get; set; }
            public string Pressure2 { get; set; }
            public string Altitude1 { get; set; }
            public string Altitude2 { get; set; }
            public string AltitudeDifference { get; set; }
            public string DescentSpeed { get; set; }
            public string Temperature { get; set; }
            public string BatteryVoltage { get; set; }
            public string Gps1Latitude { get; set; }
            public string Gps1Longitude { get; set; }
            public string Gps1Altitude { get; set; }
            public string Pitch { get; set; }
            public string Roll { get; set; }
            public string Yaw { get; set; }
            public string RHRH { get; set; }
            public string IoTData1 { get; set; }
            public string IoTData2 { get; set; }
            public string TeamNumber { get; set; }

        }

        //COM portları taranır ve combobox'a yüklenir
        //Kamera cihazları listelenir
        //Zamanlayıcılar başlatılır (port kontrolü ve saat güncelleme)
        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
            InitializeComponents();
            

            // GLControl hazırsa eventleri bağla
            glControl3D.Paint += GlControl1_Paint;
            glControl3D.Resize += GlControl1_Resize;
        }

        // Seri port  başlangıç ayarları
        private void InitializeSerialPort()
        {
            try
            {
                serialPort1 = new SerialPort
                {
                    BaudRate = FixedBaudRate,
                    ReadTimeout = 500,
                    WriteTimeout = 500
                };
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Port hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private const int MIN_PROGRESS = 0;
        private const int MAX_PROGRESS = 100;

        private void InitializeComponents()
        {
            // ProgressBar başlangıç ayarları
            progressBar1.Minimum = MIN_PROGRESS;
            progressBar1.Maximum = MAX_PROGRESS;
            progressBar1.Value = MIN_PROGRESS;

        }


        private BackgroundWorker serialWorker;
        // Form yüklendiğinde gerekli başlangıç işlemleri yapılır
        private void Form1_Load(object sender, EventArgs e)
        {
            
            // 1. Harita ve Grafik Arayüzlerini Hazırla
            InitializeMap();                    // Harita ilk
            SetupSpeedGauge();                 // Hız göstergesi
            SetupBatteryGauge();              // Batarya göstergesi
            SetupPressureChart();             // Basınç grafiği
            SetupAltitudeChart();             // İrtifa grafiği
            SetupTemperatureChart();          // Sıcaklık grafiği

            // 2. Seri Port Ayarlarını Yükle
            LoadSerialPorts();                // COM portları getir
            LoadCameras();                    // Kamera cihazlarını getir


            serialWorker = new BackgroundWorker();
            serialWorker.WorkerSupportsCancellation = true;
            serialWorker.DoWork += SerialWorker_DoWork;

            videoWorker = new BackgroundWorker();
            videoWorker.WorkerSupportsCancellation = true;
            videoWorker.DoWork += VideoWorker_DoWork;

            // 4. Zamanlayıcılar
            InitializeReconnectTimer();       // Seri port yeniden bağlanma
            
            SetupTimers();                    // Diğer timer'lar

            // 5. Başlangıç durumu göstergeleri
            UpdateConnectionStatus(false);    // Bağlantı yok olarak başlat
            UpdateErrorIndicators(null);      // Hataları temizle ve uyarı ekle

            // İlk render için MakeCurrent
            glControl3D.MakeCurrent();


            // Viewport'u ayarla
            GlControl1_Resize(glControl3D, EventArgs.Empty);

            SetRotationAngles(0.0f, 0.0f, 90.0f);

            
        }

        private void SerialWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!serialWorker.CancellationPending)
            {
                try
                {
                    string data = serialPort1.ReadLine(); // veri geldi
                    if (!string.IsNullOrWhiteSpace(data))
                    {
                        if (TelemetryProcessor.ProcessTelemetryData(data, out TelemetryData telemetry))
                        {
                            this.Invoke((MethodInvoker)(() =>
                            {
                                // Gösterge ve grafik güncellemeleri
                                UpdateUI(telemetry);
                                UpdateSpeedGauge(telemetry);
                                UpdateBatteryVoltage(telemetry);

                                UpdateChart(telemetry);             // Basınç
                                UpdateAltitudeChart(telemetry);      // İrtifa
                                UpdateTemperatureChart(telemetry);   // Sıcaklık

                                //  Kaydet ve harita güncelle 
                                SaveToCsv(telemetry);
                                UpdateMapPosition(telemetry);

                                // 3D açıları güncelle
                                if (float.TryParse(telemetry.Pitch, NumberStyles.Any, CultureInfo.InvariantCulture, out float pitch) &&
                                    float.TryParse(telemetry.Roll, NumberStyles.Any, CultureInfo.InvariantCulture, out float roll) &&
                                    float.TryParse(telemetry.Yaw, NumberStyles.Any, CultureInfo.InvariantCulture, out float yaw))
                                {
                                    SetRotationAngles(-pitch, roll, yaw);
                                }
                            }));
                        }
                    }
                }
                catch (TimeoutException) { /* sessiz geç */ }
                catch (Exception ex)
                {
                    Console.WriteLine("Serial read error: " + ex.Message);
                }
            }
        }
        private FilterInfoCollection _videoDevices;
        private VideoCaptureDevice _videoSource;
        private VideoFileWriter videoWriter;
        private bool isRecording = false; 

        private void LoadCameras()
        {
            // Kamera cihazlarını tara ve ComboBox'a ekle
            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            comboBox_cam.Items.Clear();

            foreach (FilterInfo device in _videoDevices)
            {
                comboBox_cam.Items.Add(device.Name);
            }

            if (comboBox_cam.Items.Count > 0)
                comboBox_cam.SelectedIndex = 0;
            else
                MessageBox.Show("Kamera bulunamadı!");
        }


        //  bilgisayardaki mevcut seri portları ComboBox'a listelemek için kullanılır
        private void LoadSerialPorts()
        {
            previousPorts = SerialPort.GetPortNames();
            cmbSerialComPort.Items.Clear();
            cmbSerialComPort.Items.AddRange(previousPorts);
            if (cmbSerialComPort.Items.Count > 0)
                cmbSerialComPort.SelectedIndex = 0;
        }

        private float angleX;
        private float angleY;
        private float angleZ;

        public void SetRotationAngles(float x, float y, float z)
        {
            angleX = x;
            angleY = y;
            angleZ = z;

            // Label güncellemesi
            label47.Text = $"{angleX:F2}°";
            label51.Text = $"{angleZ:F2}°";
            label49.Text = $"{angleY:F2}°";

            glControl3D.Invalidate(); // OpenGL sahnesini yeniden çiz
        }
        

        private void GlControl1_Resize(object sender, EventArgs e)
        {
            if (!glControl3D.Context.IsCurrent)
                glControl3D.MakeCurrent();

            GL.Viewport(0, 0, glControl3D.Width, glControl3D.Height);

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
            MathHelper.PiOver4,
                glControl3D.Width / (float)glControl3D.Height,
                0.1f, 100f);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        private void GlControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!glControl3D.Context.IsCurrent)
                glControl3D.MakeCurrent();

            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);

            //Matrix4 modelview = Matrix4.LookAt(Vector3.UnitZ * 5, Vector3.Zero, Vector3.UnitY);
            //Matrix4 modelview = Matrix4.LookAt(new Vector3(5, 0, 0), Vector3.Zero, Vector3.UnitY);
            // Diagonal 3D bakış
            //Matrix4 modelview = Matrix4.LookAt(new Vector3(5, 5, 5), Vector3.Zero, Vector3.UnitY);
            Matrix4 modelview = Matrix4.LookAt(
                new Vector3(0, 5, 0),      // Kamera Y ekseninde, yukarıdan değil — içeri bakıyor
                Vector3.Zero,             // Modelin merkezine bak
                Vector3.UnitZ             // Yukarı yön Z (cihazda da yukarı Z)
            );

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            // Açıları uygula
            GL.Rotate(angleX, 1, 0, 0);
            GL.Rotate(angleY, 0, 1, 0);
            GL.Rotate(angleZ, 0, 0, 1);

            DrawCylinder(1f, 1f, 2f, 32);

            glControl3D.SwapBuffers();
        }


        /*
        for (int i = 0; i <= segments; i++)
        {
            float angle = (float)(2.0 * Math.PI * i / segments);
            float x = (float)Math.Cos(angle);
            float y = (float)Math.Sin(angle);

            // Bordo kırmızı
            GL.Color3(0.5f, 0.0f, 0.13f);
            GL.Vertex3(x * radiusTop, y * radiusTop, +halfHeight);
            GL.Vertex3(x * radiusBottom, y * radiusBottom, -halfHeight);
        }
        */

        /*
        private void DrawCylinder(float radiusTop, float radiusBottom, float height, int segments)
        {
            float halfHeight = height / 2f;

            // Gövde - Bordo kırmızı tonunda
            GL.Begin(PrimitiveType.QuadStrip);


            for (int i = 0; i <= segments; i++)
            {
                float angle = (float)(2.0 * Math.PI * i / segments);
                float x = (float)Math.Cos(angle);
                float y = (float)Math.Sin(angle);

                // Belirli aralıklarla beyaz çizgi efekti (örneğin her 8. segment)
                if (i % 8 == 0)
                    GL.Color3(1.0f, 1.0f, 1.0f); // beyaz çizgi
                else
                    GL.Color3(0.5f, 0.0f, 0.13f); // bordo kırmızı

                GL.Vertex3(x * radiusTop, y * radiusTop, +halfHeight);
                GL.Vertex3(x * radiusBottom, y * radiusBottom, -halfHeight);
            }
            GL.End();

            // Üst kapak - Alternatif dilimleme beyaz ve koyu mavi
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(0.0f, 0.0f, 0.5f); // merkez koyu mavi
            GL.Vertex3(0, 0, +halfHeight);

            for (int i = 0; i <= segments; i++)
            {
                float angle = (float)(2.0 * Math.PI * i / segments);
                float x = (float)Math.Cos(angle);
                float y = (float)Math.Sin(angle);

                // Dilim renkleri: çift index koyu mavi, tek index beyaz
                if (i % 2 == 0)
                    GL.Color3(0.0f, 0.0f, 0.5f); // koyu mavi
                else
                    GL.Color3(1.0f, 1.0f, 1.0f); // beyaz

                GL.Vertex3(x * radiusTop, y * radiusTop, +halfHeight);
            }
            GL.End();

            // Alt kapak - Alternatif dilimleme beyaz ve koyu mavi
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(0.0f, 0.0f, 0.5f); // merkez koyu mavi
            GL.Vertex3(0, 0, -halfHeight);

            for (int i = 0; i <= segments; i++)
            {
                float angle = (float)(-2.0 * Math.PI * i / segments);
                float x = (float)Math.Cos(angle);
                float y = (float)Math.Sin(angle);

                // Dilim renkleri: çift index koyu mavi, tek index beyaz
                if (i % 2 == 0)
                    GL.Color3(0.0f, 0.0f, 0.5f); // koyu mavi
                else
                    GL.Color3(1.0f, 1.0f, 1.0f); // beyaz

                GL.Vertex3(x * radiusBottom, y * radiusBottom, -halfHeight);
            }
            GL.End();
        }
        */
        private void DrawCylinder(float radiusTop, float radiusBottom, float height, int segments)
        {
            float halfHeight = height / 2f;

            // Gövde - Bordo kırmızı + beyaz çizgiler
            GL.Begin(PrimitiveType.QuadStrip);
            for (int i = 0; i <= segments; i++)
            {
                float angle = (float)(2.0 * Math.PI * i / segments);
                float x = (float)Math.Cos(angle);
                float y = (float)Math.Sin(angle);

                // Belirli aralıklarla beyaz çizgi efekti (örneğin her 8. segment)
                if (i % 8 == 0)
                    GL.Color3(1.0f, 1.0f, 1.0f); // beyaz çizgi
                else
                    GL.Color3(0.5f, 0.0f, 0.13f); // bordo kırmızı

                GL.Vertex3(x * radiusTop, y * radiusTop, +halfHeight);
                GL.Vertex3(x * radiusBottom, y * radiusBottom, -halfHeight);
            }
            GL.End();

            // Üst kapak - Alternatif dilimleme turuncu ve beyaz
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(1.0f, 0.5f, 0.0f); // merkez turuncu
            GL.Vertex3(0, 0, +halfHeight);

            for (int i = 0; i <= segments; i++)
            {
                float angle = (float)(2.0 * Math.PI * i / segments);
                float x = (float)Math.Cos(angle);
                float y = (float)Math.Sin(angle);

                // Dilim renkleri: çift index turuncu, tek index beyaz
                if (i % 2 == 0)
                    GL.Color3(1.0f, 0.5f, 0.0f); // turuncu
                else
                    GL.Color3(1.0f, 1.0f, 1.0f); // beyaz

                GL.Vertex3(x * radiusTop, y * radiusTop, +halfHeight);
            }
            GL.End();

            // Alt kapak - Alternatif dilimleme yeşil ve beyaz
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(0.0f, 0.6f, 0.0f); // merkez yeşil
            GL.Vertex3(0, 0, -halfHeight);

            for (int i = 0; i <= segments; i++)
            {
                float angle = (float)(-2.0 * Math.PI * i / segments);
                float x = (float)Math.Cos(angle);
                float y = (float)Math.Sin(angle);

                // Dilim renkleri: çift index yeşil, tek index beyaz
                if (i % 2 == 0)
                    GL.Color3(0.0f, 0.6f, 0.0f); // yeşil
                else
                    GL.Color3(1.0f, 1.0f, 1.0f); // beyaz

                GL.Vertex3(x * radiusBottom, y * radiusBottom, -halfHeight);
            }
            GL.End();
        }






        // Zamanlayıcıları başlatır
        private void SetupTimers()
        {
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

        }

        // Seri porttan veri alındığında tetiklenir
       

        //seri port bağlantısı kesildiğinde yapılması gerekenleri güvenli ve kontrollü bir şekilde gerçekleştirmek.
        private void HandleSerialPortDisconnect()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                  
                    serialPort1.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Port kapatılırken hata: {ex.Message}");
            }

            UpdateConnectionStatus(false);
            reconnectTimer.Start();  // Reconnect için timer başlatılır
        }

        //seri porttan veri okumaya çalışırken oluşabilecek zaman aşımı (timeout) hatalarını yönetmek 
        private string ReadDataWithRetry()
        {
            string data = string.Empty;
            int maxRetries = 3;
            int retryCount = 0;

            while (retryCount < maxRetries)
            {
                try
                {
                    data = serialPort1.ReadLine();
                    break;
                }
                catch (TimeoutException)
                {
                    retryCount++;
                    if (retryCount >= maxRetries)
                    {
                        Debug.WriteLine("Max read retries reached");
                        return string.Empty; // veya null
                    }
                    Thread.Sleep(50);
                }
            }

            return data;
        }
       

        //Bu, hata kayıtlarını (logları) tutmak için bir dosya yolu oluşturur
        private readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "serial_errors.log");

        //Uygulamada bir hata (Exception) oluştuğunda, bu hatayı detaylı bir şekilde .log dosyasına kaydeder
        private void LogError(Exception ex, string additionalInfo = null)
        {
            try
            {
                string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Error: {ex.Message}\n" +
                                    $"Stack Trace: {ex.StackTrace}\n" +
                                    $"Additional Info: {additionalInfo ?? "None"}\n\n";

                File.AppendAllText(logFilePath, logMessage);
            }
            catch (Exception logEx)
            {
                Debug.WriteLine($"Logging failed: {logEx.Message}");
            }
        }

        // Gelen veriyi işler, UI'yi günceller, grafiği günceller ve CSV'ye kaydeder
        private void ProcessIncomingData(string data)
        {
            if (TelemetryProcessor.ProcessTelemetryData(data, out TelemetryData telemetry))
            {
                latestTelemetry = telemetry; // En son tarih telemetri verisini güncelle
                UpdateUI(telemetry);


                // Diğer göstergeler
                UpdateSpeedGauge(telemetry);
                UpdateBatteryVoltage(telemetry);
                UpdateAltitudeChart(telemetry);
                UpdateChart(telemetry);
                UpdateTemperatureChart(telemetry);
                UpdateMapPosition(telemetry);
                
                
                SetRotationAngles(float.Parse(telemetry.Pitch, CultureInfo.InvariantCulture),
                                 float.Parse(telemetry.Roll, CultureInfo.InvariantCulture),
                                   float.Parse(telemetry.Yaw, CultureInfo.InvariantCulture));
                
            }
        }


        // UI'yi günceller, telemetri verilerini gösterir
        private void UpdateUI(TelemetryData telemetry)
        {
            try
            {
                // UI güncellemelerini askıya al
                SuspendLayout();

                // 1. Temel Bilgiler
                txt_packet_number.Text = telemetry.PacketNumber;
                txt_satellite_status.Text = telemetry.SatelliteStatus;
                txt_error_code.Text = telemetry.ErrorCode;
                txt_send_time.Text = telemetry.SendTime;
                label_date.Text = telemetry.SendTime;


                // 2. Sensör Verileri
                txt_prs1.Text = $"{telemetry.Pressure1} ";
                txt_prs2.Text = $"{telemetry.Pressure2} ";
                txt_alt1.Text = $"{telemetry.Altitude1} ";
                txt_alt2.Text = $"{telemetry.Altitude2} ";
                txt_alt_dif.Text = $"{telemetry.AltitudeDifference} ";
                txt_des_speed.Text = $"{telemetry.DescentSpeed} ";
                txt_temp.Text = $"{telemetry.Temperature} ";
                txt_battery.Text = $"{telemetry.BatteryVoltage} ";

                // 3. GPS Verileri
                double lat = double.Parse(telemetry.Gps1Latitude) / 1e6;
                double lon = double.Parse(telemetry.Gps1Longitude) / 1e6;

                //txt_latitude.Text = FormatCoordinate(lat.ToString(), "N", "S");
                //txt_longitude.Text = FormatCoordinate(lon.ToString(), "E", "W");
                txt_latitude.Text = FormatCoordinate(lat.ToString(CultureInfo.InvariantCulture));
                txt_longitude.Text = FormatCoordinate(lon.ToString(CultureInfo.InvariantCulture));
                //txt_gps_altitude.Text = $"{telemetry.Gps1Altitude} m";
                txt_gps_altitude.Text = telemetry.Gps1Altitude;

                // 4. Orientasyon
                txt_pitch.Text = $"{telemetry.Pitch}";
                txt_roll.Text = $"{telemetry.Roll}";
                txt_yaw.Text = $"{telemetry.Yaw}";

                // 5. Diğer Veriler
                txt_rhrh.Text = telemetry.RHRH;
                txt_IoT1.Text = telemetry.IoTData1;
                txt_IoT2.Text = telemetry.IoTData2;
                txt_team_number.Text = telemetry.TeamNumber;

                // 6. Durum Göstergeleri
                UpdateStatusIndicators(telemetry);
                UpdateErrorIndicators(telemetry.ErrorCode);


            }
            catch (Exception ex)
            {
                Debug.WriteLine($"UI Update Error: {ex.Message}");
                MessageBox.Show("Veri gösterilirken hata oluştu: " + ex.Message,
                              "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // UI güncellemelerini devam ettir
                ResumeLayout();
            }

        }
        


        // Uydunun genel durumunu progress bar ile gösterir
        private void UpdateStatusIndicators(TelemetryData telemetry)
        {
            try
            {
                int progressValue = CalculateProgressValue(telemetry.SatelliteStatus);
                int clampedValue = Math.Max(MIN_PROGRESS, Math.Min(MAX_PROGRESS, progressValue));
                Color statusColor = GetStatusColor(progressValue);


                this.Invoke((MethodInvoker)(() =>
                {
                    progressBar1.Value = clampedValue;
                    progressBar1.ForeColor = statusColor;
                    UpdateLabelStyles(telemetry.SatelliteStatus);
                }));
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Status update error: {ex.Message}");
                ResetIndicators();
            }
        }

        //Bu değerler bir progress bar (ilerleme çubuğu) için aşama değerleri olarak kullanılıyor
        private int CalculateProgressValue(string statusCode)
        {
            if (!int.TryParse(statusCode, out int status))
                return MIN_PROGRESS;

            switch (status)
            {
                case 0: return 17;
                case 1: return 34;
                case 2: return 51;
                case 3: return 68;
                case 4: return 85;
                case 5: return 100;
                default: return MIN_PROGRESS;
            }
        }
        //ilerleme durumunu renklerle göstermek
        private Color GetStatusColor(int progress)
        {
            if (progress < 20)
                return Color.Red; // İlerleme %20'nin altındaysa kırmızı 
            else if (progress < 50)
                return Color.Orange;  // %20 ile %50 arasındaysa turuncu 
            else if (progress < 80)
                return Color.Blue; // %50 ile %80 arasındaysa mavi
            else
                return Color.Green; // %80 ve üstündeyse yeşil
        }

        //progresbarda Duruma göre tek bir label aktif gösteriliyor.
        private void UpdateLabelStyles(string statusCode)
        {
            if (!int.TryParse(statusCode, out int activeIndex))
                activeIndex = -1;

            var labels = new[]
            {
                lbl_ready_to_fly, lbl_ascent, lbl_model_landing,
                lbl_seperate, lbl_payload_landing, lbl_recovery
            };

            for (int i = 0; i < labels.Length; i++)
            {
                bool isActive = i == activeIndex;

                labels[i].Font = new Font(labels[i].Font,
                    isActive ? FontStyle.Bold : FontStyle.Regular);

                labels[i].ForeColor = isActive ? Color.DarkRed : SystemColors.ControlText;
                labels[i].BackColor = isActive ? Color.LightGray : SystemColors.Control;
            }
        }
        // Bu metot, UI göstergelerini(progress bar ve etiketler) sıfırlamak veya varsayılan durumlarına geri döndürmek için kullanılır.
        private void ResetIndicators()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(ResetIndicators));
                return;
            }

            progressBar1.Value = MIN_PROGRESS;
            foreach (var label in new[] { lbl_ready_to_fly, lbl_ascent /* diğerleri */ })
            {
                label.Font = new Font(label.Font, FontStyle.Regular);
                label.ForeColor = SystemColors.ControlText;
            }
        }


        // Hata açıklamaları sözlüğü 
        private readonly Dictionary<int, string> errorDescriptions = new Dictionary<int, string>()
        {
          {0, "Model iniş hızı anormal"},
          {1, "Görev yükü iniş hızı anormal"},
          {2, "Taşıyıcı basınç verisi yok"},
          {3, "Görev yükü konum verisi yok"},
          {4, "Ayrılma gerçekleşmedi"},
          {5, "Multi-spektral filtre çalışmıyor"}
        };

        // Hata kodu göstergelerini günceller, renkleri ayarlar
        private void UpdateErrorIndicators(string errorCode)
        {
            PictureBox[] indicators = {
                pic_error_code_0, pic_error_code_1, pic_error_code_2,
                pic_error_code_3, pic_error_code_4, pic_error_code_5
            };

            // Tüm göstergeleri varsayılan gri yap
            foreach (var pic in indicators)
            {
                pic.BackColor = Color.LightGray;
            }

            // ListBox'ı temizle ve yeni başlık ekle
            listBox1.Items.Clear();
            string formattedErrorCode = string.IsNullOrEmpty(errorCode) ? "000000" : errorCode;
            listBox1.Items.Add($"HATA KODU: <{formattedErrorCode}>");
            listBox1.Items.Add("--------------------------");

            // Geçerli bir hata kodu varsa işle
            if (!string.IsNullOrEmpty(errorCode))
            {
                for (int i = 0; i < Math.Min(indicators.Length, errorCode.Length); i++)
                {
                    switch (errorCode[i])
                    {
                        case '1': // Hata durumu
                            indicators[i].BackColor = Color.Red;
                            // Uyarı işaretleri olmadan, başına hata numarası (1 bazlı) ekliyoruz
                            listBox1.Items.Add($"{i + 1} - {errorDescriptions[i]}");
                            break;

                        case '0': // Normal durum
                            indicators[i].BackColor = Color.Green;
                            break;

                        default: // Geçersiz kod
                            indicators[i].BackColor = Color.LightGray;
                            break;
                    }
                }
            }

            // Hata yoksa bilgi mesajı ekle
            if (formattedErrorCode == "000000")
            {
                listBox1.Items.Add("✅ Sistemler normal");
            }

            // Otomatik scroll özelliği
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }


        private string telemetrySavePath = string.Empty; // Telemetri dosya yolu burada tutulacak

        private StreamWriter telemetryCsvWriter = null;

        //telemetri verilerini CSV dosyasına yazmak için bir dosya yazıcı nesnesini başlatır ve yapılandırır.
        private void InitializeCsvWriter()
        {
            if (string.IsNullOrEmpty(telemetrySavePath))
            {
                MessageBox.Show("Telemetri kayıt yolu boş, CSV yazıcı oluşturulamadı.");
                return;
            }

            bool fileExists = File.Exists(telemetrySavePath);

            // UTF-8 ile açtım ki  ÖZEL KARAKTERLER (° gibi) bozulmasın
            telemetryCsvWriter = new StreamWriter(telemetrySavePath, append: true, encoding: Encoding.UTF8);

            // Dosya yoksa veya VAR ama BOŞSA başlığı yaz
            var fi = new FileInfo(telemetrySavePath);
            if (!fileExists || fi.Length == 0)
            {
                string header = "PacketNumber,SatelliteStatus,ErrorCode,SendTime," +
                                "Pressure1,Pressure2,Altitude1,Altitude2,AltitudeDifference,DescentSpeed,Temperature,BatteryVoltage," +
                                "Gps1Latitude,Gps1Longitude,Gps1Altitude,Pitch,Roll,Yaw,RHRH,IoTData1,IoTData2,TeamNumber";
                telemetryCsvWriter.WriteLine(header);
                //telemetryCsvWriter.Flush();
            }
        }

        // CSV yazıcıyı kapatır, kaynakları serbest bırakır
        private void CloseCsvWriter()
        {
            if (telemetryCsvWriter != null)
            {
                telemetryCsvWriter.Flush();
                telemetryCsvWriter.Close();
                telemetryCsvWriter.Dispose();
                telemetryCsvWriter = null;
            }
        }


        // CSV dosyasına veriyi kaydeder, hata ayıklama için konsola yazdırır
        /*
        private void SaveToCsv(TelemetryData telemetry)
        {
            try
            {
              

                double lat = double.Parse(telemetry.Gps1Latitude) / 1e6;
                double lon = double.Parse(telemetry.Gps1Longitude) / 1e6;

                
               //string formattedLatitude = FormatCoordinate(lat.ToString(), "N", "S");
               //string formattedLongitude = FormatCoordinate(lon.ToString(), "E", "W");
                string formattedLatitude = FormatCoordinate(lat.ToString());
                string formattedLongitude = FormatCoordinate(lon.ToString());

                string line = string.Join(",",
                    telemetry.PacketNumber,
                    telemetry.SatelliteStatus,
                    telemetry.ErrorCode,
                    telemetry.SendTime,
                    telemetry.Pressure1,
                    telemetry.Pressure2,
                    telemetry.Altitude1,
                    telemetry.Altitude2,
                    telemetry.AltitudeDifference,
                    telemetry.DescentSpeed,
                    telemetry.Temperature,
                    telemetry.BatteryVoltage,
                    //$"\"{formattedLatitude}\"",
                    //$"\"{formattedLongitude}\"",
                    formattedLatitude,
                    formattedLongitude,
                    telemetry.Gps1Altitude,
                    telemetry.Pitch,
                    telemetry.Roll,
                    telemetry.Yaw,
                    telemetry.RHRH,
                    telemetry.IoTData1,
                    telemetry.IoTData2,
                    telemetry.TeamNumber
                );

                telemetryCsvWriter.Write(line);
                telemetryCsvWriter.Flush(); // Performansı arttırmak için burayı optimize edebiliriz (örneğin belli aralıklarla flush)
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CSV Save Error: {ex.Message}");
               
            }
        }
        */


        /*
        private string FormatCoordinate(string value)
        {
            if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double coord))
                return coord.ToString("F6", CultureInfo.InvariantCulture);
            else
                return value;
        }
        */

        private string FormatCoordinate(string value)
        {
            // Nokta ile ondalık ayırıcı kullanmak için düzeltme
            value = value.Replace(',', '.');

            if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double coord))
                return coord.ToString("F6", CultureInfo.InvariantCulture);
            else
                return value;
        }

        private int csvWriteCount = 0;

        private void SaveToCsv(TelemetryData telemetry)
        {
            try
            {
                if (telemetryCsvWriter == null)
                {
                    Debug.WriteLine("CSV yazıcı başlatılmamış. SaveToCsv atlandı.");
                    return;
                }

                double lat = double.Parse(telemetry.Gps1Latitude) / 1e6;
                double lon = double.Parse(telemetry.Gps1Longitude) / 1e6;

                string formattedLatitude = FormatCoordinate(lat.ToString());
                string formattedLongitude = FormatCoordinate(lon.ToString());

                string line = string.Join(",",
                    telemetry.PacketNumber,
                    telemetry.SatelliteStatus,
                    telemetry.ErrorCode,
                    telemetry.SendTime,
                    telemetry.Pressure1,
                    telemetry.Pressure2,
                    telemetry.Altitude1,
                    telemetry.Altitude2,
                    telemetry.AltitudeDifference,
                    telemetry.DescentSpeed,
                    telemetry.Temperature,
                    telemetry.BatteryVoltage,
                    formattedLatitude,
                    formattedLongitude,
                    telemetry.Gps1Altitude,
                    telemetry.Pitch,
                    telemetry.Roll,
                    telemetry.Yaw,
                    telemetry.RHRH,
                    telemetry.IoTData1,
                    telemetry.IoTData2,
                    telemetry.TeamNumber
                );

                telemetryCsvWriter.Write(line);

                // Her 100 satırda bir flush
                csvWriteCount++;
                if (csvWriteCount % 100 == 0)
                {
                    telemetryCsvWriter.Flush();
                }

                //telemetryCsvWriter.Flush();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CSV Save Error: {ex.Message}");
            }
        }




    // Form yüklendiğinde seri portları ve kamera cihazlarını yükler, zamanlayıcıları başlatır
    private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var currentPorts = SerialPort.GetPortNames();
                if (!currentPorts.SequenceEqual(previousPorts))
                {
                    cmbSerialComPort.BeginInvoke((MethodInvoker)delegate
                    {
                        cmbSerialComPort.SuspendLayout();    // Düzeni askıya al
                        cmbSerialComPort.Items.Clear();
                        cmbSerialComPort.Items.AddRange(currentPorts);
                        if (cmbSerialComPort.Items.Count > 0 && !serialPort1.IsOpen)
                            cmbSerialComPort.SelectedIndex = 0;
                        cmbSerialComPort.ResumeLayout();     // Düzeni tekrar etkinleştir
                    });
                    previousPorts = currentPorts;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Port tarama hatası: {ex.Message}");
            }
        }

        // En son alınan tarih telemetri verisini tutmak için sınıf seviyesinde bir alan ekleyin
        private TelemetryData? latestTelemetry = null;


       

        // bağlantı durumunu gösterir
        private void UpdateConnectionStatus(bool isConnected)
        {
            // Kamera bağlı mı?
            bool isCameraConnected = (_videoSource != null && _videoSource.IsRunning);

            // Seri port bağlı mı?
            bool isPortConnected = (serialPort1 != null && serialPort1.IsOpen);

            if (!isCameraConnected && !isPortConnected)
            {
                // Hiç bağlantı yok - Kırmızı
                lblStatus.BackColor = Color.Red;
               
            }
            else if (isCameraConnected && isPortConnected)
            {
                // İki bağlantı da var - Yeşil
                lblStatus.BackColor = Color.LimeGreen;
                
            }
            else
            {
                // Sadece biri bağlı - Turuncu
                lblStatus.BackColor = Color.Orange;
                
            }
        }


       

        // komut gönder butonu
        private async void btnSendData2_Click(object sender, EventArgs e)
        {
            await AnimateButtonColor(btnSendData2); // Görsel geri bildirim

            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Seri port açık değil. Lütfen önce portu açın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string komut = txtSendData.Text.Trim();

            if (string.IsNullOrEmpty(komut))
            {
                MessageBox.Show("Gönderilecek veri boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string gonderilecekVeri;

                if (checkBox1.Checked) // ← checkbox ismine göre düzenle
                {
                    // Sistem kontrol komutu → 0,0,<komut>
                    gonderilecekVeri = $"0,0,{komut}";

                    //  START TASK özel durumu
                    if (komut.Equals("START TASK", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            // 1) CSV writer kapat
                            CloseCsvWriter();

                            // 2) Dosya yolu seçildiyse içeriği temizle
                            if (!string.IsNullOrEmpty(telemetrySavePath))
                            {
                                File.WriteAllText(telemetrySavePath, string.Empty);
                            }

                            // 3) Yeniden başlat (başlık satırı tekrar yazılır)
                            InitializeCsvWriter();

                            MessageBox.Show("CSV dosyası sıfırlandı ve kayıt yeniden başlatıldı.",
                                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"CSV sıfırlama hatası: {ex.Message}",
                                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Renk filtre komutu → 0,<komut>,0
                    gonderilecekVeri = $"0,{komut},0";
                }

                serialPort1.WriteLine(gonderilecekVeri); // komutu seri porta gönder

                 // Eğer START TASK değilse genel mesajı göster
                if (!(checkBox1.Checked && komut.Equals("START TASK", StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Veri başarıyla gönderildi.",
                                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gönderme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //bağlantıyı kes butonu
        /* private async void btnDisconnect_Click(object sender, EventArgs e)
         {
             await AnimateButtonColor(btnDisconnect);

             try
             {
                 uiUpdateTimer.Stop();     //  Önce timer durmalı ki arka planda veri işlenmesin
                 CloseCsvWriter();         //  CSV dosyası kapanmalı

                 await Task.Run(() =>
                 {
                     StopAllConnections(); //  Portları ve bağlantıyı kapat
                     StopVideo();          //  Kamerayı durdur
                 });

                 camera_statuspic.BackColor = Color.Red;
                 UpdateConnectionStatus(false);
                 isGpsTrackingEnabled = false;
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Bağlantı durdurulurken hata oluştu:\n{ex.Message}");
             }
         }

         */
        /*
        private async void btnDisconnect_Click(object sender, EventArgs e)
        {
            await AnimateButtonColor(btnDisconnect);

            try
            {
                // Timer null mu? Önce kontrol et
                uiUpdateTimer?.Stop();

                // CSV güvenli şekilde kapat
                CloseCsvWriter();

                // Ağ ve video işlemlerini arka planda durdur
                await Task.Run(() =>
                {
                    try
                    {
                        StopAllConnections();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("StopAllConnections hatası: " + ex.Message);
                    }

                    try
                    {
                        StopVideo();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("StopVideo hatası: " + ex.Message);
                    }
                });

                // Bağlantı durumu ve UI güncelle
                camera_statuspic.BackColor = Color.Red;
                UpdateConnectionStatus(false);
                isGpsTrackingEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bağlantı durdurulurken hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        /*
        private async void btnDisconnect_Click(object sender, EventArgs e)
        {
            await AnimateButtonColor(btnDisconnect);

            try
            {
                // Timer'ı durdur (UI thread)
                uiUpdateTimer?.Stop();

                // CSV Writer'ı kapat
                CloseCsvWriter();

                // Seri portu UI thread'de durdur (sync, hızlı)
                StopAllConnections();

                // Videoyu durdur async olarak UI thread'de
                await StopVideoAsync();

                // UI güncelleme
                camera_statuspic.BackColor = Color.Red;
                UpdateConnectionStatus(false);
                isGpsTrackingEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bağlantı durdurulurken hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        private bool isDisconnecting = false;

        private async void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (isDisconnecting) return; // çoklu tıklamayı engelle
            isDisconnecting = true;
            //await AnimateButtonColor(btnDisconnect);
            try
            {
                btnDisconnect.Enabled = false;
                btnConnect.Enabled = false;

                // Timer durdur
                uiUpdateTimer?.Stop();

                // CSV Writer kapat
                CloseCsvWriter();

                // ✅ BackgroundWorker iptali
                if (serialWorker != null && serialWorker.IsBusy)
                {
                    serialWorker.CancelAsync();
                }

                // Seri port bağlantısını kapat (bloklayıcı olduğu için ayrı thread)
                await Task.Run(() =>
                {
                    try { StopAllConnections(); }
                    catch (Exception ex) { Debug.WriteLine("StopAllConnections error: " + ex.Message); }
                });

                // Video durdur (async)
                try
                {
                    await StopVideoAsync();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("StopVideoAsync error: " + ex.Message);
                }

                // UI güncelle
                camera_statuspic.BackColor = Color.Red;
                UpdateConnectionStatus(false);
                isGpsTrackingEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bağlantı durdurulurken hata oluştu:\n{ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDisconnect.Enabled = true;
                btnConnect.Enabled = true;
                isDisconnecting = false;
            }
        }

        // Tüm bağlantıları durdurur: seri port ve kamera
        /*
        private void StopAllConnections()
        {
            try
            {
                if (serialPort1 != null)
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.DataReceived -= SerialPort1_DataReceived; // varsa event handler'ı çıkar
                        serialPort1.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port kapatılırken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        */
        private void StopAllConnections()
        {
            try
            {
                if (serialPort1 != null && serialPort1.IsOpen)
                {
                 
                    serialPort1.Close();
                }

                if (serialWorker.IsBusy)
                    serialWorker.CancelAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port kapatılırken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Telemetri verilerini işleyen ve gösteren sınıf
        public static class TelemetryProcessor
        {
            public static bool ProcessTelemetryData(string rawData, out TelemetryData telemetry)
            {
                telemetry = new TelemetryData();
                try
                {
                    string[] parts = rawData.Split(',');
                    if (parts.Length < 22) return false;

                    telemetry.PacketNumber = parts[0];
                    telemetry.SatelliteStatus = parts[1];
                    telemetry.ErrorCode = parts[2];
                    telemetry.SendTime = parts[3];
                    telemetry.Pressure1 = parts[4];
                    telemetry.Pressure2 = parts[5];
                    telemetry.Altitude1 = parts[6];
                    telemetry.Altitude2 = parts[7];
                    telemetry.AltitudeDifference = parts[8];
                    telemetry.DescentSpeed = parts[9];
                    telemetry.Temperature = parts[10];
                    telemetry.BatteryVoltage = parts[11];
                    telemetry.Gps1Latitude = parts[12];
                    telemetry.Gps1Longitude = parts[13];
                    telemetry.Gps1Altitude = parts[14];
                    telemetry.Pitch = parts[15];
                    telemetry.Roll = parts[16];
                    telemetry.Yaw = parts[17];
                    telemetry.RHRH = parts[18];
                    telemetry.IoTData1 = parts[19];
                    telemetry.IoTData2 = parts[20];
                    telemetry.TeamNumber = parts[21];

                    return true;
                }
                catch
                {
                    return false;
                }
            }

        }
        // Telemetri verilerinin kayıt yolunu seçtirme
        private void telemetriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Dosyası (*.csv)|*.csv";
            saveFileDialog.Title = "Telemetri Kaydını Kaydet";
            saveFileDialog.FileName = "telemetri_kayit.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                telemetrySavePath = saveFileDialog.FileName;
                MessageBox.Show("Telemetri verisi kaydedilecek konum seçildi:\n" + telemetrySavePath,
                                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // BURADA ÇAĞIR
                InitializeCsvWriter();
            }
        }


        private string _videoSavePath = string.Empty;
        // Video kayıt yolu seçtirme menü öğesi
        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "AVI Video (*.avi)|*.avi";
            saveFileDialog.Title = "Video Kaydını Kaydet";
            saveFileDialog.FileName = "kayit.avi";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _videoSavePath = saveFileDialog.FileName;
                MessageBox.Show("Video kaydedilecek konum seçildi:\n" + _videoSavePath, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /* 
        private void StartVideo()
         {
             if (_videoDevices.Count == 0 || comboBox_cam.SelectedIndex < 0)
             {
                 MessageBox.Show("Lütfen bir kamera seçin.");
                 return;
             }

             if (string.IsNullOrEmpty(_videoSavePath))
             {
                 MessageBox.Show("Lütfen önce 'Video Kaydını Kaydet' menüsünden bir kayıt konumu seçin.");
                 return;
             }

             // Kamera kaynağını oluştur
             _videoSource = new VideoCaptureDevice(_videoDevices[comboBox_cam.SelectedIndex].MonikerString);

             // En yüksek çözünürlüğü ayarla
             VideoCapabilities[] capabilities = _videoSource.VideoCapabilities;
             if (capabilities.Length > 0)
             {
                 var highestResolution = capabilities
                     .OrderByDescending(c => c.FrameSize.Width * c.FrameSize.Height)
                     .First();

                 _videoSource.VideoResolution = highestResolution;

                 MessageBox.Show($"Seçilen çözünürlük: {highestResolution.FrameSize.Width}x{highestResolution.FrameSize.Height}");

                 // Video player'ı başlat
                 videoSourcePlayer.VideoSource = _videoSource;
                 videoSourcePlayer.Start();

                 // Video kaydını başlat
                 int width = highestResolution.FrameSize.Width;
                 int height = highestResolution.FrameSize.Height;
                 int fps = highestResolution.AverageFrameRate > 0 ? highestResolution.AverageFrameRate : 25;
                 int bitrate = 5000000; // 5 Mbps

                 try
                 {
                     videoWriter = new VideoFileWriter();
                     videoWriter.Open(
                         _videoSavePath,   // Kaydedilecek dosya yolu
                         width,
                         height,
                         fps,
                         VideoCodec.MPEG4,
                         bitrate
                     );

                     isRecording = true;
                     MessageBox.Show($"Kayıt başladı: {width}x{height}, {fps} fps");
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Video kaydedici başlatılırken hata oluştu:\n" + ex.Message);
                 }

                 // Frame event'ine abone ol
                 _videoSource.NewFrame += VideoSource_NewFrame;

                 MessageBox.Show("Kamera bağlandı ve video gösterimi başladı.");
             }
             else
             {
                 MessageBox.Show("Kamera çözünürlük bilgisi alınamadı.");
             }
         }
        */

        private BackgroundWorker videoWorker;
        private BlockingCollection<Bitmap> videoFrameQueue;

        private int videoFrameWidth;
        private int videoFrameHeight;
        private int videoFrameRate;
        private void StartVideo()
        {
            if (_videoDevices.Count == 0 || comboBox_cam.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir kamera seçin.");
                return;
            }

            if (string.IsNullOrEmpty(_videoSavePath))
            {
                MessageBox.Show("Lütfen önce 'Video Kaydını Kaydet' menüsünden bir kayıt konumu seçin.");
                return;
            }

            // Kamera kaynağını oluştur
            _videoSource = new VideoCaptureDevice(_videoDevices[comboBox_cam.SelectedIndex].MonikerString);

            VideoCapabilities[] capabilities = _videoSource.VideoCapabilities;
            if (capabilities.Length == 0)
            {
                MessageBox.Show("Kamera çözünürlük bilgisi alınamadı.");
                return;
            }

            var highestResolution = capabilities
                .OrderByDescending(c => c.FrameSize.Width * c.FrameSize.Height)
                .First();

            _videoSource.VideoResolution = highestResolution;

            int width = highestResolution.FrameSize.Width;
            int height = highestResolution.FrameSize.Height;
            int fps = highestResolution.AverageFrameRate > 0 ? highestResolution.AverageFrameRate : 25;

            // Bu bilgileri arka planda kullanacağız, global değişkenlerde sakla
            videoFrameWidth = width;
            videoFrameHeight = height;
            videoFrameRate = fps;

            // Arka plan frame kuyruğunu başlat
            videoFrameQueue = new BlockingCollection<Bitmap>(boundedCapacity: 100);

            // Kayıt başladığını işaretle
            isRecording = true;

            // Arka plan işçisini başlat
            if (!videoWorker.IsBusy)
            {
                videoWorker.RunWorkerAsync();
            }

            // Video gösterim başlat (opsiyonel UI'de izleme için)
            videoSourcePlayer.VideoSource = _videoSource;
            videoSourcePlayer.Start();

            // Frame event'e abone ol
            _videoSource.NewFrame += VideoSource_NewFrame;

            MessageBox.Show($"Kamera bağlandı ve video gösterimi başladı.\nKayıt başlayacak: {width}x{height}, {fps} fps");
        }

        

        private bool wasRecordingStopped = false;
        private readonly object videoWriterLock = new object();

        /*
        private void StopVideo()
        {
            try
            {
                // Kaydı durdur
                if (isRecording)
                {
                    isRecording = false;
                    wasRecordingStopped = true;

                    lock (videoWriterLock)
                    {
                        if (videoWriter != null)
                        {
                            if (videoWriter.IsOpen)
                                videoWriter.Close();

                            videoWriter.Dispose();
                            videoWriter = null;
                        }
                    }
                }

                // Kamera kaynağını durdur
                if (_videoSource != null)
                {
                    // NewFrame event'inden çık
                    _videoSource.NewFrame -= VideoSource_NewFrame;

                    // Video player UI üzerinde çalıştığı için Invoke et
                    if (videoSourcePlayer.InvokeRequired)
                    {
                        videoSourcePlayer.Invoke(new Action(() =>
                        {
                            if (videoSourcePlayer.VideoSource != null && videoSourcePlayer.IsRunning)
                            {
                                videoSourcePlayer.SignalToStop();
                                videoSourcePlayer.WaitForStop();
                                videoSourcePlayer.VideoSource = null;
                            }
                        }));
                    }
                    else
                    {
                        if (videoSourcePlayer.VideoSource != null && videoSourcePlayer.IsRunning)
                        {
                            videoSourcePlayer.SignalToStop();
                            videoSourcePlayer.WaitForStop();
                            videoSourcePlayer.VideoSource = null;
                        }
                    }

                    if (_videoSource.IsRunning)
                    {
                        _videoSource.SignalToStop();
                        _videoSource.WaitForStop();
                    }

                    _videoSource = null;
                }
            }
            catch (Exception ex)
            {
                // Uygulama çökmesin diye doğrudan throw yerine log veya mesaj göster
                MessageBox.Show("Video durdurulurken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        /*
        rivate Task StopVideoAsync()
        {
            return Task.Run(() =>
            {
                try
                {
                    if (isRecording)
                    {
                        isRecording = false;
                        wasRecordingStopped = true;

                        lock (videoWriterLock)
                        {
                            if (videoWriter != null)
                            {
                                if (videoWriter.IsOpen)
                                    videoWriter.Close();

                                videoWriter.Dispose();
                                videoWriter = null;
                            }
                        }
                    }

                    if (_videoSource != null)
                    {
                        // NewFrame event'inden çıkar (UI thread gerekli)
                        videoSourcePlayer.Invoke(new Action(() =>
                        {
                            _videoSource.NewFrame -= VideoSource_NewFrame;

                            if (videoSourcePlayer.VideoSource != null && videoSourcePlayer.IsRunning)
                            {
                                videoSourcePlayer.SignalToStop();
                                videoSourcePlayer.WaitForStop();
                                videoSourcePlayer.VideoSource = null;
                            }
                        }));

                        if (_videoSource.IsRunning)
                        {
                            _videoSource.SignalToStop();
                            _videoSource.WaitForStop();
                        }

                        _videoSource = null;
                    }
                }
                catch (Exception ex)
                {
                    // Log veya mesaj göster
                    videoSourcePlayer.Invoke(new Action(() =>
                    {
                        MessageBox.Show("Video durdurulurken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
            });
        }
        */

        /*
        private async Task StopVideoAsync()
        {
            try
            {
                if (isRecording)
                {
                    isRecording = false;
                    wasRecordingStopped = true;

                    lock (videoWriterLock)
                    {
                        if (videoWriter != null)
                        {
                            if (videoWriter.IsOpen)
                                videoWriter.Close();

                            videoWriter.Dispose();
                            videoWriter = null;
                        }
                    }
                }

                if (_videoSource != null)
                {
                    // NewFrame event handler'ı UI thread'de kaldır
                    if (videoSourcePlayer.InvokeRequired)
                    {
                        var tcs = new TaskCompletionSource<bool>();
                        videoSourcePlayer.BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                _videoSource.NewFrame -= VideoSource_NewFrame;
                                tcs.SetResult(true);
                            }
                            catch (Exception ex)
                            {
                                tcs.SetException(ex);
                            }
                        }));
                        await tcs.Task;
                    }
                    else
                    {
                        _videoSource.NewFrame -= VideoSource_NewFrame;
                    }

                    // Kamera durdurma işlemini ayrı thread'de çalıştır
                    await Task.Run(() =>
                    {
                        try
                        {
                            if (videoSourcePlayer.InvokeRequired)
                            {
                                videoSourcePlayer.Invoke(new Action(() =>
                                {
                                    if (videoSourcePlayer.VideoSource != null && videoSourcePlayer.IsRunning)
                                    {
                                        videoSourcePlayer.SignalToStop();
                                        videoSourcePlayer.WaitForStop();
                                        videoSourcePlayer.VideoSource = null;
                                    }
                                }));
                            }
                            else
                            {
                                if (videoSourcePlayer.VideoSource != null && videoSourcePlayer.IsRunning)
                                {
                                    videoSourcePlayer.SignalToStop();
                                    videoSourcePlayer.WaitForStop();
                                    videoSourcePlayer.VideoSource = null;
                                }
                            }

                            if (_videoSource.IsRunning)
                            {
                                _videoSource.SignalToStop();
                                _videoSource.WaitForStop();
                            }

                            _videoSource = null;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("Kamera durdurma hatası: " + ex.Message);
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("StopVideoAsync dış hata: " + ex.Message);
            }
        }
        */

        private async Task StopVideoAsync()
        {
            try
            {
                if (isRecording)
                {
                    isRecording = false;
                    wasRecordingStopped = true;

                    // ✳️ Arka plan yazımı tamamlamak için kuyruğu kapat
                    if (videoFrameQueue != null && !videoFrameQueue.IsAddingCompleted)
                        videoFrameQueue.CompleteAdding();

                    // ✳️ Arka plan işçisini iptal et
                    if (videoWorker != null && videoWorker.IsBusy)
                    {
                        await Task.Run(() => videoWorker.CancelAsync());
                    }
                }

                // Kamera varsa kapat
                if (_videoSource != null)
                {
                    // Frame event'ini kaldır (UI thread güvenli)
                    if (videoSourcePlayer.InvokeRequired)
                    {
                        var tcs = new TaskCompletionSource<bool>();
                        videoSourcePlayer.BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                _videoSource.NewFrame -= VideoSource_NewFrame;
                                tcs.SetResult(true);
                            }
                            catch (Exception ex)
                            {
                                tcs.SetException(ex);
                            }
                        }));
                        await tcs.Task;
                    }
                    else
                    {
                        _videoSource.NewFrame -= VideoSource_NewFrame;
                    }

                    // Kamera ve player'ı durdur
                    await Task.Run(() =>
                    {
                        try
                        {
                            if (videoSourcePlayer.InvokeRequired)
                            {
                                videoSourcePlayer.Invoke(new Action(() =>
                                {
                                    if (videoSourcePlayer.VideoSource != null && videoSourcePlayer.IsRunning)
                                    {
                                        videoSourcePlayer.SignalToStop();
                                        videoSourcePlayer.WaitForStop();
                                        videoSourcePlayer.VideoSource = null;
                                    }
                                }));
                            }
                            else
                            {
                                if (videoSourcePlayer.VideoSource != null && videoSourcePlayer.IsRunning)
                                {
                                    videoSourcePlayer.SignalToStop();
                                    videoSourcePlayer.WaitForStop();
                                    videoSourcePlayer.VideoSource = null;
                                }
                            }

                            if (_videoSource.IsRunning)
                            {
                                _videoSource.SignalToStop();
                                _videoSource.WaitForStop();
                            }

                            _videoSource = null;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("Kamera durdurma hatası: " + ex.Message);
                        }
                    });
                }

                // ✳️ Kuyruğu tekrar kullanılabilir hale getir
                videoFrameQueue = new BlockingCollection<Bitmap>(boundedCapacity: 100);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("StopVideoAsync dış hata: " + ex.Message);
            }
        }

        private void SafeActionOnUIThread(Action action)
        {
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }


        /*
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                // Kamera çalışıyorsa status yeşil
                Invoke(new Action(() =>
                {
                    camera_statuspic.BackColor = Color.LimeGreen;
                }));

                if (!isRecording)
                    return;

                Bitmap safeFrame = new Bitmap(eventArgs.Frame.Width, eventArgs.Frame.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                using (Graphics g = Graphics.FromImage(safeFrame))
                {
                    g.DrawImage(eventArgs.Frame, 0, 0); // Güvenli kopyalama
                }

                lock (videoWriterLock)
                {
                    if (videoWriter != null && videoWriter.IsOpen)
                    {
                        videoWriter.WriteVideoFrame(safeFrame); // Daha stabil yazma
                    }
                }

                safeFrame.Dispose();
            }
            catch (AccessViolationException ex)
            {
                Console.WriteLine("Erişim hatası (frame): " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Frame yazma hatası: " + ex.Message);
            }
        }
        */


        /* çalışan kod
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frameClone = null;
            try
            {
                Invoke(new Action(() =>
                {
                    camera_statuspic.BackColor = Color.LimeGreen;
                }));

                if (!isRecording)
                    return;

                frameClone = (Bitmap)eventArgs.Frame.Clone();

                lock (videoWriterLock)
                {
                    if (videoWriter != null && videoWriter.IsOpen)
                    {
                        videoWriter.WriteVideoFrame(frameClone);
                    }
                }
            }
            catch (AccessViolationException ex)
            {
                Console.WriteLine("Erişim hatası (frame): " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Frame yazma hatası: " + ex.Message);
            }
            finally
            {
                frameClone?.Dispose();
            }
        }
        */

        private void VideoWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // ✔️ Hata burada oluşuyordu çünkü videoWriter null'du
                videoWriter = new VideoFileWriter(); // <-- EKLE!

                lock (videoWriterLock)
                {
                    videoWriter.Open(
                        _videoSavePath,
                        videoFrameWidth,
                        videoFrameHeight,
                        videoFrameRate,
                        VideoCodec.MPEG4,
                        5000000 // bitrate
                    );
                }

                foreach (var frame in videoFrameQueue.GetConsumingEnumerable())
                {
                    if (videoWorker.CancellationPending)
                        break;

                    try
                    {
                        lock (videoWriterLock)
                        {
                            if (videoWriter != null && videoWriter.IsOpen)
                            {
                                videoWriter.WriteVideoFrame(frame);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Arka plan yazım hatası: " + ex.Message);
                    }
                    finally
                    {
                        frame.Dispose();
                    }
                }

                lock (videoWriterLock)
                {
                    if (videoWriter != null && videoWriter.IsOpen)
                        videoWriter.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("VideoWorker hata: " + ex.Message);
            }
        }

        DateTime lastStatusUpdate = DateTime.MinValue;
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Kayıt aktif değilse veya kuyruk kapatılmışsa işlem yapma
            if (!isRecording || videoFrameQueue.IsAddingCompleted)
                return;

            try
            {
                // Frame'i belleğe klonla
                Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

                // Kuyruğa ekle (arka plan işçisi bu frame'i yazacak)
                videoFrameQueue.Add(frame);

                // UI: Kamera simgesini güncelle (1 saniyede bir)
                if ((DateTime.Now - lastStatusUpdate).TotalSeconds >= 1)
                {
                    lastStatusUpdate = DateTime.Now;
                    Invoke(new Action(() =>
                    {
                        camera_statuspic.BackColor = Color.LimeGreen;
                    }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yeni kare kuyruğa alınırken hata: " + ex.Message);
            }
        }


        //seri port bağlantısının otomatik olarak yeniden kurulması için kullanılıyor.
        private System.Windows.Forms.Timer reconnectTimer;
        private const int ReconnectIntervalMs = 5000; // 5 saniye


        private void InitializeReconnectTimer()
        {
            reconnectTimer = new System.Windows.Forms.Timer();
            reconnectTimer.Interval = ReconnectIntervalMs;
            reconnectTimer.Tick += ReconnectTimer_Tick;
        }

        //port bağlantısını kontrol ederek, bağlantı kapalıysa yeniden açmayı dener.
        private void ReconnectTimer_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen && cmbSerialComPort.SelectedItem != null)
            {
                try
                {
                    serialPort1.PortName = cmbSerialComPort.SelectedItem.ToString();
                    serialPort1.Open();
                    reconnectTimer.Stop();
                    UpdateConnectionStatus(true);
                    Debug.WriteLine("Seri port başarıyla yeniden bağlandı.");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Seri port yeniden bağlanamadı: {ex.Message}");
                    UpdateConnectionStatus(false);
                }
            }
        }

           
      
       
        //telemetryQueue telemetri verilerini güvenli şekilde tutar, uiUpdateTimer ise düzenli aralıklarla bu verileri alıp arayüzü günceller.
        //Bu sayede seri porttan gelen veriler UI’da donma olmadan sağlıklı gösterilir.
        private ConcurrentQueue<string> telemetryQueue = new ConcurrentQueue<string>();
        private System.Windows.Forms.Timer uiUpdateTimer;

       

        //  kuyruktan veri alınarak arayüz güncellenir.Böylece UI sürekli güncel kalır ve donmaz.
        private void UiUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (telemetryQueue.IsEmpty) return;

            int processedCount = 0;
            while (telemetryQueue.TryDequeue(out string data) && processedCount < 10)
            {
                try
                {
                    if (TelemetryProcessor.ProcessTelemetryData(data, out TelemetryData telemetry))
                    {

                        //UpdateMapPosition(telemetry); // Harita konumunu güncelle
                        //UpdateSpeedGauge(telemetry); // Hız göstergesini güncelle
                        //UpdateBatteryVoltage(telemetry); // Pil voltajını güncelle

                        //UpdateAltitudeChart(telemetry); // Yükseklik grafiğini güncelle
                        //UpdateTemperatureChart(telemetry); // Sıcaklık grafiğini güncelle
                        //UpdateChart(telemetry); // basınç grafik güncellemeleri

                        SaveToCsv(telemetry); // Telemetri verisini CSV dosyasına kaydet

                        ProcessIncomingData(data); // Gelen veriyi işleme al

                        processedCount++;
                    }
                    else
                    {
                        Debug.WriteLine("Geçersiz telemetry verisi atlandı: " + data);
                    }
                }
                catch (Exception ex)
                {
                    LogError(ex, data);
                }
            }
        }

        private GMap.NET.WindowsForms.GMapOverlay gMapOverlay; // Harita üzerindeki GPS konumunu göstermek için kullanılır.
        private GMap.NET.WindowsForms.GMapMarker gpsMarker; // GPS konumunu göstermek için kullanılır.
        private bool isGpsTrackingEnabled = false;

        // Harita kontrolünü başlatır ve başlangıç konumunu ayarlar.
        private void InitializeMap()
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            gMapControl1.SetPositionByKeywords("Ankara, Turkey"); // Başlangıç konumu
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 17;
            gMapControl1.ShowCenter = false;

            double initialLat = 39.9208;
            double initialLng = 32.8541;

            gMapControl1.Position = new GMap.NET.PointLatLng(39.9208, 32.8541); // Ankara koordinatları

            gMapControl1.Overlays.Clear();
            gMapOverlay = new GMap.NET.WindowsForms.GMapOverlay("gps");
            gMapControl1.Overlays.Add(gMapOverlay);

            label41.Text = $"{initialLat:F6}"; //Enlem
            label43.Text = $"{initialLng:F6}"; //Boylam
            label45.Text = $" N/A"; // yükseklik
        }

        // Telemetri verisinden gelen GPS konumunu harita üzerinde günceller.
        private void UpdateMapPosition(TelemetryData telemetry)
        {
            if (!isGpsTrackingEnabled)
            {
                SetGpsStatus(false);
                return;
            }

            if (string.IsNullOrEmpty(telemetry.Gps1Latitude) || string.IsNullOrEmpty(telemetry.Gps1Longitude))
            {
                SetGpsStatus(false);
                return;
            }

            try
            {
                // Mikro dereceyi dereceye çevir
                var lat = double.Parse(telemetry.Gps1Latitude) / 1e6;
                var lng = double.Parse(telemetry.Gps1Longitude) / 1e6;

                var point = new GMap.NET.PointLatLng(lat, lng);

                gMapOverlay.Markers.Clear();
                gpsMarker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    point,
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
                gMapOverlay.Markers.Add(gpsMarker);
                gMapControl1.Position = point;

                SetGpsStatus(true);

                label41.Text = $"{lat:F6} °K";  // enlem gösterimi
                label43.Text = $"{lng:F6} °D";  // boylam gösterimi

                if (!string.IsNullOrWhiteSpace(telemetry.Gps1Altitude) &&
                    double.TryParse(telemetry.Gps1Altitude, NumberStyles.Any, CultureInfo.InvariantCulture, out double alt))
                {
                    label45.Text = $"{alt:F2} m";
                }
                else
                {
                    label45.Text = "N/A";
                }
            }
            catch (FormatException)
            {
                SetGpsStatus(false);
            }
            catch (Exception ex)
            {
                SetGpsStatus(false);
                Console.WriteLine($"Harita güncelleme hatası: {ex.Message}");
            }
        }
        // GPS durumunu günceller: yeşil (güncel) veya kırmızı (güncel değil)
        private void SetGpsStatus(bool isUpdated)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SetGpsStatus(isUpdated)));
                return;
            }

            pictureBox_gps_status.BackColor = isUpdated ? Color.LimeGreen : Color.Red;
        }

        

        // buton renk animasyonu için kullanılır
        private async Task AnimateButtonColor(Button button)
        {
            var originalColor = button.BackColor;
            var originalForeColor = button.ForeColor;

            button.BackColor = Color.DarkGray;
            button.ForeColor = Color.Black;

            await Task.Delay(150);

            button.BackColor = originalColor;
            button.ForeColor = originalForeColor;
        }

        // hız göstergesi ayarları
        private void SetupSpeedGauge()
        {
            if (angularGauge1 == null || angularGauge1.IsDisposed) return;

            angularGauge1.FromValue = 0;
            angularGauge1.ToValue = 50;
            angularGauge1.Value = 0;  

        }

        // Hız göstergesini günceller
        private void UpdateSpeedGauge(Form1.TelemetryData telemetry)
        {
            if (string.IsNullOrWhiteSpace(telemetry.DescentSpeed) ||
        !double.TryParse(telemetry.DescentSpeed, NumberStyles.Any, CultureInfo.InvariantCulture, out double speed))
            {
                return;
            }

            if (angularGauge1 != null && !angularGauge1.IsDisposed)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        angularGauge1.Value = (float)speed;
                        label6.Text = $"{speed:F2} m/s "; //  hız etiketine yaz
                    }));
                }
                else
                {
                    angularGauge1.Value = (float)speed;
                    label6.Text = $"{speed:F2}  m/s "; //  hız etiketine yaz
                }
            }
        }

        // Pil voltajı göstergesi ayarları (düşük voltajlarda kırmızı, yüksek voltajlarda yeşil renk)
        private void UpdateBatteryVoltage(Form1.TelemetryData telemetry)
        {
            if (string.IsNullOrWhiteSpace(telemetry.BatteryVoltage))
                return;

            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateBatteryVoltage(telemetry)));
                return;
            }

          
            if (double.TryParse(telemetry.BatteryVoltage, NumberStyles.Any, CultureInfo.InvariantCulture, out double voltage))
            {
                solidGauge1.Value = voltage;
            }
        }

        // Pil voltajı göstergesi ayarları
        private void SetupBatteryGauge()
        {
            solidGauge1.From = 6.0;          // minimum voltaj (örnek: 2S LiPo için 6.0V)
            solidGauge1.To = 8.4;            // maksimum voltaj (örnek: 2S LiPo için 8.4V)
            solidGauge1.Value = 0.0;

            // Sabit renkler (düşük: kırmızı, yüksek: yeşil)
            solidGauge1.FromColor = System.Windows.Media.Color.FromRgb(255, 0, 0); // Kırmızı
            solidGauge1.ToColor = System.Windows.Media.Color.FromRgb(0, 255, 0);   // Yeşil

            // Voltaj değeri gauge ortasında gösterilirken birimiyle yazılsın
            solidGauge1.LabelFormatter = val => $"{val:F2} V";

        }

        private DateTime? pressureChartStartTime = null;
        private List<double> pressureValues = new List<double>();

        //basınç grafiği
        private void SetupPressureChart()
        {
            if (chart1.InvokeRequired)
            {
                chart1.Invoke(new Action(SetupPressureChart));
                return;
            }

            try
            {
                chart1.SuspendLayout();
                chart1.Series.Clear();

                pressureChartStartTime = null;
                pressureValues.Clear();

                var area = chart1.ChartAreas[0];
                area.AxisX.Title = "Zaman (s)";
                area.AxisY.Title = "Basınç (Pa)";
                area.AxisX.LabelStyle.Format = "0";
                area.AxisX.IntervalType = DateTimeIntervalType.Number;
                area.CursorX.IsUserSelectionEnabled = true;
                area.CursorX.Interval = 0.1;
                area.CursorY.IsUserSelectionEnabled = true;

                // Dinamik eksen ayarları
                area.AxisY.IsStartedFromZero = false;
                area.AxisX.Minimum = double.NaN;
                area.AxisX.Maximum = double.NaN;
                area.AxisY.Minimum = double.NaN;
                area.AxisY.Maximum = double.NaN;

                Series CreateSeries(string name, Color color) => new Series(name)
                {
                    ChartType = SeriesChartType.FastLine,
                    Color = color,
                    BorderWidth = 2,
                    XValueType = ChartValueType.Double,
                    YValueType = ChartValueType.Double
                };

                chart1.Series.Add(CreateSeries("Basınç1", Color.Blue));
                chart1.Series.Add(CreateSeries("Basınç2", Color.Red));

                SetDoubleBuffered(chart1);
            }
            catch (Exception ex)
            {
                HandleError($"Basınç grafiği kurulum hatası: {ex.Message}");
            }
            finally
            {
                chart1.ResumeLayout();
            }
        }

        private const int MaxChartPoints = 300; // sonrasını sil
        private void UpdateChart(TelemetryData telemetry)
        {
            if (chart1.InvokeRequired)
            {
                chart1.BeginInvoke(new Action(() => UpdateChart(telemetry)));
                return;
            }

            try
            {
                chart1.SuspendLayout();

                if (!double.TryParse(telemetry.Pressure1, NumberStyles.Any, CultureInfo.InvariantCulture, out double pressure1) ||
                    !double.TryParse(telemetry.Pressure2, NumberStyles.Any, CultureInfo.InvariantCulture, out double pressure2))
                    return;

                if (pressureChartStartTime == null)
                {
                    pressureChartStartTime = DateTime.Now;
                }

                double elapsedSeconds = (DateTime.Now - pressureChartStartTime.Value).TotalSeconds;

                // Nokta ekle
                var s1 = chart1.Series["Basınç1"];
                var s2 = chart1.Series["Basınç2"];
                s1.Points.AddXY(elapsedSeconds, pressure1);
                s2.Points.AddXY(elapsedSeconds, pressure2);

                // Bellek sınırlama
                //if (s1.Points.Count > MaxChartPoints) s1.Points.RemoveAt(0);
                //if (s2.Points.Count > MaxChartPoints) s2.Points.RemoveAt(0);

                while (s1.Points.Count > MaxChartPoints)
                {
                    s1.Points.RemoveAt(0);
                }

                while (s2.Points.Count > MaxChartPoints)
                {
                    s2.Points.RemoveAt(0);
                }


                pressureValues.Add(pressure1);
                pressureValues.Add(pressure2);
                if (pressureValues.Count > MaxChartPoints * 2)
                    pressureValues.RemoveRange(0, pressureValues.Count - MaxChartPoints * 2);

                // Ekseni güncelle
                var area = chart1.ChartAreas[0];
                area.AxisX.Minimum = Math.Max(0, elapsedSeconds - 60);
                area.AxisX.Maximum = elapsedSeconds;

                if (pressureValues.Count > 0)
                {
                    double min = pressureValues.Min();
                    double max = pressureValues.Max();
                    double range = max - min;

                    if (range < 100)
                    {
                        double center = (min + max) / 2;
                        area.AxisY.Minimum = center - 50;
                        area.AxisY.Maximum = center + 50;
                    }
                    else
                    {
                        double margin = range * 0.1;
                        area.AxisY.Minimum = min - margin;
                        area.AxisY.Maximum = max + margin;
                    }
                }

                label53.Text = $"{pressure1:F2} Pa";
                label55.Text = $"{pressure2:F2} Pa";

                chart1.Invalidate();
            }
            catch (Exception ex)
            {
                HandleError($"Basınç grafiği güncelleme hatası: {ex.Message}");
            }
            finally
            {
                chart1.ResumeLayout();
            }
        }

        private DateTime? altitudeChartStartTime = null;
        private List<double> altitudeValues = new List<double>();


        // irtifa grafiği 
        private void SetupAltitudeChart()
        {
            if (chart2.InvokeRequired)
            {
                chart2.Invoke(new Action(SetupAltitudeChart));
                return;
            }

            try
            {
                chart2.SuspendLayout();
                chart2.Series.Clear();

                altitudeChartStartTime = null;
                altitudeValues.Clear();

                var area = chart2.ChartAreas[0];
                area.AxisX.Title = "Zaman (s)";
                area.AxisY.Title = "İrtifa (m)";
                area.AxisX.LabelStyle.Format = "0";
                area.AxisX.IntervalType = DateTimeIntervalType.Number;
                area.CursorX.IsUserSelectionEnabled = true;
                area.CursorX.Interval = 0.1;

                // Dinamik eksen ayarları
                area.AxisY.IsStartedFromZero = false;
                area.AxisX.Minimum = double.NaN;
                area.AxisX.Maximum = double.NaN;
                area.AxisY.Minimum = double.NaN;
                area.AxisY.Maximum = double.NaN;

                // İkinci Y ekseni
                area.AxisY2.Enabled = AxisEnabled.True;
                area.AxisY2.Title = "İrtifa Farkı (m)";
                area.AxisY2.TitleForeColor = Color.Green;
                area.AxisY2.LabelStyle.ForeColor = Color.Green;
                area.AxisY2.MajorGrid.Enabled = false;
                area.AxisY2.IsStartedFromZero = false;

                Series CreateSeries(string name, Color color, AxisType yAxisType = AxisType.Primary) => new Series(name)
                {
                    ChartType = SeriesChartType.FastLine,
                    Color = color,
                    BorderWidth = 2,
                    XValueType = ChartValueType.Double,
                    YValueType = ChartValueType.Double,
                    YAxisType = yAxisType
                };

                chart2.Series.Add(CreateSeries("İrtifa1", Color.Blue));
                chart2.Series.Add(CreateSeries("İrtifa2", Color.Red));
                chart2.Series.Add(CreateSeries("İrtifa Farkı", Color.Green, AxisType.Secondary));

                SetDoubleBuffered(chart2);
            }
            catch (Exception ex)
            {
                HandleError($"İrtifa grafiği kurulum hatası: {ex.Message}");
            }
            finally
            {
                chart2.ResumeLayout();
            }
        }

        private void UpdateAltitudeChart(Form1.TelemetryData? telemetry)
        {
            if (telemetry == null)
                return;

            if (chart2.InvokeRequired)
            {
                chart2.BeginInvoke(new Action(() => UpdateAltitudeChart(telemetry)));
                return;
            }

            try
            {
                chart2.SuspendLayout();

                if (!double.TryParse(telemetry.Value.Altitude1, NumberStyles.Any, CultureInfo.InvariantCulture, out double alt1) ||
                    !double.TryParse(telemetry.Value.Altitude2, NumberStyles.Any, CultureInfo.InvariantCulture, out double alt2) ||
                    !double.TryParse(telemetry.Value.AltitudeDifference, NumberStyles.Any, CultureInfo.InvariantCulture, out double altDiff))
                    return;

                if (altitudeChartStartTime == null)
                {
                    altitudeChartStartTime = DateTime.Now;
                }

                double elapsedSeconds = (DateTime.Now - altitudeChartStartTime.Value).TotalSeconds;

                var s1 = chart2.Series["İrtifa1"];
                var s2 = chart2.Series["İrtifa2"];
                var sDiff = chart2.Series["İrtifa Farkı"];

                s1.Points.AddXY(elapsedSeconds, alt1);
                s2.Points.AddXY(elapsedSeconds, alt2);
                sDiff.Points.AddXY(elapsedSeconds, altDiff);

                // Bellek sınırlama
                //if (s1.Points.Count > MaxChartPoints) s1.Points.RemoveAt(0);
                //if (s2.Points.Count > MaxChartPoints) s2.Points.RemoveAt(0);
                //if (sDiff.Points.Count > MaxChartPoints) sDiff.Points.RemoveAt(0);

                while (s1.Points.Count > MaxChartPoints)
                {
                    s1.Points.RemoveAt(0);
                }

                while (s2.Points.Count > MaxChartPoints)
                {
                    s2.Points.RemoveAt(0);
                }

                while (sDiff.Points.Count > MaxChartPoints)
                {
                    sDiff.Points.RemoveAt(0);
                }

                altitudeValues.Add(alt1);
                altitudeValues.Add(alt2);
                altitudeValues.Add(altDiff);
                if (altitudeValues.Count > MaxChartPoints * 3)
                    altitudeValues.RemoveRange(0, altitudeValues.Count - MaxChartPoints * 3);

                var area = chart2.ChartAreas[0];
                area.AxisX.Minimum = Math.Max(0, elapsedSeconds - 60);
                area.AxisX.Maximum = elapsedSeconds;

                if (altitudeValues.Count > 0)
                {
                    double min = altitudeValues.Min();
                    double max = altitudeValues.Max();
                    double range = max - min;

                    if (range < 20)
                    {
                        double center = (min + max) / 2;
                        area.AxisY.Minimum = center - 10;
                        area.AxisY.Maximum = center + 10;
                        area.AxisY2.Minimum = center - 10;
                        area.AxisY2.Maximum = center + 10;
                    }
                    else
                    {
                        double margin = range * 0.1;
                        area.AxisY.Minimum = min - margin;
                        area.AxisY.Maximum = max + margin;
                        area.AxisY2.Minimum = min - margin;
                        area.AxisY2.Maximum = max + margin;
                    }
                }

                label57.Text = $"{alt1:F2} m";
                label59.Text = $"{alt2:F2} m";
                label61.Text = $"{altDiff:F2} m";

                chart2.Invalidate();
            }
            catch (Exception ex)
            {
                HandleError($"İrtifa grafiği güncelleme hatası: {ex.Message}");
            }
            finally
            {
                chart2.ResumeLayout();
            }
        }

        private DateTime? temperatureChartStartTime = null;
        private List<double> temperatureValues = new List<double>();

        private void SetupTemperatureChart()
        {
            if (chart3.InvokeRequired)
            {
                chart3.Invoke(new Action(SetupTemperatureChart));
                return;
            }

            try
            {
                chart3.SuspendLayout();
                chart3.Series.Clear();

                temperatureChartStartTime = null;
                temperatureValues.Clear();

                var area = chart3.ChartAreas[0];
                area.AxisX.Title = "Zaman (s)";
                area.AxisY.Title = "Sıcaklık (°C)";
                area.AxisX.LabelStyle.Format = "0";
                area.AxisX.IntervalType = DateTimeIntervalType.Number;
                area.CursorX.IsUserSelectionEnabled = true;
                area.CursorX.Interval = 0.1;

                area.AxisY.IsStartedFromZero = false;
                area.AxisX.Minimum = double.NaN;
                area.AxisX.Maximum = double.NaN;
                area.AxisY.Minimum = double.NaN;
                area.AxisY.Maximum = double.NaN;

                Series CreateSeries(string name, Color color) => new Series(name)
                {
                    ChartType = SeriesChartType.FastLine,
                    Color = color,
                    BorderWidth = 2,
                    XValueType = ChartValueType.Double,
                    YValueType = ChartValueType.Double
                };

                chart3.Series.Add(CreateSeries("IoT1 Sıcaklık", Color.Orange));
                chart3.Series.Add(CreateSeries("IoT2 Sıcaklık", Color.Cyan));
                chart3.Series.Add(CreateSeries("Sıcaklık", Color.Green));

                SetDoubleBuffered(chart3);
            }
            catch (Exception ex)
            {
                HandleError("Sıcaklık grafiği kurulumu hatası: " + ex.Message);
            }
            finally
            {
                chart3.ResumeLayout();
            }
        }

        private void UpdateTemperatureChart(TelemetryData telemetry)
        {
            if (chart3.InvokeRequired)
            {
                chart3.BeginInvoke(new Action(() => UpdateTemperatureChart(telemetry)));
                return;
            }

            try
            {
                chart3.SuspendLayout();

                bool ok1 = double.TryParse(telemetry.IoTData1, NumberStyles.Any, CultureInfo.InvariantCulture, out double temp1);
                bool ok2 = double.TryParse(telemetry.IoTData2, NumberStyles.Any, CultureInfo.InvariantCulture, out double temp2);
                bool okMain = double.TryParse(telemetry.Temperature, NumberStyles.Any, CultureInfo.InvariantCulture, out double mainTemp);

                if (temperatureChartStartTime == null)
                {
                    temperatureChartStartTime = DateTime.Now;
                }

                double elapsedSeconds = (DateTime.Now - temperatureChartStartTime.Value).TotalSeconds;

                var s1 = chart3.Series["IoT1 Sıcaklık"];
                var s2 = chart3.Series["IoT2 Sıcaklık"];
                var sMain = chart3.Series["Sıcaklık"];

                if (ok1)
                {
                    s1.Points.AddXY(elapsedSeconds, temp1);

                    //if (s1.Points.Count > MaxChartPoints) s1.Points.RemoveAt(0);

                    while (s1.Points.Count > MaxChartPoints)
                    {
                        s1.Points.RemoveAt(0);
                    }

                    temperatureValues.Add(temp1);
                }
                if (ok2)
                {
                    s2.Points.AddXY(elapsedSeconds, temp2);
                    //if (s2.Points.Count > MaxChartPoints) s2.Points.RemoveAt(0);

                    while (s2.Points.Count > MaxChartPoints)
                    {
                        s2.Points.RemoveAt(0);
                    }

                    temperatureValues.Add(temp2);
                }
                if (okMain)
                {
                    sMain.Points.AddXY(elapsedSeconds, mainTemp);
                    //if (sMain.Points.Count > MaxChartPoints) sMain.Points.RemoveAt(0);

                    while (sMain.Points.Count > MaxChartPoints)
                    {
                        sMain.Points.RemoveAt(0);
                    }

                    temperatureValues.Add(mainTemp);
                }

                if (temperatureValues.Count > MaxChartPoints * 3)
                    temperatureValues.RemoveRange(0, temperatureValues.Count - MaxChartPoints * 3);

                if (temperatureValues.Count > 0)
                {
                    double min = temperatureValues.Min();
                    double max = temperatureValues.Max();
                    double range = max - min;

                    var area = chart3.ChartAreas[0];

                    if (range < 5)
                    {
                        double center = (min + max) / 2;
                        area.AxisY.Minimum = center - 2.5;
                        area.AxisY.Maximum = center + 2.5;
                    }
                    else
                    {
                        double margin = range * 0.1;
                        area.AxisY.Minimum = min - margin;
                        area.AxisY.Maximum = max + margin;
                    }

                    area.AxisX.Minimum = Math.Max(0, elapsedSeconds - 60);
                    area.AxisX.Maximum = elapsedSeconds;
                }

                label35.Text = ok1 ? $"IoT S1: {temp1:0.0} °C" : "IoT S1: N/A";
                label36.Text = ok2 ? $"IoT S2: {temp2:0.0} °C" : "IoT S2: N/A";
                label34.Text = okMain ? $"Sıcaklık: {mainTemp:0.0} °C" : "Sıcaklık: N/A";

                chart3.Invalidate();
            }
            catch (Exception ex)
            {
                HandleError("Sıcaklık grafiği güncelleme hatası: " + ex.Message);
            }
            finally
            {
                chart3.ResumeLayout();
            }
        }
        // Ortak yardımcı metodlar
        private void SetDoubleBuffered(Control control)
        {
            if (SystemInformation.TerminalServerSession) return;

            typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance)
                ?.SetValue(control, true, null);
        }

        private void HandleError(string message)
        {
            Debug.WriteLine(message);
            // İsteğe bağlı: statusLabel.Text = message;
        }

        
        private async void btnConnect_Click_1(object sender, EventArgs e)
        {
            await AnimateButtonColor(btnConnect); // Görsel geri bildirim (renk değişimi)
            //await AnimateButtonColor(btnConnect); // Görsel geri bildirim (renk değişimi)
            
            
            try
            {
                //uiUpdateTimer.Start();

                // 1. ÖN KONTROLLER (Input Validation)
                if (cmbSerialComPort.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir seri port seçin.", "Uyarı",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(_videoSavePath))
                {
                    MessageBox.Show("Lütfen önce video kayıt dosyası seçin!", "Uyarı",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(telemetrySavePath))
                {
                    MessageBox.Show("Lütfen önce telemetri kayıt dosyası seçin!", "Uyarı",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // SERİ PORT BAĞLANTISI
                string selectedPort = cmbSerialComPort.SelectedItem.ToString();
                if (!serialPort1.IsOpen)
                {
                    // Port adı geçerlilik kontrolü
                    if (!System.IO.Ports.SerialPort.GetPortNames().Contains(selectedPort))
                    {
                        MessageBox.Show("Geçersiz seri port seçildi!", "Hata",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    serialPort1.PortName = selectedPort;
                    serialPort1.Open();

                    if (!serialPort1.IsOpen)
                    {
                        throw new Exception("Seri port açılamadı!");
                    }
                }

                //// ✅ SERİ VERİ OKUMAYI BAŞLAT (BackgroundWorker)
                if (!serialWorker.IsBusy)
                {
                    serialWorker.RunWorkerAsync();
                }

                // VİDEO BAŞLAT
                if (comboBox_cam.SelectedIndex >= 0)
                {
                    StartVideo();
                    camera_statuspic.BackColor = Color.LimeGreen;
                }

                // DURUM GÜNCELLEME
                UpdateConnectionStatus(true);
                isGpsTrackingEnabled = true;

                // CSV YAZICIYI BAŞLAT
                if (telemetryCsvWriter != null)
                {
                    telemetryCsvWriter.Close();
                    telemetryCsvWriter.Dispose();
                    telemetryCsvWriter = null;
                }

                InitializeCsvWriter();

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Port erişim hatası: {ex.Message}\n\nPort başka bir uygulama tarafından kullanılıyor olabilir.", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopAllConnections();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"G/Ç Hatası: {ex.Message}\n\nPort bağlantısı kesildi.", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopAllConnections();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kritik bağlantı hatası: {ex.Message}", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopAllConnections();
            }
        }
        
        
        
        /*
        private async void btnConnect_Click_1(object sender, EventArgs e)
        {
            await AnimateButtonColor(btnConnect); // Görsel geri bildirim (renk değişimi)

            try
            {
                uiUpdateTimer.Start();

                // 1. ÖN KONTROLLER (Input Validation)
                if (cmbSerialComPort.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir seri port seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(_videoSavePath))
                {
                    MessageBox.Show("Lütfen önce video kayıt dosyası seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(telemetrySavePath))
                {
                    MessageBox.Show("Lütfen önce telemetri kayıt dosyası seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. SERİ PORT BAĞLANTISI
                string selectedPort = cmbSerialComPort.SelectedItem.ToString();

                // Eğer port açıksa kapat, yeniden başlatılacak
                if (serialPort1.IsOpen)
                {
                    serialPort1.DataReceived -= SerialPort1_DataReceived;
                    serialPort1.Close();
                }

                // Port adı geçerli mi?
                if (!System.IO.Ports.SerialPort.GetPortNames().Contains(selectedPort))
                {
                    MessageBox.Show("Geçersiz seri port seçildi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                serialPort1.PortName = selectedPort;
                serialPort1.Open();

                if (!serialPort1.IsOpen)
                {
                    throw new Exception("Seri port açılamadı!");
                }

                // Event handler yeniden bağlanmalı
                serialPort1.DataReceived -= SerialPort1_DataReceived; // Önce kaldır (çift bağlamayı önle)
                //serialPort1.DataReceived += SerialPort1_DataReceived;

                // 3. VİDEO BAŞLAT
                if (comboBox_cam.SelectedIndex >= 0)
                {
                    StartVideo();
                    camera_statuspic.BackColor = Color.LimeGreen;
                }

                // 4. CSV DOSYASINI BAŞLAT
                if (telemetryCsvWriter != null)
                {
                    telemetryCsvWriter.Close();
                    telemetryCsvWriter.Dispose();
                    telemetryCsvWriter = null;
                }

                InitializeCsvWriter();

                // 5. DURUM GÜNCELLE
                UpdateConnectionStatus(true);
                isGpsTrackingEnabled = true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Port erişim hatası: {ex.Message}\n\nPort başka bir uygulama tarafından kullanılıyor olabilir.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopAllConnections();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"G/Ç Hatası: {ex.Message}\n\nPort bağlantısı kesildi.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopAllConnections();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kritik bağlantı hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopAllConnections();
            }
        }
        */


        private bool isClosingConfirmed = false; // class seviyesinde tanımla
        /*  private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
          {

              if (isClosingConfirmed)
                  return;

              var result = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz?", "Kapat", MessageBoxButtons.YesNo);
              if (result == DialogResult.No)
              {
                  e.Cancel = true;
                  return;
              }

              e.Cancel = true;
              this.Enabled = false;

              try
              {
                  uiUpdateTimer.Stop();    
                  CloseCsvWriter();         

                  await Task.Run(() =>
                  {
                      StopAllConnections();
                      StopVideo();
                  });

                  isClosingConfirmed = true;
                  this.Close(); // Kapat
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Kapanırken hata oluştu: " + ex.Message);
                  this.Enabled = true;
              }
          }
        */

        /*
        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClosingConfirmed)
                return;

            e.Cancel = true;

            var result = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz?", "Kapat", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            this.Enabled = false;

            try
            {
                // UI timer durdur
                uiUpdateTimer?.Stop();

                // CSV yazıcı kapat
                CloseCsvWriter();

                // Stopwatch ile süre ölç
                var sw = Stopwatch.StartNew();

                await Task.Run(() =>
                {
                    StopAllConnections();
                    //StopVideo();
                    StopVideoAsync();
                });

                Console.WriteLine("Temizleme süresi: " + sw.ElapsedMilliseconds + " ms");

                isClosingConfirmed = true;

                Application.Exit(); // Temiz çıkış
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kapanırken hata oluştu: " + ex.Message);
                this.Enabled = true;
            }
        }
        */

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClosingConfirmed)
                return;

            e.Cancel = true;

            var result = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz?", "Kapat", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            this.Enabled = false;

            try
            {
                uiUpdateTimer?.Stop();      // Timer durdur

                CloseCsvWriter();           // CSV yazıcıyı kapat

                var sw = Stopwatch.StartNew();

                // Seri bağlantıları arka planda durdur
                await Task.Run(() => StopAllConnections());

                // Video bağlantısı async olduğu için beklenmeli
                await StopVideoAsync();

                Console.WriteLine("Temizleme süresi: " + sw.ElapsedMilliseconds + " ms");

                isClosingConfirmed = true;

                Application.Exit(); // Temiz çıkış
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kapanırken hata oluştu: " + ex.Message);
                this.Enabled = true;
            }
        }

        //ayır butonu
        private async void btnUnlock_Click_1(object sender, EventArgs e)
        {
            await AnimateButtonColor(btnUnlock); // Görsel geri bildirim (renk değişimi)

            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Seri port açık değil. Lütfen önce portu açın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                serialPort1.WriteLine("UNLOCK,0,0");
               // MessageBox.Show("Komut gönderildi: UNLOCK,0,0", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Komut gönderme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // kenetle buttonu
        private async void button1_Click(object sender, EventArgs e)
        {
            await AnimateButtonColor(button1); // Görsel geri bildirim (renk değişimi)

            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Seri port açık değil. Lütfen önce portu açın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                serialPort1.WriteLine("LOCK,0,0");
                //MessageBox.Show("Komut gönderildi: LOCK,0,0", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Komut gönderme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}