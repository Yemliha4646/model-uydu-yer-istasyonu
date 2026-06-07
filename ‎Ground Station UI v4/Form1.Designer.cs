namespace WinForm_AutoSize
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.PictureBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.comboBox_cam = new System.Windows.Forms.ComboBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.cmbSerialComPort = new System.Windows.Forms.ComboBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.panel28 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnSendData2 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbl_ready_to_fly = new System.Windows.Forms.Label();
            this.lbl_recovery = new System.Windows.Forms.Label();
            this.lbl_payload_landing = new System.Windows.Forms.Label();
            this.lbl_seperate = new System.Windows.Forms.Label();
            this.lbl_model_landing = new System.Windows.Forms.Label();
            this.lbl_ascent = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label33 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telemetriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.camera_statuspic = new System.Windows.Forms.PictureBox();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panel25 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_gps_status = new System.Windows.Forms.PictureBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_error_code_5 = new System.Windows.Forms.PictureBox();
            this.pic_error_code_4 = new System.Windows.Forms.PictureBox();
            this.pic_error_code_3 = new System.Windows.Forms.PictureBox();
            this.pic_error_code_2 = new System.Windows.Forms.PictureBox();
            this.pic_error_code_1 = new System.Windows.Forms.PictureBox();
            this.pic_error_code_0 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.angularGauge1 = new LiveCharts.WinForms.AngularGauge();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel30 = new System.Windows.Forms.Panel();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.glControl3D = new OpenTK.GLControl();
            this.panel26 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label48 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_packet_number = new System.Windows.Forms.TextBox();
            this.txt_satellite_status = new System.Windows.Forms.TextBox();
            this.txt_error_code = new System.Windows.Forms.TextBox();
            this.txt_prs1 = new System.Windows.Forms.TextBox();
            this.txt_prs2 = new System.Windows.Forms.TextBox();
            this.txt_alt1 = new System.Windows.Forms.TextBox();
            this.txt_alt2 = new System.Windows.Forms.TextBox();
            this.txt_alt_dif = new System.Windows.Forms.TextBox();
            this.txt_des_speed = new System.Windows.Forms.TextBox();
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.txt_battery = new System.Windows.Forms.TextBox();
            this.txt_latitude = new System.Windows.Forms.TextBox();
            this.txt_longitude = new System.Windows.Forms.TextBox();
            this.txt_gps_altitude = new System.Windows.Forms.TextBox();
            this.txt_pitch = new System.Windows.Forms.TextBox();
            this.txt_roll = new System.Windows.Forms.TextBox();
            this.txt_yaw = new System.Windows.Forms.TextBox();
            this.txt_rhrh = new System.Windows.Forms.TextBox();
            this.txt_IoT1 = new System.Windows.Forms.TextBox();
            this.txt_IoT2 = new System.Windows.Forms.TextBox();
            this.txt_team_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_send_time = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date_timer = new System.Windows.Forms.Timer(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).BeginInit();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camera_statuspic)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel25.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gps_status)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_0)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel26.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tableLayoutPanel13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 66);
            this.panel1.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel23);
            this.panel12.Controls.Add(this.panel21);
            this.panel12.Controls.Add(this.panel20);
            this.panel12.Controls.Add(this.panel19);
            this.panel12.Controls.Add(this.panel18);
            this.panel12.Controls.Add(this.panel17);
            this.panel12.Controls.Add(this.panel16);
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 34);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1924, 32);
            this.panel12.TabIndex = 1;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.btnDisconnect);
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(835, 0);
            this.panel23.Margin = new System.Windows.Forms.Padding(2);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(274, 32);
            this.panel23.TabIndex = 9;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Red;
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDisconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDisconnect.Location = new System.Drawing.Point(0, 0);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(219, 32);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Bağlantıyı Kes";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.lblStatus);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel24.Location = new System.Drawing.Point(219, 0);
            this.panel24.Margin = new System.Windows.Forms.Padding(2);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(55, 32);
            this.panel24.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.LimeGreen;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 32);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.TabStop = false;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnConnect);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel21.Location = new System.Drawing.Point(635, 0);
            this.panel21.Margin = new System.Windows.Forms.Padding(2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(200, 32);
            this.panel21.TabIndex = 8;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Blue;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConnect.Location = new System.Drawing.Point(0, 0);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(200, 32);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.comboBox_cam);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel20.Location = new System.Drawing.Point(435, 0);
            this.panel20.Margin = new System.Windows.Forms.Padding(2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(200, 32);
            this.panel20.TabIndex = 7;
            // 
            // comboBox_cam
            // 
            this.comboBox_cam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox_cam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_cam.FormattingEnabled = true;
            this.comboBox_cam.Location = new System.Drawing.Point(0, -1);
            this.comboBox_cam.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_cam.Name = "comboBox_cam";
            this.comboBox_cam.Size = new System.Drawing.Size(200, 33);
            this.comboBox_cam.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label26);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(326, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(109, 32);
            this.panel19.TabIndex = 6;
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(0, 0);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(109, 32);
            this.label26.TabIndex = 1;
            this.label26.Text = "Kamera:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.cmbSerialComPort);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel18.Location = new System.Drawing.Point(126, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(200, 32);
            this.panel18.TabIndex = 5;
            // 
            // cmbSerialComPort
            // 
            this.cmbSerialComPort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbSerialComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSerialComPort.FormattingEnabled = true;
            this.cmbSerialComPort.Location = new System.Drawing.Point(0, -1);
            this.cmbSerialComPort.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSerialComPort.Name = "cmbSerialComPort";
            this.cmbSerialComPort.Size = new System.Drawing.Size(200, 33);
            this.cmbSerialComPort.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label25);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(126, 32);
            this.panel17.TabIndex = 4;
            // 
            // label25
            // 
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(126, 32);
            this.label25.TabIndex = 0;
            this.label25.Text = "COM Port:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label4);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel16.Location = new System.Drawing.Point(1109, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(104, 32);
            this.panel16.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Komut:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel29);
            this.panel15.Controls.Add(this.panel28);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(1213, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(265, 32);
            this.panel15.TabIndex = 2;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.txtSendData);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel29.Location = new System.Drawing.Point(35, 0);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(230, 32);
            this.panel29.TabIndex = 1;
            // 
            // txtSendData
            // 
            this.txtSendData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSendData.Location = new System.Drawing.Point(0, 2);
            this.txtSendData.Margin = new System.Windows.Forms.Padding(2);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(230, 30);
            this.txtSendData.TabIndex = 1;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.checkBox1);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel28.Location = new System.Drawing.Point(0, 0);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(35, 32);
            this.panel28.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 32);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnSendData2);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(1478, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(200, 32);
            this.panel14.TabIndex = 1;
            // 
            // btnSendData2
            // 
            this.btnSendData2.BackColor = System.Drawing.Color.Blue;
            this.btnSendData2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSendData2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendData2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSendData2.Location = new System.Drawing.Point(0, 0);
            this.btnSendData2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendData2.Name = "btnSendData2";
            this.btnSendData2.Size = new System.Drawing.Size(200, 32);
            this.btnSendData2.TabIndex = 0;
            this.btnSendData2.Text = "Gönder";
            this.btnSendData2.UseVisualStyleBackColor = false;
            this.btnSendData2.Click += new System.EventHandler(this.btnSendData2_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label_date);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(1678, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(246, 32);
            this.panel13.TabIndex = 0;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_date.Location = new System.Drawing.Point(0, 7);
            this.label_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(223, 25);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "11.19.20 - 08.05.2025";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lbl_ready_to_fly);
            this.panel11.Controls.Add(this.lbl_recovery);
            this.panel11.Controls.Add(this.lbl_payload_landing);
            this.panel11.Controls.Add(this.lbl_seperate);
            this.panel11.Controls.Add(this.lbl_model_landing);
            this.panel11.Controls.Add(this.lbl_ascent);
            this.panel11.Controls.Add(this.progressBar1);
            this.panel11.Controls.Add(this.label33);
            this.panel11.Controls.Add(this.panel22);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1924, 34);
            this.panel11.TabIndex = 0;
            // 
            // lbl_ready_to_fly
            // 
            this.lbl_ready_to_fly.AutoSize = true;
            this.lbl_ready_to_fly.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ready_to_fly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ready_to_fly.Location = new System.Drawing.Point(219, 6);
            this.lbl_ready_to_fly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ready_to_fly.Name = "lbl_ready_to_fly";
            this.lbl_ready_to_fly.Size = new System.Drawing.Size(107, 22);
            this.lbl_ready_to_fly.TabIndex = 12;
            this.lbl_ready_to_fly.Text = "Uçuşa Hazır";
            // 
            // lbl_recovery
            // 
            this.lbl_recovery.AutoSize = true;
            this.lbl_recovery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_recovery.Location = new System.Drawing.Point(1839, 6);
            this.lbl_recovery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_recovery.Name = "lbl_recovery";
            this.lbl_recovery.Size = new System.Drawing.Size(84, 22);
            this.lbl_recovery.TabIndex = 17;
            this.lbl_recovery.Text = "Kurtarma";
            // 
            // lbl_payload_landing
            // 
            this.lbl_payload_landing.AutoSize = true;
            this.lbl_payload_landing.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_payload_landing.Location = new System.Drawing.Point(1496, 6);
            this.lbl_payload_landing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_payload_landing.Name = "lbl_payload_landing";
            this.lbl_payload_landing.Size = new System.Drawing.Size(141, 22);
            this.lbl_payload_landing.TabIndex = 16;
            this.lbl_payload_landing.Text = "Görev Yükü İniş";
            // 
            // lbl_seperate
            // 
            this.lbl_seperate.AutoSize = true;
            this.lbl_seperate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_seperate.Location = new System.Drawing.Point(1236, 6);
            this.lbl_seperate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_seperate.Name = "lbl_seperate";
            this.lbl_seperate.Size = new System.Drawing.Size(73, 22);
            this.lbl_seperate.TabIndex = 15;
            this.lbl_seperate.Text = "Ayrılma";
            // 
            // lbl_model_landing
            // 
            this.lbl_model_landing.AutoSize = true;
            this.lbl_model_landing.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_model_landing.Location = new System.Drawing.Point(842, 6);
            this.lbl_model_landing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_model_landing.Name = "lbl_model_landing";
            this.lbl_model_landing.Size = new System.Drawing.Size(142, 22);
            this.lbl_model_landing.TabIndex = 14;
            this.lbl_model_landing.Text = "Model Uydu İniş";
            // 
            // lbl_ascent
            // 
            this.lbl_ascent.AutoSize = true;
            this.lbl_ascent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ascent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ascent.Location = new System.Drawing.Point(564, 6);
            this.lbl_ascent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ascent.Name = "lbl_ascent";
            this.lbl_ascent.Size = new System.Drawing.Size(89, 22);
            this.lbl_ascent.TabIndex = 13;
            this.lbl_ascent.Text = "Yükselme";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1924, 34);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Value = 100;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(432, 14);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 16);
            this.label33.TabIndex = 10;
            // 
            // panel22
            // 
            this.panel22.Location = new System.Drawing.Point(844, 32);
            this.panel22.Margin = new System.Windows.Forms.Padding(2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(200, 28);
            this.panel22.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telemetriToolStripMenuItem,
            this.videoToolStripMenuItem});
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.kayıtToolStripMenuItem.Text = "Kayıt";
            // 
            // telemetriToolStripMenuItem
            // 
            this.telemetriToolStripMenuItem.Name = "telemetriToolStripMenuItem";
            this.telemetriToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.telemetriToolStripMenuItem.Text = "Telemetri";
            this.telemetriToolStripMenuItem.Click += new System.EventHandler(this.telemetriToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.videoToolStripMenuItem.Text = "Video";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 211);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 634);
            this.panel3.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 534);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.camera_statuspic);
            this.groupBox2.Controls.Add(this.videoSourcePlayer);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(626, 263);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video";
            // 
            // camera_statuspic
            // 
            this.camera_statuspic.Location = new System.Drawing.Point(555, 31);
            this.camera_statuspic.Margin = new System.Windows.Forms.Padding(2);
            this.camera_statuspic.Name = "camera_statuspic";
            this.camera_statuspic.Size = new System.Drawing.Size(59, 21);
            this.camera_statuspic.TabIndex = 1;
            this.camera_statuspic.TabStop = false;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer.Location = new System.Drawing.Point(2, 22);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(622, 239);
            this.videoSourcePlayer.TabIndex = 2;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel27);
            this.groupBox3.Controls.Add(this.panel25);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(2, 269);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(626, 263);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Harita";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.gMapControl1);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(2, 22);
            this.panel27.Margin = new System.Windows.Forms.Padding(2);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(622, 210);
            this.panel27.TabIndex = 1;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(622, 210);
            this.gMapControl1.TabIndex = 2;
            this.gMapControl1.Zoom = 0D;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.tableLayoutPanel5);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel25.Location = new System.Drawing.Point(2, 232);
            this.panel25.Margin = new System.Windows.Forms.Padding(2);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(622, 29);
            this.panel25.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBox_gps_status, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.label41, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label45, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label44, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label43, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label40, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label42, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(618, 29);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // pictureBox_gps_status
            // 
            this.pictureBox_gps_status.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_gps_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_gps_status.Location = new System.Drawing.Point(507, 3);
            this.pictureBox_gps_status.Name = "pictureBox_gps_status";
            this.pictureBox_gps_status.Size = new System.Drawing.Size(108, 23);
            this.pictureBox_gps_status.TabIndex = 2;
            this.pictureBox_gps_status.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Location = new System.Drawing.Point(87, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(78, 29);
            this.label41.TabIndex = 6;
            this.label41.Text = "nan";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.Location = new System.Drawing.Point(423, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(78, 29);
            this.label45.TabIndex = 5;
            this.label45.Text = "nan";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Location = new System.Drawing.Point(339, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(78, 29);
            this.label44.TabIndex = 4;
            this.label44.Text = "Yükseklik:";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Location = new System.Drawing.Point(255, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(78, 29);
            this.label43.TabIndex = 3;
            this.label43.Text = "nan";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Location = new System.Drawing.Point(2, 0);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(80, 29);
            this.label40.TabIndex = 0;
            this.label40.Text = "Enlem:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label42.Location = new System.Drawing.Point(171, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(78, 29);
            this.label42.TabIndex = 2;
            this.label42.Text = "Boylam:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel19, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel18, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel17, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel16, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel15, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pic_error_code_5, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.pic_error_code_4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.pic_error_code_3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pic_error_code_2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pic_error_code_1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pic_error_code_0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel14, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pic_error_code_5
            // 
            this.pic_error_code_5.BackColor = System.Drawing.Color.LightGray;
            this.pic_error_code_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_error_code_5.Location = new System.Drawing.Point(523, 52);
            this.pic_error_code_5.Margin = new System.Windows.Forms.Padding(2);
            this.pic_error_code_5.Name = "pic_error_code_5";
            this.pic_error_code_5.Size = new System.Drawing.Size(105, 46);
            this.pic_error_code_5.TabIndex = 11;
            this.pic_error_code_5.TabStop = false;
            // 
            // pic_error_code_4
            // 
            this.pic_error_code_4.BackColor = System.Drawing.Color.LightGray;
            this.pic_error_code_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_error_code_4.Location = new System.Drawing.Point(419, 52);
            this.pic_error_code_4.Margin = new System.Windows.Forms.Padding(2);
            this.pic_error_code_4.Name = "pic_error_code_4";
            this.pic_error_code_4.Size = new System.Drawing.Size(100, 46);
            this.pic_error_code_4.TabIndex = 10;
            this.pic_error_code_4.TabStop = false;
            // 
            // pic_error_code_3
            // 
            this.pic_error_code_3.BackColor = System.Drawing.Color.LightGray;
            this.pic_error_code_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_error_code_3.Location = new System.Drawing.Point(315, 52);
            this.pic_error_code_3.Margin = new System.Windows.Forms.Padding(2);
            this.pic_error_code_3.Name = "pic_error_code_3";
            this.pic_error_code_3.Size = new System.Drawing.Size(100, 46);
            this.pic_error_code_3.TabIndex = 9;
            this.pic_error_code_3.TabStop = false;
            // 
            // pic_error_code_2
            // 
            this.pic_error_code_2.BackColor = System.Drawing.Color.LightGray;
            this.pic_error_code_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_error_code_2.Location = new System.Drawing.Point(211, 52);
            this.pic_error_code_2.Margin = new System.Windows.Forms.Padding(2);
            this.pic_error_code_2.Name = "pic_error_code_2";
            this.pic_error_code_2.Size = new System.Drawing.Size(100, 46);
            this.pic_error_code_2.TabIndex = 8;
            this.pic_error_code_2.TabStop = false;
            // 
            // pic_error_code_1
            // 
            this.pic_error_code_1.BackColor = System.Drawing.Color.LightGray;
            this.pic_error_code_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_error_code_1.Location = new System.Drawing.Point(107, 52);
            this.pic_error_code_1.Margin = new System.Windows.Forms.Padding(2);
            this.pic_error_code_1.Name = "pic_error_code_1";
            this.pic_error_code_1.Size = new System.Drawing.Size(100, 46);
            this.pic_error_code_1.TabIndex = 7;
            this.pic_error_code_1.TabStop = false;
            // 
            // pic_error_code_0
            // 
            this.pic_error_code_0.BackColor = System.Drawing.Color.LightGray;
            this.pic_error_code_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_error_code_0.Location = new System.Drawing.Point(2, 52);
            this.pic_error_code_0.Margin = new System.Windows.Forms.Padding(2);
            this.pic_error_code_0.Name = "pic_error_code_0";
            this.pic_error_code_0.Size = new System.Drawing.Size(101, 46);
            this.pic_error_code_0.TabIndex = 6;
            this.pic_error_code_0.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(630, 211);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 634);
            this.panel4.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 105);
            this.panel7.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.groupBox5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(278, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(270, 105);
            this.panel10.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel11);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(270, 105);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hız (m/s)";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.angularGauge1, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(2, 22);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.6442F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.35581F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(266, 81);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // angularGauge1
            // 
            this.angularGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angularGauge1.Location = new System.Drawing.Point(2, 2);
            this.angularGauge1.Margin = new System.Windows.Forms.Padding(2);
            this.angularGauge1.Name = "angularGauge1";
            this.angularGauge1.Size = new System.Drawing.Size(262, 64);
            this.angularGauge1.TabIndex = 2;
            this.angularGauge1.Text = "angularGauge1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(2, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.listBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(278, 105);
            this.panel9.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 105);
            this.listBox1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.groupBox6);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 105);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(548, 165);
            this.panel6.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.solidGauge1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(278, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(270, 165);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pil Gerilimi (V)";
            // 
            // solidGauge1
            // 
            this.solidGauge1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.solidGauge1.Location = new System.Drawing.Point(2, 31);
            this.solidGauge1.Margin = new System.Windows.Forms.Padding(2);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(266, 132);
            this.solidGauge1.TabIndex = 2;
            this.solidGauge1.Text = "solidGauge1";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel31);
            this.panel8.Controls.Add(this.panel30);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(278, 165);
            this.panel8.TabIndex = 0;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.button1);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel31.Location = new System.Drawing.Point(0, 135);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(278, 30);
            this.panel31.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kenetle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.btnUnlock);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel30.Location = new System.Drawing.Point(0, 0);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(278, 135);
            this.panel30.TabIndex = 0;
            // 
            // btnUnlock
            // 
            this.btnUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUnlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnlock.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnlock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUnlock.Location = new System.Drawing.Point(0, 0);
            this.btnUnlock.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(278, 135);
            this.btnUnlock.TabIndex = 1;
            this.btnUnlock.Text = "Ayır";
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 270);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(548, 364);
            this.panel5.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.glControl3D);
            this.groupBox4.Controls.Add(this.panel26);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(548, 364);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gyro";
            // 
            // glControl3D
            // 
            this.glControl3D.BackColor = System.Drawing.Color.Black;
            this.glControl3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl3D.Location = new System.Drawing.Point(2, 22);
            this.glControl3D.Margin = new System.Windows.Forms.Padding(5);
            this.glControl3D.Name = "glControl3D";
            this.glControl3D.Size = new System.Drawing.Size(544, 308);
            this.glControl3D.TabIndex = 2;
            this.glControl3D.VSync = false;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.tableLayoutPanel6);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel26.Location = new System.Drawing.Point(2, 330);
            this.panel26.Margin = new System.Windows.Forms.Padding(2);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(544, 32);
            this.panel26.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.Controls.Add(this.label48, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label51, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.label50, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.label49, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.label47, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label46, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(544, 32);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label48.Location = new System.Drawing.Point(182, 0);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(86, 32);
            this.label48.TabIndex = 11;
            this.label48.Text = "Roll:";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label51.Location = new System.Drawing.Point(452, 0);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(90, 32);
            this.label51.TabIndex = 10;
            this.label51.Text = "nan";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label50.Location = new System.Drawing.Point(362, 0);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(86, 32);
            this.label50.TabIndex = 9;
            this.label50.Text = "Yaw:";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.Location = new System.Drawing.Point(272, 0);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(86, 32);
            this.label49.TabIndex = 8;
            this.label49.Text = "nan";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label47.Location = new System.Drawing.Point(92, 0);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(86, 32);
            this.label47.TabIndex = 6;
            this.label47.Text = "nan";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.Location = new System.Drawing.Point(2, 0);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(86, 32);
            this.label46.TabIndex = 5;
            this.label46.Text = "Pitch:";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel12, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1178, 211);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(746, 634);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.39394F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.60606F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(742, 207);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea19.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea19);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend19.Name = "Legend1";
            this.chart1.Legends.Add(legend19);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.chart1.Series.Add(series19);
            this.chart1.Size = new System.Drawing.Size(736, 179);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.label55, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.label54, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.label53, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label52, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(2, 187);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(738, 18);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label55.Location = new System.Drawing.Point(554, 0);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(182, 18);
            this.label55.TabIndex = 14;
            this.label55.Text = "nan";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label54.Location = new System.Drawing.Point(370, 0);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(180, 18);
            this.label54.TabIndex = 13;
            this.label54.Text = "Basınç 2:";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label53.Location = new System.Drawing.Point(186, 0);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(180, 18);
            this.label53.TabIndex = 12;
            this.label53.Text = "nan";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label52.Location = new System.Drawing.Point(2, 0);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(180, 18);
            this.label52.TabIndex = 11;
            this.label52.Text = "Basınç 1:";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.chart2, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(2, 213);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.39394F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.60606F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(742, 207);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // chart2
            // 
            chartArea20.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea20);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend20.Name = "Legend1";
            this.chart2.Legends.Add(legend20);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            this.chart2.Series.Add(series20);
            this.chart2.Size = new System.Drawing.Size(736, 179);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 6;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.Controls.Add(this.label61, 5, 0);
            this.tableLayoutPanel10.Controls.Add(this.label60, 4, 0);
            this.tableLayoutPanel10.Controls.Add(this.label59, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.label58, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.label57, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label56, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(2, 187);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(738, 18);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label61.Location = new System.Drawing.Point(612, 0);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(124, 18);
            this.label61.TabIndex = 17;
            this.label61.Text = "nan";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label60.Location = new System.Drawing.Point(490, 0);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(118, 18);
            this.label60.TabIndex = 16;
            this.label60.Text = "İrtifa Farkı:";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label59.Location = new System.Drawing.Point(368, 0);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(118, 18);
            this.label59.TabIndex = 15;
            this.label59.Text = "nan";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label58.Location = new System.Drawing.Point(246, 0);
            this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(118, 18);
            this.label58.TabIndex = 14;
            this.label58.Text = "Yükseklik 2:";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label57.Location = new System.Drawing.Point(124, 0);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(118, 18);
            this.label57.TabIndex = 13;
            this.label57.Text = "nan";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label56.Location = new System.Drawing.Point(2, 0);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(118, 18);
            this.label56.TabIndex = 12;
            this.label56.Text = "Yükseklik 1:";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.chart3, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(2, 424);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.84071F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.15929F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(742, 208);
            this.tableLayoutPanel12.TabIndex = 5;
            // 
            // chart3
            // 
            chartArea21.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea21);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend21.Name = "Legend1";
            this.chart3.Legends.Add(legend21);
            this.chart3.Location = new System.Drawing.Point(3, 3);
            this.chart3.Name = "chart3";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Series1";
            this.chart3.Series.Add(series21);
            this.chart3.Size = new System.Drawing.Size(736, 172);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart3";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.Controls.Add(this.label36, 2, 0);
            this.tableLayoutPanel13.Controls.Add(this.label35, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.label34, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(2, 180);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(738, 26);
            this.tableLayoutPanel13.TabIndex = 4;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(494, 0);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(242, 26);
            this.label36.TabIndex = 12;
            this.label36.Text = "IoT S2 Sıcaklık:  nan";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(248, 0);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(242, 26);
            this.label35.TabIndex = 11;
            this.label35.Text = "IoT S1 Sıcaklık:  nan";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(2, 0);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(242, 26);
            this.label34.TabIndex = 10;
            this.label34.Text = "Sıcaklık:  nan";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 118);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1924, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telemetri Paketi";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 22;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.752634F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.917006F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.439275F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.304055F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.603646F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.760326F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.648181F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.700408F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.133606F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.872471F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.073687F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.595954F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.284303F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.274902F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.431582F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.909316F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.553223F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.220966F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.86478F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.553223F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.553223F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.553223F));
            this.tableLayoutPanel4.Controls.Add(this.label24, 21, 0);
            this.tableLayoutPanel4.Controls.Add(this.label23, 20, 0);
            this.tableLayoutPanel4.Controls.Add(this.label22, 19, 0);
            this.tableLayoutPanel4.Controls.Add(this.label21, 18, 0);
            this.tableLayoutPanel4.Controls.Add(this.label20, 17, 0);
            this.tableLayoutPanel4.Controls.Add(this.label19, 16, 0);
            this.tableLayoutPanel4.Controls.Add(this.label18, 15, 0);
            this.tableLayoutPanel4.Controls.Add(this.label17, 14, 0);
            this.tableLayoutPanel4.Controls.Add(this.label16, 13, 0);
            this.tableLayoutPanel4.Controls.Add(this.label15, 12, 0);
            this.tableLayoutPanel4.Controls.Add(this.label14, 11, 0);
            this.tableLayoutPanel4.Controls.Add(this.label13, 10, 0);
            this.tableLayoutPanel4.Controls.Add(this.label12, 9, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 8, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_packet_number, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_satellite_status, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_error_code, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_prs1, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_prs2, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_alt1, 6, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_alt2, 7, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_alt_dif, 8, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_des_speed, 9, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_temp, 10, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_battery, 11, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_latitude, 12, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_longitude, 13, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_gps_altitude, 14, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_pitch, 15, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_roll, 16, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_yaw, 17, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_rhrh, 18, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_IoT1, 19, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_IoT2, 20, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_team_number, 21, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_send_time, 3, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 22);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.80851F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.19149F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1918, 95);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(1828, 24);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 20);
            this.label24.TabIndex = 43;
            this.label24.Text = "Takım No";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(1741, 24);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 20);
            this.label23.TabIndex = 42;
            this.label23.Text = "IoT S2";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(1654, 24);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 20);
            this.label22.TabIndex = 41;
            this.label22.Text = "IoT S1";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(1580, 24);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 20);
            this.label21.TabIndex = 40;
            this.label21.Text = "RHRH";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(1500, 24);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 20);
            this.label20.TabIndex = 39;
            this.label20.Text = "Yaw";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(1413, 24);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 20);
            this.label19.TabIndex = 38;
            this.label19.Text = "Roll";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(1319, 24);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "Pitch";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(1215, 24);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "Yükseklik";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(1114, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Boylam";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(1013, 24);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Enlem";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(925, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 40);
            this.label14.TabIndex = 33;
            this.label14.Text = "Pil Gerilimi";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(847, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Sıcaklık";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(792, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 40);
            this.label12.TabIndex = 31;
            this.label12.Text = "İniş Hızı";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(732, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 40);
            this.label11.TabIndex = 30;
            this.label11.Text = "İrtifa Farkı";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(642, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 40);
            this.label10.TabIndex = 29;
            this.label10.Text = "Yükseklik 2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(553, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 40);
            this.label9.TabIndex = 28;
            this.label9.Text = "Yükseklik 1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(481, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 40);
            this.label8.TabIndex = 27;
            this.label8.Text = "Basınç 2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(412, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 40);
            this.label7.TabIndex = 26;
            this.label7.Text = "Basınç 1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(253, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Zaman";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_packet_number
            // 
            this.txt_packet_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_packet_number.Enabled = false;
            this.txt_packet_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_packet_number.Location = new System.Drawing.Point(2, 46);
            this.txt_packet_number.Margin = new System.Windows.Forms.Padding(2);
            this.txt_packet_number.Name = "txt_packet_number";
            this.txt_packet_number.Size = new System.Drawing.Size(87, 34);
            this.txt_packet_number.TabIndex = 0;
            this.txt_packet_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_satellite_status
            // 
            this.txt_satellite_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_satellite_status.Enabled = false;
            this.txt_satellite_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_satellite_status.Location = new System.Drawing.Point(93, 46);
            this.txt_satellite_status.Margin = new System.Windows.Forms.Padding(2);
            this.txt_satellite_status.Name = "txt_satellite_status";
            this.txt_satellite_status.Size = new System.Drawing.Size(71, 34);
            this.txt_satellite_status.TabIndex = 1;
            this.txt_satellite_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_error_code
            // 
            this.txt_error_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_error_code.Enabled = false;
            this.txt_error_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_error_code.Location = new System.Drawing.Point(168, 46);
            this.txt_error_code.Margin = new System.Windows.Forms.Padding(2);
            this.txt_error_code.Name = "txt_error_code";
            this.txt_error_code.Size = new System.Drawing.Size(81, 34);
            this.txt_error_code.TabIndex = 2;
            this.txt_error_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_prs1
            // 
            this.txt_prs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_prs1.Enabled = false;
            this.txt_prs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_prs1.Location = new System.Drawing.Point(412, 46);
            this.txt_prs1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_prs1.Name = "txt_prs1";
            this.txt_prs1.Size = new System.Drawing.Size(65, 34);
            this.txt_prs1.TabIndex = 4;
            this.txt_prs1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_prs2
            // 
            this.txt_prs2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_prs2.Enabled = false;
            this.txt_prs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_prs2.Location = new System.Drawing.Point(481, 46);
            this.txt_prs2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_prs2.Name = "txt_prs2";
            this.txt_prs2.Size = new System.Drawing.Size(68, 34);
            this.txt_prs2.TabIndex = 5;
            this.txt_prs2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_alt1
            // 
            this.txt_alt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_alt1.Enabled = false;
            this.txt_alt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_alt1.Location = new System.Drawing.Point(553, 46);
            this.txt_alt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_alt1.Name = "txt_alt1";
            this.txt_alt1.Size = new System.Drawing.Size(85, 34);
            this.txt_alt1.TabIndex = 6;
            this.txt_alt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_alt2
            // 
            this.txt_alt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_alt2.Enabled = false;
            this.txt_alt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_alt2.Location = new System.Drawing.Point(642, 46);
            this.txt_alt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_alt2.Name = "txt_alt2";
            this.txt_alt2.Size = new System.Drawing.Size(86, 34);
            this.txt_alt2.TabIndex = 7;
            this.txt_alt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_alt_dif
            // 
            this.txt_alt_dif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_alt_dif.Enabled = false;
            this.txt_alt_dif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_alt_dif.Location = new System.Drawing.Point(732, 46);
            this.txt_alt_dif.Margin = new System.Windows.Forms.Padding(2);
            this.txt_alt_dif.Name = "txt_alt_dif";
            this.txt_alt_dif.Size = new System.Drawing.Size(56, 34);
            this.txt_alt_dif.TabIndex = 8;
            this.txt_alt_dif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_des_speed
            // 
            this.txt_des_speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_des_speed.Enabled = false;
            this.txt_des_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_des_speed.Location = new System.Drawing.Point(792, 46);
            this.txt_des_speed.Margin = new System.Windows.Forms.Padding(2);
            this.txt_des_speed.Name = "txt_des_speed";
            this.txt_des_speed.Size = new System.Drawing.Size(51, 34);
            this.txt_des_speed.TabIndex = 9;
            this.txt_des_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_temp
            // 
            this.txt_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_temp.Enabled = false;
            this.txt_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_temp.Location = new System.Drawing.Point(847, 46);
            this.txt_temp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.Size = new System.Drawing.Size(74, 34);
            this.txt_temp.TabIndex = 10;
            this.txt_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_battery
            // 
            this.txt_battery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_battery.Enabled = false;
            this.txt_battery.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_battery.Location = new System.Drawing.Point(925, 46);
            this.txt_battery.Margin = new System.Windows.Forms.Padding(2);
            this.txt_battery.Name = "txt_battery";
            this.txt_battery.Size = new System.Drawing.Size(84, 34);
            this.txt_battery.TabIndex = 11;
            this.txt_battery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_latitude
            // 
            this.txt_latitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_latitude.Enabled = false;
            this.txt_latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_latitude.Location = new System.Drawing.Point(1013, 46);
            this.txt_latitude.Margin = new System.Windows.Forms.Padding(2);
            this.txt_latitude.Name = "txt_latitude";
            this.txt_latitude.Size = new System.Drawing.Size(97, 30);
            this.txt_latitude.TabIndex = 16;
            this.txt_latitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_longitude
            // 
            this.txt_longitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_longitude.Enabled = false;
            this.txt_longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_longitude.Location = new System.Drawing.Point(1114, 46);
            this.txt_longitude.Margin = new System.Windows.Forms.Padding(2);
            this.txt_longitude.Name = "txt_longitude";
            this.txt_longitude.Size = new System.Drawing.Size(97, 30);
            this.txt_longitude.TabIndex = 15;
            this.txt_longitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_gps_altitude
            // 
            this.txt_gps_altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_gps_altitude.Enabled = false;
            this.txt_gps_altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_gps_altitude.Location = new System.Drawing.Point(1215, 46);
            this.txt_gps_altitude.Margin = new System.Windows.Forms.Padding(2);
            this.txt_gps_altitude.Name = "txt_gps_altitude";
            this.txt_gps_altitude.Size = new System.Drawing.Size(100, 34);
            this.txt_gps_altitude.TabIndex = 14;
            this.txt_gps_altitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_pitch
            // 
            this.txt_pitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pitch.Enabled = false;
            this.txt_pitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_pitch.Location = new System.Drawing.Point(1319, 46);
            this.txt_pitch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pitch.Name = "txt_pitch";
            this.txt_pitch.Size = new System.Drawing.Size(90, 34);
            this.txt_pitch.TabIndex = 13;
            this.txt_pitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_roll
            // 
            this.txt_roll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_roll.Enabled = false;
            this.txt_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_roll.Location = new System.Drawing.Point(1413, 46);
            this.txt_roll.Margin = new System.Windows.Forms.Padding(2);
            this.txt_roll.Name = "txt_roll";
            this.txt_roll.Size = new System.Drawing.Size(83, 34);
            this.txt_roll.TabIndex = 12;
            this.txt_roll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_yaw
            // 
            this.txt_yaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_yaw.Enabled = false;
            this.txt_yaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yaw.Location = new System.Drawing.Point(1500, 46);
            this.txt_yaw.Margin = new System.Windows.Forms.Padding(2);
            this.txt_yaw.Name = "txt_yaw";
            this.txt_yaw.Size = new System.Drawing.Size(76, 34);
            this.txt_yaw.TabIndex = 17;
            this.txt_yaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_rhrh
            // 
            this.txt_rhrh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_rhrh.Enabled = false;
            this.txt_rhrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rhrh.Location = new System.Drawing.Point(1580, 46);
            this.txt_rhrh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rhrh.Name = "txt_rhrh";
            this.txt_rhrh.Size = new System.Drawing.Size(70, 34);
            this.txt_rhrh.TabIndex = 18;
            this.txt_rhrh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_IoT1
            // 
            this.txt_IoT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_IoT1.Enabled = false;
            this.txt_IoT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_IoT1.Location = new System.Drawing.Point(1654, 46);
            this.txt_IoT1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IoT1.Name = "txt_IoT1";
            this.txt_IoT1.Size = new System.Drawing.Size(83, 34);
            this.txt_IoT1.TabIndex = 19;
            this.txt_IoT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_IoT2
            // 
            this.txt_IoT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_IoT2.Enabled = false;
            this.txt_IoT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_IoT2.Location = new System.Drawing.Point(1741, 46);
            this.txt_IoT2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IoT2.Name = "txt_IoT2";
            this.txt_IoT2.Size = new System.Drawing.Size(83, 34);
            this.txt_IoT2.TabIndex = 20;
            this.txt_IoT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_team_number
            // 
            this.txt_team_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_team_number.Enabled = false;
            this.txt_team_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_team_number.Location = new System.Drawing.Point(1828, 46);
            this.txt_team_number.Margin = new System.Windows.Forms.Padding(2);
            this.txt_team_number.Name = "txt_team_number";
            this.txt_team_number.Size = new System.Drawing.Size(88, 34);
            this.txt_team_number.TabIndex = 21;
            this.txt_team_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Paket Numarası";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 40);
            this.label2.TabIndex = 23;
            this.label2.Text = "Uydu Statüsü";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(168, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 40);
            this.label3.TabIndex = 24;
            this.label3.Text = "Hata Kodu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_send_time
            // 
            this.txt_send_time.Enabled = false;
            this.txt_send_time.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_send_time.ForeColor = System.Drawing.Color.Black;
            this.txt_send_time.Location = new System.Drawing.Point(253, 46);
            this.txt_send_time.Margin = new System.Windows.Forms.Padding(2);
            this.txt_send_time.Multiline = true;
            this.txt_send_time.Name = "txt_send_time";
            this.txt_send_time.Size = new System.Drawing.Size(153, 30);
            this.txt_send_time.TabIndex = 44;
            this.txt_send_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.label37, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.label27, 0, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(99, 44);
            this.tableLayoutPanel14.TabIndex = 12;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.label38, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(108, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(98, 44);
            this.tableLayoutPanel15.TabIndex = 13;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Controls.Add(this.label39, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(212, 3);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(98, 44);
            this.tableLayoutPanel16.TabIndex = 14;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Controls.Add(this.label62, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(316, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(98, 44);
            this.tableLayoutPanel17.TabIndex = 15;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Controls.Add(this.label63, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(420, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 2;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(98, 44);
            this.tableLayoutPanel18.TabIndex = 16;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 1;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Controls.Add(this.label64, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.label32, 0, 0);
            this.tableLayoutPanel19.Location = new System.Drawing.Point(524, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 2;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(99, 44);
            this.tableLayoutPanel19.TabIndex = 17;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 22);
            this.label27.TabIndex = 0;
            this.label27.Text = "1";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(3, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 22);
            this.label28.TabIndex = 1;
            this.label28.Text = "2";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(3, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(92, 22);
            this.label29.TabIndex = 1;
            this.label29.Text = "3";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(3, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(92, 22);
            this.label30.TabIndex = 1;
            this.label30.Text = "4";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(92, 22);
            this.label31.TabIndex = 1;
            this.label31.Text = "5";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(3, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(93, 22);
            this.label32.TabIndex = 1;
            this.label32.Text = "6";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.Location = new System.Drawing.Point(3, 22);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(93, 22);
            this.label37.TabIndex = 1;
            this.label37.Text = "model uydu hız\r\n(12-14 m/s)";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(3, 22);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(92, 22);
            this.label38.TabIndex = 2;
            this.label38.Text = "görev yükü hız\r\n(6-8 m/s)";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.Location = new System.Drawing.Point(3, 22);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(92, 22);
            this.label39.TabIndex = 2;
            this.label39.Text = "taşıyıcı basınç";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label62.Location = new System.Drawing.Point(3, 22);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(92, 22);
            this.label62.TabIndex = 2;
            this.label62.Text = "konum verisi";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label63.Location = new System.Drawing.Point(3, 22);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(92, 22);
            this.label63.TabIndex = 2;
            this.label63.Text = "ayrılma";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label64.Location = new System.Drawing.Point(3, 22);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(93, 22);
            this.label64.TabIndex = 2;
            this.label64.Text = "multispektral\r\nfiltre";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1924, 845);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.camera_statuspic)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gps_status)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error_code_0)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telemetriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnSendData2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.ComboBox cmbSerialComPort;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.ComboBox comboBox_cam;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pic_error_code_5;
        private System.Windows.Forms.PictureBox pic_error_code_4;
        private System.Windows.Forms.PictureBox pic_error_code_3;
        private System.Windows.Forms.PictureBox pic_error_code_2;
        private System.Windows.Forms.PictureBox pic_error_code_1;
        private System.Windows.Forms.PictureBox pic_error_code_0;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.PictureBox lblStatus;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_packet_number;
        private System.Windows.Forms.TextBox txt_satellite_status;
        private System.Windows.Forms.TextBox txt_error_code;
        private System.Windows.Forms.TextBox txt_prs1;
        private System.Windows.Forms.TextBox txt_prs2;
        private System.Windows.Forms.TextBox txt_alt1;
        private System.Windows.Forms.TextBox txt_alt2;
        private System.Windows.Forms.TextBox txt_alt_dif;
        private System.Windows.Forms.TextBox txt_des_speed;
        private System.Windows.Forms.TextBox txt_temp;
        private System.Windows.Forms.TextBox txt_battery;
        private System.Windows.Forms.TextBox txt_latitude;
        private System.Windows.Forms.TextBox txt_longitude;
        private System.Windows.Forms.TextBox txt_gps_altitude;
        private System.Windows.Forms.TextBox txt_pitch;
        private System.Windows.Forms.TextBox txt_roll;
        private System.Windows.Forms.TextBox txt_yaw;
        private System.Windows.Forms.TextBox txt_rhrh;
        private System.Windows.Forms.TextBox txt_IoT1;
        private System.Windows.Forms.TextBox txt_IoT2;
        private System.Windows.Forms.TextBox txt_team_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ready_to_fly;
        private System.Windows.Forms.Label lbl_recovery;
        private System.Windows.Forms.Label lbl_payload_landing;
        private System.Windows.Forms.Label lbl_seperate;
        private System.Windows.Forms.Label lbl_model_landing;
        private System.Windows.Forms.Label lbl_ascent;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer date_timer;
        private System.Windows.Forms.TextBox txt_send_time;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.PictureBox pictureBox_gps_status;
        private System.Windows.Forms.PictureBox camera_statuspic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private LiveCharts.WinForms.AngularGauge angularGauge1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel27;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private OpenTK.GLControl glControl3D;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.CheckBox checkBox1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label37;
    }
}

