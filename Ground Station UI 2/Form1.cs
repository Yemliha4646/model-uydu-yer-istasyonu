using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        private string[] lastPorts = new string[0];

        string telemetryFilePath = "";  // Global değişken (Form1.cs içinde tanımla)
        string videoFilePath = ""; // Global alan (Form1.cs içinde en üstte)
        public Form1()
        {
            InitializeComponent();
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            solidGauge1.From = 0;
            solidGauge1.To = 50;
            angularGauge2.Value = 20;
            solidGauge1.Value = 25;
        }

        private void telemetriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Telemetri Kaydı İçin Dosya Seçin veya Oluşturun";
            saveFileDialog.Filter = "CSV dosyaları (*.csv)|*.csv";
            saveFileDialog.FileName = "telemetri.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                telemetryFilePath = saveFileDialog.FileName;

                // Eğer dosya yoksa başlıkla oluştur
                if (!System.IO.File.Exists(telemetryFilePath))
                {
                    System.IO.File.WriteAllText(telemetryFilePath, "Zaman,Sıcaklık,İvme\n");
                }

                // Dosya yolu label'a yazdırılır
                lbl_telemetry_url.Text = telemetryFilePath;
            }
            else
            {
                // Seçim yapılmadıysa label temizlenir
                lbl_telemetry_url.Text = "";
            }
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Video Kaydı İçin Dosya Seçin veya Oluşturun";
            saveFileDialog.Filter = "MP4 Video (*.mp4)|*.mp4|AVI Video (*.avi)|*.avi";
            saveFileDialog.FileName = "video_kaydi.mp4";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoFilePath = saveFileDialog.FileName;

                // Dosya yoksa oluştur (boş olarak — video yazımı sonra yapılacak)
                if (!System.IO.File.Exists(videoFilePath))
                {
                    using (var fs = System.IO.File.Create(videoFilePath)) { }
                }

                MessageBox.Show("Video dosya yolu seçildi:\n" + videoFilePath);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comPortToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void LoadAvailablePorts()
        {
            string[] currentPorts = SerialPort.GetPortNames();

            if (!currentPorts.SequenceEqual(lastPorts))
            {
                comPortToolStrip.Items.Clear();
                comPortToolStrip.Items.AddRange(currentPorts);

                if (currentPorts.Length > 0)
                {
                    comPortToolStrip.SelectedIndex = 0;
                }
                else
                {
                    comPortToolStrip.SelectedIndex = -1; // Seçimi temizle
                }

                lastPorts = currentPorts;
            }
        }

        private void timerComPort_Tick(object sender, EventArgs e)
        {
            LoadAvailablePorts();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txt_command.Focused)
            {
                txt_command.Focus();
                // İlk tuşu manuel olarak ekle
                txt_command.Text += e.KeyChar;

                // İmleci sona getir
                txt_command.SelectionStart = txt_command.Text.Length;
                txt_command.SelectionLength = 0;

                // Olay işlendiyse form’un işlememesini istiyorsan:
                e.Handled = true;
            }
        }
    }
}
