namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PbConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbSecCom = new System.Windows.Forms.ComboBox();
            this.LbStatus = new System.Windows.Forms.Label();
            this.Com = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Txt_Data = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check_box_mode = new System.Windows.Forms.CheckBox();
            this.txt_InvX = new System.Windows.Forms.TextBox();
            this.Pb_Inv = new System.Windows.Forms.Button();
            this.txt_InvZ = new System.Windows.Forms.TextBox();
            this.txt_InvY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_zcur = new System.Windows.Forms.TextBox();
            this.txt_ycur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_xcur = new System.Windows.Forms.TextBox();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtd1 = new System.Windows.Forms.TextBox();
            this.txtTheta2 = new System.Windows.Forms.TextBox();
            this.txtTheta1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BTN_For = new System.Windows.Forms.Button();
            this.Btn_Grap = new System.Windows.Forms.Button();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.TB_theta4 = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_theta4 = new System.Windows.Forms.TextBox();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_theta4)).BeginInit();
            this.SuspendLayout();
            // 
            // PbConnect
            // 
            this.PbConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PbConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbConnect.Location = new System.Drawing.Point(136, 57);
            this.PbConnect.Margin = new System.Windows.Forms.Padding(4);
            this.PbConnect.Name = "PbConnect";
            this.PbConnect.Size = new System.Drawing.Size(117, 36);
            this.PbConnect.TabIndex = 0;
            this.PbConnect.Text = "Conenct";
            this.PbConnect.UseVisualStyleBackColor = true;
            this.PbConnect.Click += new System.EventHandler(this.PbConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbSecCom);
            this.groupBox1.Controls.Add(this.PbConnect);
            this.groupBox1.Controls.Add(this.LbStatus);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(275, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Com";
            // 
            // CbSecCom
            // 
            this.CbSecCom.FormattingEnabled = true;
            this.CbSecCom.Location = new System.Drawing.Point(132, 23);
            this.CbSecCom.Margin = new System.Windows.Forms.Padding(4);
            this.CbSecCom.Name = "CbSecCom";
            this.CbSecCom.Size = new System.Drawing.Size(120, 24);
            this.CbSecCom.TabIndex = 2;
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStatus.Location = new System.Drawing.Point(4, 86);
            this.LbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(104, 20);
            this.LbStatus.TabIndex = 4;
            this.LbStatus.Text = "Disconnect";
            // 
            // Com
            // 
            this.Com.BaudRate = 115200;
            this.Com.PortName = "COM7";
            this.Com.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.OnCom);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Txt_Data
            // 
            this.Txt_Data.Location = new System.Drawing.Point(629, 238);
            this.Txt_Data.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Data.Multiline = true;
            this.Txt_Data.Name = "Txt_Data";
            this.Txt_Data.Size = new System.Drawing.Size(229, 197);
            this.Txt_Data.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_box_mode);
            this.groupBox3.Controls.Add(this.txt_InvX);
            this.groupBox3.Controls.Add(this.Pb_Inv);
            this.groupBox3.Controls.Add(this.txt_InvZ);
            this.groupBox3.Controls.Add(this.txt_InvY);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(353, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(229, 223);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target position";
            // 
            // check_box_mode
            // 
            this.check_box_mode.AutoSize = true;
            this.check_box_mode.Location = new System.Drawing.Point(16, 189);
            this.check_box_mode.Name = "check_box_mode";
            this.check_box_mode.Size = new System.Drawing.Size(101, 21);
            this.check_box_mode.TabIndex = 17;
            this.check_box_mode.Text = "Grap Mode";
            this.check_box_mode.UseVisualStyleBackColor = true;
            this.check_box_mode.CheckedChanged += new System.EventHandler(this.check_box_mode_CheckedChanged);
            // 
            // txt_InvX
            // 
            this.txt_InvX.Location = new System.Drawing.Point(76, 46);
            this.txt_InvX.Margin = new System.Windows.Forms.Padding(4);
            this.txt_InvX.Multiline = true;
            this.txt_InvX.Name = "txt_InvX";
            this.txt_InvX.Size = new System.Drawing.Size(97, 25);
            this.txt_InvX.TabIndex = 16;
            // 
            // Pb_Inv
            // 
            this.Pb_Inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pb_Inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pb_Inv.Location = new System.Drawing.Point(121, 179);
            this.Pb_Inv.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_Inv.Name = "Pb_Inv";
            this.Pb_Inv.Size = new System.Drawing.Size(99, 36);
            this.Pb_Inv.TabIndex = 13;
            this.Pb_Inv.Text = "Inverse";
            this.Pb_Inv.UseVisualStyleBackColor = true;
            this.Pb_Inv.Click += new System.EventHandler(this.Pb_Inv_Click);
            // 
            // txt_InvZ
            // 
            this.txt_InvZ.Location = new System.Drawing.Point(76, 123);
            this.txt_InvZ.Margin = new System.Windows.Forms.Padding(4);
            this.txt_InvZ.Multiline = true;
            this.txt_InvZ.Name = "txt_InvZ";
            this.txt_InvZ.Size = new System.Drawing.Size(97, 25);
            this.txt_InvZ.TabIndex = 12;
            this.txt_InvZ.TextChanged += new System.EventHandler(this.txt_InvZ_TextChanged);
            // 
            // txt_InvY
            // 
            this.txt_InvY.Location = new System.Drawing.Point(76, 82);
            this.txt_InvY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_InvY.Multiline = true;
            this.txt_InvY.Name = "txt_InvY";
            this.txt_InvY.Size = new System.Drawing.Size(97, 25);
            this.txt_InvY.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_zcur);
            this.groupBox2.Controls.Add(this.txt_ycur);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_xcur);
            this.groupBox2.Location = new System.Drawing.Point(629, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(229, 193);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current position";
            // 
            // txt_zcur
            // 
            this.txt_zcur.Location = new System.Drawing.Point(76, 123);
            this.txt_zcur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_zcur.Multiline = true;
            this.txt_zcur.Name = "txt_zcur";
            this.txt_zcur.Size = new System.Drawing.Size(97, 25);
            this.txt_zcur.TabIndex = 12;
            this.txt_zcur.Text = "0";
            // 
            // txt_ycur
            // 
            this.txt_ycur.Location = new System.Drawing.Point(76, 79);
            this.txt_ycur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ycur.Multiline = true;
            this.txt_ycur.Name = "txt_ycur";
            this.txt_ycur.Size = new System.Drawing.Size(97, 25);
            this.txt_ycur.TabIndex = 15;
            this.txt_ycur.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "X";
            // 
            // txt_xcur
            // 
            this.txt_xcur.Location = new System.Drawing.Point(76, 42);
            this.txt_xcur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_xcur.Multiline = true;
            this.txt_xcur.Name = "txt_xcur";
            this.txt_xcur.Size = new System.Drawing.Size(97, 25);
            this.txt_xcur.TabIndex = 10;
            this.txt_xcur.Text = "20.6";
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(96, 238);
            this.trackBarX.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarX.Maximum = 120;
            this.trackBarX.Minimum = -120;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(139, 56);
            this.trackBarX.TabIndex = 13;
            this.trackBarX.Value = 100;
            this.trackBarX.ValueChanged += new System.EventHandler(this.trackBarX_ValueChanged);
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(96, 306);
            this.trackBarY.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarY.Maximum = 150;
            this.trackBarY.Minimum = -150;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(139, 56);
            this.trackBarY.TabIndex = 14;
            this.trackBarY.Value = -125;
            this.trackBarY.ValueChanged += new System.EventHandler(this.trackBarY_ValueChanged);
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(96, 375);
            this.trackBarZ.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarZ.Maximum = 23;
            this.trackBarZ.Minimum = 11;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(139, 56);
            this.trackBarZ.TabIndex = 15;
            this.trackBarZ.Value = 11;
            this.trackBarZ.ValueChanged += new System.EventHandler(this.trackBarZ_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Theta 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 306);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Theta 2 ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 375);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "d1";
            // 
            // txtd1
            // 
            this.txtd1.Location = new System.Drawing.Point(243, 375);
            this.txtd1.Margin = new System.Windows.Forms.Padding(4);
            this.txtd1.Multiline = true;
            this.txtd1.Name = "txtd1";
            this.txtd1.Size = new System.Drawing.Size(97, 25);
            this.txtd1.TabIndex = 20;
            this.txtd1.Text = "11";
            // 
            // txtTheta2
            // 
            this.txtTheta2.Location = new System.Drawing.Point(243, 306);
            this.txtTheta2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheta2.Multiline = true;
            this.txtTheta2.Name = "txtTheta2";
            this.txtTheta2.Size = new System.Drawing.Size(97, 25);
            this.txtTheta2.TabIndex = 21;
            this.txtTheta2.Text = "-125";
            // 
            // txtTheta1
            // 
            this.txtTheta1.Location = new System.Drawing.Point(243, 238);
            this.txtTheta1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheta1.Multiline = true;
            this.txtTheta1.Name = "txtTheta1";
            this.txtTheta1.Size = new System.Drawing.Size(97, 25);
            this.txtTheta1.TabIndex = 19;
            this.txtTheta1.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(543, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Data recive";
            // 
            // BTN_For
            // 
            this.BTN_For.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_For.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_For.Location = new System.Drawing.Point(243, 497);
            this.BTN_For.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_For.Name = "BTN_For";
            this.BTN_For.Size = new System.Drawing.Size(99, 36);
            this.BTN_For.TabIndex = 23;
            this.BTN_For.Text = "Forward";
            this.BTN_For.UseVisualStyleBackColor = true;
            this.BTN_For.Click += new System.EventHandler(this.BTN_For_Click);
            // 
            // Btn_Grap
            // 
            this.Btn_Grap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Grap.Location = new System.Drawing.Point(428, 300);
            this.Btn_Grap.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Grap.Name = "Btn_Grap";
            this.Btn_Grap.Size = new System.Drawing.Size(100, 32);
            this.Btn_Grap.TabIndex = 24;
            this.Btn_Grap.Text = "Grap";
            this.Btn_Grap.UseVisualStyleBackColor = true;
            this.Btn_Grap.Click += new System.EventHandler(this.Btn_Grap_Click);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reset.Location = new System.Drawing.Point(523, 425);
            this.Btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(100, 32);
            this.Btn_reset.TabIndex = 25;
            this.Btn_reset.Text = "Reset";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // TB_theta4
            // 
            this.TB_theta4.Location = new System.Drawing.Point(96, 425);
            this.TB_theta4.Margin = new System.Windows.Forms.Padding(4);
            this.TB_theta4.Maximum = 180;
            this.TB_theta4.Name = "TB_theta4";
            this.TB_theta4.Size = new System.Drawing.Size(139, 56);
            this.TB_theta4.TabIndex = 26;
            this.TB_theta4.ValueChanged += new System.EventHandler(this.TB_theta4_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 436);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Theta 4";
            // 
            // Txt_theta4
            // 
            this.Txt_theta4.Location = new System.Drawing.Point(243, 432);
            this.Txt_theta4.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_theta4.Multiline = true;
            this.Txt_theta4.Name = "Txt_theta4";
            this.Txt_theta4.Size = new System.Drawing.Size(97, 25);
            this.Txt_theta4.TabIndex = 28;
            this.Txt_theta4.Text = "0";
            // 
            // Btn_Home
            // 
            this.Btn_Home.Location = new System.Drawing.Point(429, 359);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(97, 41);
            this.Btn_Home.TabIndex = 29;
            this.Btn_Home.Text = "Set Home";
            this.Btn_Home.UseVisualStyleBackColor = true;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 546);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Txt_theta4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TB_theta4);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Btn_Grap);
            this.Controls.Add(this.BTN_For);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtd1);
            this.Controls.Add(this.txtTheta2);
            this.Controls.Add(this.txtTheta1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Data);
            this.Controls.Add(this.trackBarZ);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_theta4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PbConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort Com;
        private System.Windows.Forms.ComboBox CbSecCom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbStatus;
        private System.Windows.Forms.TextBox Txt_Data;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_InvZ;
        private System.Windows.Forms.TextBox txt_InvY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_zcur;
        private System.Windows.Forms.TextBox txt_ycur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_xcur;
        private System.Windows.Forms.Button Pb_Inv;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtd1;
        private System.Windows.Forms.TextBox txtTheta2;
        private System.Windows.Forms.TextBox txtTheta1;
        private System.Windows.Forms.TextBox txt_InvX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BTN_For;
        private System.Windows.Forms.Button Btn_Grap;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.CheckBox check_box_mode;
        private System.Windows.Forms.TrackBar TB_theta4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_theta4;
        private System.Windows.Forms.Button Btn_Home;
    }
}

