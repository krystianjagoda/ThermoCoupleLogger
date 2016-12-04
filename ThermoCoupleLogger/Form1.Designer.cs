namespace ThermoCoupleLogger
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.tabDebug = new System.Windows.Forms.TabPage();
            this.buttonDebugMode = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxCOMs = new System.Windows.Forms.ComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.labelErrors = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CH1_Fault = new System.Windows.Forms.Label();
            this.CH8_Binary = new System.Windows.Forms.Label();
            this.CH7_Binary = new System.Windows.Forms.Label();
            this.CH6_Binary = new System.Windows.Forms.Label();
            this.CH5_Binary = new System.Windows.Forms.Label();
            this.CH4_Binary = new System.Windows.Forms.Label();
            this.CH3_Binary = new System.Windows.Forms.Label();
            this.CH2_Binary = new System.Windows.Forms.Label();
            this.CH1_Binary = new System.Windows.Forms.Label();
            this.textBoxCalcCheckSum = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBoxFrameCheckSum = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.buttonSendFrame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDebug = new System.Windows.Forms.RichTextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.Data5A = new System.Windows.Forms.TextBox();
            this.Data5B = new System.Windows.Forms.TextBox();
            this.Data5C = new System.Windows.Forms.TextBox();
            this.Data5D = new System.Windows.Forms.TextBox();
            this.Data2D = new System.Windows.Forms.TextBox();
            this.Data1A = new System.Windows.Forms.TextBox();
            this.Data2C = new System.Windows.Forms.TextBox();
            this.Data1B = new System.Windows.Forms.TextBox();
            this.Data2B = new System.Windows.Forms.TextBox();
            this.Data1C = new System.Windows.Forms.TextBox();
            this.Data2A = new System.Windows.Forms.TextBox();
            this.Data1D = new System.Windows.Forms.TextBox();
            this.Data6D = new System.Windows.Forms.TextBox();
            this.Data7A = new System.Windows.Forms.TextBox();
            this.Data6C = new System.Windows.Forms.TextBox();
            this.Data7B = new System.Windows.Forms.TextBox();
            this.Data6B = new System.Windows.Forms.TextBox();
            this.Data7C = new System.Windows.Forms.TextBox();
            this.Data6A = new System.Windows.Forms.TextBox();
            this.Data7D = new System.Windows.Forms.TextBox();
            this.Data4D = new System.Windows.Forms.TextBox();
            this.Data3A = new System.Windows.Forms.TextBox();
            this.Data4C = new System.Windows.Forms.TextBox();
            this.Data3B = new System.Windows.Forms.TextBox();
            this.Data4B = new System.Windows.Forms.TextBox();
            this.Data3C = new System.Windows.Forms.TextBox();
            this.Data4A = new System.Windows.Forms.TextBox();
            this.Data3D = new System.Windows.Forms.TextBox();
            this.Data8D = new System.Windows.Forms.TextBox();
            this.Data8A = new System.Windows.Forms.TextBox();
            this.Data8C = new System.Windows.Forms.TextBox();
            this.Data8B = new System.Windows.Forms.TextBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearNames = new System.Windows.Forms.Button();
            this.buttonDefaultColors = new System.Windows.Forms.Button();
            this.textBoxColorCH8 = new System.Windows.Forms.TextBox();
            this.comboBoxColorCH8 = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBoxNameCH8 = new System.Windows.Forms.TextBox();
            this.textBoxColorCH7 = new System.Windows.Forms.TextBox();
            this.comboBoxColorCH7 = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBoxNameCH7 = new System.Windows.Forms.TextBox();
            this.textBoxColorCH6 = new System.Windows.Forms.TextBox();
            this.comboBoxColorCH6 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNameCH6 = new System.Windows.Forms.TextBox();
            this.textBoxColorCH5 = new System.Windows.Forms.TextBox();
            this.comboBoxColorCH5 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNameCH5 = new System.Windows.Forms.TextBox();
            this.textBoxColorCH4 = new System.Windows.Forms.TextBox();
            this.comboBoxColorCH4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNameCH4 = new System.Windows.Forms.TextBox();
            this.textBoxColorCH3 = new System.Windows.Forms.TextBox();
            this.comboBoxColorCH3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNameCH3 = new System.Windows.Forms.TextBox();
            this.textBoxColorCH2 = new System.Windows.Forms.TextBox();
            this.comboBoxColorCH2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNameCH2 = new System.Windows.Forms.TextBox();
            this.textBoxColorCH1 = new System.Windows.Forms.TextBox();
            this.comboBoxColorCH1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameCH1 = new System.Windows.Forms.TextBox();
            this.tabData = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CH2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CH3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CH4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CH5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CH6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CH7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CH8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPreview = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.CH_A_Act = new System.Windows.Forms.Button();
            this.CHA_Value = new System.Windows.Forms.Label();
            this.CH_A_Max = new System.Windows.Forms.Button();
            this.CH_A_Avg = new System.Windows.Forms.Button();
            this.CH_A_Min = new System.Windows.Forms.Button();
            this.groupBoxCH8 = new System.Windows.Forms.GroupBox();
            this.CH_8_Act = new System.Windows.Forms.Button();
            this.CH8_Value = new System.Windows.Forms.Label();
            this.CH_8_Max = new System.Windows.Forms.Button();
            this.CH_8_Avg = new System.Windows.Forms.Button();
            this.CH_8_Min = new System.Windows.Forms.Button();
            this.groupBoxCH7 = new System.Windows.Forms.GroupBox();
            this.CH_7_Act = new System.Windows.Forms.Button();
            this.CH7_Value = new System.Windows.Forms.Label();
            this.CH_7_Max = new System.Windows.Forms.Button();
            this.CH_7_Avg = new System.Windows.Forms.Button();
            this.CH_7_Min = new System.Windows.Forms.Button();
            this.groupBoxCH6 = new System.Windows.Forms.GroupBox();
            this.CH_6_Act = new System.Windows.Forms.Button();
            this.CH6_Value = new System.Windows.Forms.Label();
            this.CH_6_Max = new System.Windows.Forms.Button();
            this.CH_6_Avg = new System.Windows.Forms.Button();
            this.CH_6_Min = new System.Windows.Forms.Button();
            this.groupBoxCH5 = new System.Windows.Forms.GroupBox();
            this.CH_5_Act = new System.Windows.Forms.Button();
            this.CH5_Value = new System.Windows.Forms.Label();
            this.CH_5_Max = new System.Windows.Forms.Button();
            this.CH_5_Avg = new System.Windows.Forms.Button();
            this.CH_5_Min = new System.Windows.Forms.Button();
            this.groupBoxCH4 = new System.Windows.Forms.GroupBox();
            this.CH_4_Act = new System.Windows.Forms.Button();
            this.CH_4_Max = new System.Windows.Forms.Button();
            this.CH_4_Min = new System.Windows.Forms.Button();
            this.CH_4_Avg = new System.Windows.Forms.Button();
            this.CH4_Value = new System.Windows.Forms.Label();
            this.groupBoxCH3 = new System.Windows.Forms.GroupBox();
            this.CH_3_Act = new System.Windows.Forms.Button();
            this.CH3_Value = new System.Windows.Forms.Label();
            this.CH_3_Max = new System.Windows.Forms.Button();
            this.CH_3_Min = new System.Windows.Forms.Button();
            this.CH_3_Avg = new System.Windows.Forms.Button();
            this.groupBoxCH2 = new System.Windows.Forms.GroupBox();
            this.CH_2_Act = new System.Windows.Forms.Button();
            this.CH2_Value = new System.Windows.Forms.Label();
            this.CH_2_Max = new System.Windows.Forms.Button();
            this.CH_2_Avg = new System.Windows.Forms.Button();
            this.CH_2_Min = new System.Windows.Forms.Button();
            this.groupBoxCH1 = new System.Windows.Forms.GroupBox();
            this.CH_1_Act = new System.Windows.Forms.Button();
            this.CH_1_Max = new System.Windows.Forms.Button();
            this.CH_1_Min = new System.Windows.Forms.Button();
            this.CH_1_Avg = new System.Windows.Forms.Button();
            this.CH1_Value = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonA = new System.Windows.Forms.Button();
            this.richTextBoxTests = new System.Windows.Forms.RichTextBox();
            this.x = new System.Windows.Forms.Button();
            this.sampleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tabDebug.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPreview.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBoxCH8.SuspendLayout();
            this.groupBoxCH7.SuspendLayout();
            this.groupBoxCH6.SuspendLayout();
            this.groupBoxCH5.SuspendLayout();
            this.groupBoxCH4.SuspendLayout();
            this.groupBoxCH3.SuspendLayout();
            this.groupBoxCH2.SuspendLayout();
            this.groupBoxCH1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource1)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelConnectionStatus.ForeColor = System.Drawing.Color.Maroon;
            this.labelConnectionStatus.Location = new System.Drawing.Point(720, 628);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(73, 13);
            this.labelConnectionStatus.TabIndex = 1;
            this.labelConnectionStatus.Text = "Disconnected";
            this.labelConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 10;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // tabDebug
            // 
            this.tabDebug.Controls.Add(this.x);
            this.tabDebug.Controls.Add(this.richTextBoxTests);
            this.tabDebug.Controls.Add(this.buttonA);
            this.tabDebug.Controls.Add(this.buttonDebugMode);
            this.tabDebug.Controls.Add(this.groupBox13);
            this.tabDebug.Controls.Add(this.groupBox12);
            this.tabDebug.Location = new System.Drawing.Point(4, 29);
            this.tabDebug.Name = "tabDebug";
            this.tabDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebug.Size = new System.Drawing.Size(777, 575);
            this.tabDebug.TabIndex = 3;
            this.tabDebug.Text = "Debug";
            this.tabDebug.UseVisualStyleBackColor = true;
            this.tabDebug.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // buttonDebugMode
            // 
            this.buttonDebugMode.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonDebugMode.Location = new System.Drawing.Point(625, 546);
            this.buttonDebugMode.Name = "buttonDebugMode";
            this.buttonDebugMode.Size = new System.Drawing.Size(146, 37);
            this.buttonDebugMode.TabIndex = 69;
            this.buttonDebugMode.Text = "Enable Debug";
            this.buttonDebugMode.UseVisualStyleBackColor = false;
            this.buttonDebugMode.Click += new System.EventHandler(this.buttonDebugMode_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.buttonConnect);
            this.groupBox13.Controls.Add(this.comboBoxCOMs);
            this.groupBox13.Location = new System.Drawing.Point(625, 330);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(143, 200);
            this.groupBox13.TabIndex = 53;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Connection";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(6, 60);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(129, 34);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxCOMs
            // 
            this.comboBoxCOMs.FormattingEnabled = true;
            this.comboBoxCOMs.Location = new System.Drawing.Point(6, 21);
            this.comboBoxCOMs.Name = "comboBoxCOMs";
            this.comboBoxCOMs.Size = new System.Drawing.Size(129, 24);
            this.comboBoxCOMs.TabIndex = 2;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.labelErrors);
            this.groupBox12.Controls.Add(this.label2);
            this.groupBox12.Controls.Add(this.CH1_Fault);
            this.groupBox12.Controls.Add(this.CH8_Binary);
            this.groupBox12.Controls.Add(this.CH7_Binary);
            this.groupBox12.Controls.Add(this.CH6_Binary);
            this.groupBox12.Controls.Add(this.CH5_Binary);
            this.groupBox12.Controls.Add(this.CH4_Binary);
            this.groupBox12.Controls.Add(this.CH3_Binary);
            this.groupBox12.Controls.Add(this.CH2_Binary);
            this.groupBox12.Controls.Add(this.CH1_Binary);
            this.groupBox12.Controls.Add(this.textBoxCalcCheckSum);
            this.groupBox12.Controls.Add(this.label39);
            this.groupBox12.Controls.Add(this.label38);
            this.groupBox12.Controls.Add(this.textBoxFrameCheckSum);
            this.groupBox12.Controls.Add(this.label30);
            this.groupBox12.Controls.Add(this.label31);
            this.groupBox12.Controls.Add(this.label32);
            this.groupBox12.Controls.Add(this.label33);
            this.groupBox12.Controls.Add(this.button1);
            this.groupBox12.Controls.Add(this.label37);
            this.groupBox12.Controls.Add(this.buttonSendFrame);
            this.groupBox12.Controls.Add(this.label1);
            this.groupBox12.Controls.Add(this.richTextBoxDebug);
            this.groupBox12.Controls.Add(this.label36);
            this.groupBox12.Controls.Add(this.label27);
            this.groupBox12.Controls.Add(this.label35);
            this.groupBox12.Controls.Add(this.label28);
            this.groupBox12.Controls.Add(this.label34);
            this.groupBox12.Controls.Add(this.label29);
            this.groupBox12.Controls.Add(this.Data5A);
            this.groupBox12.Controls.Add(this.Data5B);
            this.groupBox12.Controls.Add(this.Data5C);
            this.groupBox12.Controls.Add(this.Data5D);
            this.groupBox12.Controls.Add(this.Data2D);
            this.groupBox12.Controls.Add(this.Data1A);
            this.groupBox12.Controls.Add(this.Data2C);
            this.groupBox12.Controls.Add(this.Data1B);
            this.groupBox12.Controls.Add(this.Data2B);
            this.groupBox12.Controls.Add(this.Data1C);
            this.groupBox12.Controls.Add(this.Data2A);
            this.groupBox12.Controls.Add(this.Data1D);
            this.groupBox12.Controls.Add(this.Data6D);
            this.groupBox12.Controls.Add(this.Data7A);
            this.groupBox12.Controls.Add(this.Data6C);
            this.groupBox12.Controls.Add(this.Data7B);
            this.groupBox12.Controls.Add(this.Data6B);
            this.groupBox12.Controls.Add(this.Data7C);
            this.groupBox12.Controls.Add(this.Data6A);
            this.groupBox12.Controls.Add(this.Data7D);
            this.groupBox12.Controls.Add(this.Data4D);
            this.groupBox12.Controls.Add(this.Data3A);
            this.groupBox12.Controls.Add(this.Data4C);
            this.groupBox12.Controls.Add(this.Data3B);
            this.groupBox12.Controls.Add(this.Data4B);
            this.groupBox12.Controls.Add(this.Data3C);
            this.groupBox12.Controls.Add(this.Data4A);
            this.groupBox12.Controls.Add(this.Data3D);
            this.groupBox12.Controls.Add(this.Data8D);
            this.groupBox12.Controls.Add(this.Data8A);
            this.groupBox12.Controls.Add(this.Data8C);
            this.groupBox12.Controls.Add(this.Data8B);
            this.groupBox12.Location = new System.Drawing.Point(3, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(765, 318);
            this.groupBox12.TabIndex = 52;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Frame";
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Location = new System.Drawing.Point(701, 129);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(15, 16);
            this.labelErrors.TabIndex = 70;
            this.labelErrors.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Errors:";
            // 
            // CH1_Fault
            // 
            this.CH1_Fault.AutoSize = true;
            this.CH1_Fault.Location = new System.Drawing.Point(558, 39);
            this.CH1_Fault.Name = "CH1_Fault";
            this.CH1_Fault.Size = new System.Drawing.Size(31, 16);
            this.CH1_Fault.TabIndex = 68;
            this.CH1_Fault.Text = "N/A";
            this.CH1_Fault.Click += new System.EventHandler(this.CH1_Fault_Click);
            // 
            // CH8_Binary
            // 
            this.CH8_Binary.AutoSize = true;
            this.CH8_Binary.Location = new System.Drawing.Point(312, 235);
            this.CH8_Binary.Name = "CH8_Binary";
            this.CH8_Binary.Size = new System.Drawing.Size(57, 16);
            this.CH8_Binary.TabIndex = 67;
            this.CH8_Binary.Text = "ERROR";
            // 
            // CH7_Binary
            // 
            this.CH7_Binary.AutoSize = true;
            this.CH7_Binary.Location = new System.Drawing.Point(312, 207);
            this.CH7_Binary.Name = "CH7_Binary";
            this.CH7_Binary.Size = new System.Drawing.Size(57, 16);
            this.CH7_Binary.TabIndex = 66;
            this.CH7_Binary.Text = "ERROR";
            // 
            // CH6_Binary
            // 
            this.CH6_Binary.AutoSize = true;
            this.CH6_Binary.Location = new System.Drawing.Point(312, 179);
            this.CH6_Binary.Name = "CH6_Binary";
            this.CH6_Binary.Size = new System.Drawing.Size(57, 16);
            this.CH6_Binary.TabIndex = 65;
            this.CH6_Binary.Text = "ERROR";
            // 
            // CH5_Binary
            // 
            this.CH5_Binary.AutoSize = true;
            this.CH5_Binary.Location = new System.Drawing.Point(312, 151);
            this.CH5_Binary.Name = "CH5_Binary";
            this.CH5_Binary.Size = new System.Drawing.Size(57, 16);
            this.CH5_Binary.TabIndex = 64;
            this.CH5_Binary.Text = "ERROR";
            // 
            // CH4_Binary
            // 
            this.CH4_Binary.AutoSize = true;
            this.CH4_Binary.Location = new System.Drawing.Point(312, 123);
            this.CH4_Binary.Name = "CH4_Binary";
            this.CH4_Binary.Size = new System.Drawing.Size(57, 16);
            this.CH4_Binary.TabIndex = 63;
            this.CH4_Binary.Text = "ERROR";
            // 
            // CH3_Binary
            // 
            this.CH3_Binary.AutoSize = true;
            this.CH3_Binary.Location = new System.Drawing.Point(312, 95);
            this.CH3_Binary.Name = "CH3_Binary";
            this.CH3_Binary.Size = new System.Drawing.Size(57, 16);
            this.CH3_Binary.TabIndex = 62;
            this.CH3_Binary.Text = "ERROR";
            // 
            // CH2_Binary
            // 
            this.CH2_Binary.AutoSize = true;
            this.CH2_Binary.Location = new System.Drawing.Point(312, 67);
            this.CH2_Binary.Name = "CH2_Binary";
            this.CH2_Binary.Size = new System.Drawing.Size(57, 16);
            this.CH2_Binary.TabIndex = 61;
            this.CH2_Binary.Text = "ERROR";
            // 
            // CH1_Binary
            // 
            this.CH1_Binary.AutoSize = true;
            this.CH1_Binary.Location = new System.Drawing.Point(312, 39);
            this.CH1_Binary.Name = "CH1_Binary";
            this.CH1_Binary.Size = new System.Drawing.Size(225, 16);
            this.CH1_Binary.TabIndex = 60;
            this.CH1_Binary.Text = "0000000000000000000000000000000";
            // 
            // textBoxCalcCheckSum
            // 
            this.textBoxCalcCheckSum.Location = new System.Drawing.Point(692, 95);
            this.textBoxCalcCheckSum.Name = "textBoxCalcCheckSum";
            this.textBoxCalcCheckSum.Size = new System.Drawing.Size(65, 22);
            this.textBoxCalcCheckSum.TabIndex = 59;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(617, 73);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(140, 16);
            this.label39.TabIndex = 58;
            this.label39.Text = "CalculatedCheckSum:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(642, 20);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(115, 16);
            this.label38.TabIndex = 57;
            this.label38.Text = "FrameCheckSum:";
            // 
            // textBoxFrameCheckSum
            // 
            this.textBoxFrameCheckSum.Location = new System.Drawing.Point(692, 42);
            this.textBoxFrameCheckSum.Name = "textBoxFrameCheckSum";
            this.textBoxFrameCheckSum.Size = new System.Drawing.Size(65, 22);
            this.textBoxFrameCheckSum.TabIndex = 56;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 154);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 16);
            this.label30.TabIndex = 52;
            this.label30.Text = "CH5";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(18, 182);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(34, 16);
            this.label31.TabIndex = 53;
            this.label31.Text = "CH6";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(18, 210);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 16);
            this.label32.TabIndex = 54;
            this.label32.Text = "CH7";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(18, 238);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(34, 16);
            this.label33.TabIndex = 55;
            this.label33.Text = "CH8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "GetData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(259, 20);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 16);
            this.label37.TabIndex = 51;
            this.label37.Text = "DataD";
            // 
            // buttonSendFrame
            // 
            this.buttonSendFrame.Location = new System.Drawing.Point(365, 273);
            this.buttonSendFrame.Name = "buttonSendFrame";
            this.buttonSendFrame.Size = new System.Drawing.Size(114, 34);
            this.buttonSendFrame.TabIndex = 1;
            this.buttonSendFrame.Text = "SendFrame";
            this.buttonSendFrame.UseVisualStyleBackColor = true;
            this.buttonSendFrame.Click += new System.EventHandler(this.buttonSendFrame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "CH1";
            // 
            // richTextBoxDebug
            // 
            this.richTextBoxDebug.Location = new System.Drawing.Point(72, 273);
            this.richTextBoxDebug.Name = "richTextBoxDebug";
            this.richTextBoxDebug.Size = new System.Drawing.Size(278, 30);
            this.richTextBoxDebug.TabIndex = 0;
            this.richTextBoxDebug.Text = "";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(200, 20);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(46, 16);
            this.label36.TabIndex = 50;
            this.label36.Text = "DataC";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 16);
            this.label27.TabIndex = 9;
            this.label27.Text = "CH2";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(140, 20);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 16);
            this.label35.TabIndex = 49;
            this.label35.Text = "DataB";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 98);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 16);
            this.label28.TabIndex = 10;
            this.label28.Text = "CH3";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(80, 20);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 16);
            this.label34.TabIndex = 48;
            this.label34.Text = "DataA";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 126);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 16);
            this.label29.TabIndex = 11;
            this.label29.Text = "CH4";
            // 
            // Data5A
            // 
            this.Data5A.Location = new System.Drawing.Point(72, 151);
            this.Data5A.Name = "Data5A";
            this.Data5A.Size = new System.Drawing.Size(54, 22);
            this.Data5A.TabIndex = 12;
            // 
            // Data5B
            // 
            this.Data5B.Location = new System.Drawing.Point(132, 151);
            this.Data5B.Name = "Data5B";
            this.Data5B.Size = new System.Drawing.Size(54, 22);
            this.Data5B.TabIndex = 13;
            // 
            // Data5C
            // 
            this.Data5C.Location = new System.Drawing.Point(192, 151);
            this.Data5C.Name = "Data5C";
            this.Data5C.Size = new System.Drawing.Size(54, 22);
            this.Data5C.TabIndex = 14;
            // 
            // Data5D
            // 
            this.Data5D.Location = new System.Drawing.Point(252, 151);
            this.Data5D.Name = "Data5D";
            this.Data5D.Size = new System.Drawing.Size(54, 22);
            this.Data5D.TabIndex = 15;
            // 
            // Data2D
            // 
            this.Data2D.Location = new System.Drawing.Point(252, 67);
            this.Data2D.Name = "Data2D";
            this.Data2D.Size = new System.Drawing.Size(54, 22);
            this.Data2D.TabIndex = 43;
            // 
            // Data1A
            // 
            this.Data1A.Location = new System.Drawing.Point(72, 39);
            this.Data1A.Name = "Data1A";
            this.Data1A.Size = new System.Drawing.Size(54, 22);
            this.Data1A.TabIndex = 16;
            // 
            // Data2C
            // 
            this.Data2C.Location = new System.Drawing.Point(192, 67);
            this.Data2C.Name = "Data2C";
            this.Data2C.Size = new System.Drawing.Size(54, 22);
            this.Data2C.TabIndex = 42;
            // 
            // Data1B
            // 
            this.Data1B.Location = new System.Drawing.Point(132, 39);
            this.Data1B.Name = "Data1B";
            this.Data1B.Size = new System.Drawing.Size(54, 22);
            this.Data1B.TabIndex = 17;
            // 
            // Data2B
            // 
            this.Data2B.Location = new System.Drawing.Point(132, 67);
            this.Data2B.Name = "Data2B";
            this.Data2B.Size = new System.Drawing.Size(54, 22);
            this.Data2B.TabIndex = 41;
            // 
            // Data1C
            // 
            this.Data1C.Location = new System.Drawing.Point(192, 39);
            this.Data1C.Name = "Data1C";
            this.Data1C.Size = new System.Drawing.Size(54, 22);
            this.Data1C.TabIndex = 18;
            // 
            // Data2A
            // 
            this.Data2A.Location = new System.Drawing.Point(72, 67);
            this.Data2A.Name = "Data2A";
            this.Data2A.Size = new System.Drawing.Size(54, 22);
            this.Data2A.TabIndex = 40;
            // 
            // Data1D
            // 
            this.Data1D.Location = new System.Drawing.Point(252, 39);
            this.Data1D.Name = "Data1D";
            this.Data1D.Size = new System.Drawing.Size(54, 22);
            this.Data1D.TabIndex = 19;
            // 
            // Data6D
            // 
            this.Data6D.Location = new System.Drawing.Point(252, 179);
            this.Data6D.Name = "Data6D";
            this.Data6D.Size = new System.Drawing.Size(54, 22);
            this.Data6D.TabIndex = 39;
            // 
            // Data7A
            // 
            this.Data7A.Location = new System.Drawing.Point(72, 207);
            this.Data7A.Name = "Data7A";
            this.Data7A.Size = new System.Drawing.Size(54, 22);
            this.Data7A.TabIndex = 20;
            // 
            // Data6C
            // 
            this.Data6C.Location = new System.Drawing.Point(192, 179);
            this.Data6C.Name = "Data6C";
            this.Data6C.Size = new System.Drawing.Size(54, 22);
            this.Data6C.TabIndex = 38;
            // 
            // Data7B
            // 
            this.Data7B.Location = new System.Drawing.Point(132, 207);
            this.Data7B.Name = "Data7B";
            this.Data7B.Size = new System.Drawing.Size(54, 22);
            this.Data7B.TabIndex = 21;
            // 
            // Data6B
            // 
            this.Data6B.Location = new System.Drawing.Point(132, 179);
            this.Data6B.Name = "Data6B";
            this.Data6B.Size = new System.Drawing.Size(54, 22);
            this.Data6B.TabIndex = 37;
            // 
            // Data7C
            // 
            this.Data7C.Location = new System.Drawing.Point(192, 207);
            this.Data7C.Name = "Data7C";
            this.Data7C.Size = new System.Drawing.Size(54, 22);
            this.Data7C.TabIndex = 22;
            // 
            // Data6A
            // 
            this.Data6A.Location = new System.Drawing.Point(72, 179);
            this.Data6A.Name = "Data6A";
            this.Data6A.Size = new System.Drawing.Size(54, 22);
            this.Data6A.TabIndex = 36;
            // 
            // Data7D
            // 
            this.Data7D.Location = new System.Drawing.Point(252, 207);
            this.Data7D.Name = "Data7D";
            this.Data7D.Size = new System.Drawing.Size(54, 22);
            this.Data7D.TabIndex = 23;
            // 
            // Data4D
            // 
            this.Data4D.Location = new System.Drawing.Point(252, 123);
            this.Data4D.Name = "Data4D";
            this.Data4D.Size = new System.Drawing.Size(54, 22);
            this.Data4D.TabIndex = 35;
            // 
            // Data3A
            // 
            this.Data3A.Location = new System.Drawing.Point(72, 95);
            this.Data3A.Name = "Data3A";
            this.Data3A.Size = new System.Drawing.Size(54, 22);
            this.Data3A.TabIndex = 24;
            // 
            // Data4C
            // 
            this.Data4C.Location = new System.Drawing.Point(192, 123);
            this.Data4C.Name = "Data4C";
            this.Data4C.Size = new System.Drawing.Size(54, 22);
            this.Data4C.TabIndex = 34;
            // 
            // Data3B
            // 
            this.Data3B.Location = new System.Drawing.Point(132, 95);
            this.Data3B.Name = "Data3B";
            this.Data3B.Size = new System.Drawing.Size(54, 22);
            this.Data3B.TabIndex = 25;
            // 
            // Data4B
            // 
            this.Data4B.Location = new System.Drawing.Point(132, 123);
            this.Data4B.Name = "Data4B";
            this.Data4B.Size = new System.Drawing.Size(54, 22);
            this.Data4B.TabIndex = 33;
            // 
            // Data3C
            // 
            this.Data3C.Location = new System.Drawing.Point(192, 95);
            this.Data3C.Name = "Data3C";
            this.Data3C.Size = new System.Drawing.Size(54, 22);
            this.Data3C.TabIndex = 26;
            // 
            // Data4A
            // 
            this.Data4A.Location = new System.Drawing.Point(72, 123);
            this.Data4A.Name = "Data4A";
            this.Data4A.Size = new System.Drawing.Size(54, 22);
            this.Data4A.TabIndex = 32;
            // 
            // Data3D
            // 
            this.Data3D.Location = new System.Drawing.Point(252, 95);
            this.Data3D.Name = "Data3D";
            this.Data3D.Size = new System.Drawing.Size(54, 22);
            this.Data3D.TabIndex = 27;
            // 
            // Data8D
            // 
            this.Data8D.Location = new System.Drawing.Point(252, 235);
            this.Data8D.Name = "Data8D";
            this.Data8D.Size = new System.Drawing.Size(54, 22);
            this.Data8D.TabIndex = 31;
            // 
            // Data8A
            // 
            this.Data8A.Location = new System.Drawing.Point(72, 235);
            this.Data8A.Name = "Data8A";
            this.Data8A.Size = new System.Drawing.Size(54, 22);
            this.Data8A.TabIndex = 28;
            // 
            // Data8C
            // 
            this.Data8C.Location = new System.Drawing.Point(192, 235);
            this.Data8C.Name = "Data8C";
            this.Data8C.Size = new System.Drawing.Size(54, 22);
            this.Data8C.TabIndex = 30;
            // 
            // Data8B
            // 
            this.Data8B.Location = new System.Drawing.Point(132, 235);
            this.Data8B.Name = "Data8B";
            this.Data8B.Size = new System.Drawing.Size(54, 22);
            this.Data8B.TabIndex = 29;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox9);
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Location = new System.Drawing.Point(4, 29);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(777, 575);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClearNames);
            this.groupBox1.Controls.Add(this.buttonDefaultColors);
            this.groupBox1.Controls.Add(this.textBoxColorCH8);
            this.groupBox1.Controls.Add(this.comboBoxColorCH8);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.textBoxNameCH8);
            this.groupBox1.Controls.Add(this.textBoxColorCH7);
            this.groupBox1.Controls.Add(this.comboBoxColorCH7);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.textBoxNameCH7);
            this.groupBox1.Controls.Add(this.textBoxColorCH6);
            this.groupBox1.Controls.Add(this.comboBoxColorCH6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxNameCH6);
            this.groupBox1.Controls.Add(this.textBoxColorCH5);
            this.groupBox1.Controls.Add(this.comboBoxColorCH5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxNameCH5);
            this.groupBox1.Controls.Add(this.textBoxColorCH4);
            this.groupBox1.Controls.Add(this.comboBoxColorCH4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxNameCH4);
            this.groupBox1.Controls.Add(this.textBoxColorCH3);
            this.groupBox1.Controls.Add(this.comboBoxColorCH3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxNameCH3);
            this.groupBox1.Controls.Add(this.textBoxColorCH2);
            this.groupBox1.Controls.Add(this.comboBoxColorCH2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxNameCH2);
            this.groupBox1.Controls.Add(this.textBoxColorCH1);
            this.groupBox1.Controls.Add(this.comboBoxColorCH1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNameCH1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 577);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel Configuration";
            // 
            // buttonClearNames
            // 
            this.buttonClearNames.Location = new System.Drawing.Point(65, 270);
            this.buttonClearNames.Name = "buttonClearNames";
            this.buttonClearNames.Size = new System.Drawing.Size(136, 23);
            this.buttonClearNames.TabIndex = 35;
            this.buttonClearNames.Text = "Clear Names";
            this.buttonClearNames.UseVisualStyleBackColor = true;
            this.buttonClearNames.Click += new System.EventHandler(this.buttonClearNames_Click);
            // 
            // buttonDefaultColors
            // 
            this.buttonDefaultColors.Location = new System.Drawing.Point(235, 270);
            this.buttonDefaultColors.Name = "buttonDefaultColors";
            this.buttonDefaultColors.Size = new System.Drawing.Size(128, 23);
            this.buttonDefaultColors.TabIndex = 34;
            this.buttonDefaultColors.Text = "Default Colors";
            this.buttonDefaultColors.UseVisualStyleBackColor = true;
            this.buttonDefaultColors.Click += new System.EventHandler(this.buttonDefaultColors_Click);
            // 
            // textBoxColorCH8
            // 
            this.textBoxColorCH8.Location = new System.Drawing.Point(207, 240);
            this.textBoxColorCH8.Name = "textBoxColorCH8";
            this.textBoxColorCH8.Size = new System.Drawing.Size(22, 22);
            this.textBoxColorCH8.TabIndex = 33;
            // 
            // comboBoxColorCH8
            // 
            this.comboBoxColorCH8.FormattingEnabled = true;
            this.comboBoxColorCH8.Location = new System.Drawing.Point(235, 240);
            this.comboBoxColorCH8.Name = "comboBoxColorCH8";
            this.comboBoxColorCH8.Size = new System.Drawing.Size(128, 24);
            this.comboBoxColorCH8.TabIndex = 32;
            this.comboBoxColorCH8.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorCH8_SelectedIndexChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(22, 243);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(37, 16);
            this.label41.TabIndex = 31;
            this.label41.Text = "CH8:";
            // 
            // textBoxNameCH8
            // 
            this.textBoxNameCH8.Location = new System.Drawing.Point(65, 240);
            this.textBoxNameCH8.MaxLength = 30;
            this.textBoxNameCH8.Name = "textBoxNameCH8";
            this.textBoxNameCH8.Size = new System.Drawing.Size(136, 22);
            this.textBoxNameCH8.TabIndex = 30;
            this.textBoxNameCH8.TextChanged += new System.EventHandler(this.textBoxNameCH8_TextChanged);
            // 
            // textBoxColorCH7
            // 
            this.textBoxColorCH7.Location = new System.Drawing.Point(207, 212);
            this.textBoxColorCH7.Name = "textBoxColorCH7";
            this.textBoxColorCH7.Size = new System.Drawing.Size(22, 22);
            this.textBoxColorCH7.TabIndex = 29;
            // 
            // comboBoxColorCH7
            // 
            this.comboBoxColorCH7.FormattingEnabled = true;
            this.comboBoxColorCH7.Location = new System.Drawing.Point(235, 212);
            this.comboBoxColorCH7.Name = "comboBoxColorCH7";
            this.comboBoxColorCH7.Size = new System.Drawing.Size(128, 24);
            this.comboBoxColorCH7.TabIndex = 28;
            this.comboBoxColorCH7.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorCH7_SelectedIndexChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(22, 215);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(37, 16);
            this.label40.TabIndex = 27;
            this.label40.Text = "CH7:";
            // 
            // textBoxNameCH7
            // 
            this.textBoxNameCH7.Location = new System.Drawing.Point(65, 212);
            this.textBoxNameCH7.MaxLength = 30;
            this.textBoxNameCH7.Name = "textBoxNameCH7";
            this.textBoxNameCH7.Size = new System.Drawing.Size(136, 22);
            this.textBoxNameCH7.TabIndex = 26;
            this.textBoxNameCH7.TextChanged += new System.EventHandler(this.textBoxNameCH7_TextChanged);
            // 
            // textBoxColorCH6
            // 
            this.textBoxColorCH6.Location = new System.Drawing.Point(207, 184);
            this.textBoxColorCH6.Name = "textBoxColorCH6";
            this.textBoxColorCH6.Size = new System.Drawing.Size(22, 22);
            this.textBoxColorCH6.TabIndex = 25;
            // 
            // comboBoxColorCH6
            // 
            this.comboBoxColorCH6.FormattingEnabled = true;
            this.comboBoxColorCH6.Location = new System.Drawing.Point(235, 184);
            this.comboBoxColorCH6.Name = "comboBoxColorCH6";
            this.comboBoxColorCH6.Size = new System.Drawing.Size(128, 24);
            this.comboBoxColorCH6.TabIndex = 24;
            this.comboBoxColorCH6.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorCH6_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "CH6:";
            // 
            // textBoxNameCH6
            // 
            this.textBoxNameCH6.Location = new System.Drawing.Point(65, 184);
            this.textBoxNameCH6.MaxLength = 30;
            this.textBoxNameCH6.Name = "textBoxNameCH6";
            this.textBoxNameCH6.Size = new System.Drawing.Size(136, 22);
            this.textBoxNameCH6.TabIndex = 22;
            this.textBoxNameCH6.TextChanged += new System.EventHandler(this.textBoxNameCH6_TextChanged);
            // 
            // textBoxColorCH5
            // 
            this.textBoxColorCH5.Location = new System.Drawing.Point(207, 156);
            this.textBoxColorCH5.Name = "textBoxColorCH5";
            this.textBoxColorCH5.Size = new System.Drawing.Size(22, 22);
            this.textBoxColorCH5.TabIndex = 21;
            // 
            // comboBoxColorCH5
            // 
            this.comboBoxColorCH5.FormattingEnabled = true;
            this.comboBoxColorCH5.Location = new System.Drawing.Point(235, 156);
            this.comboBoxColorCH5.Name = "comboBoxColorCH5";
            this.comboBoxColorCH5.Size = new System.Drawing.Size(128, 24);
            this.comboBoxColorCH5.TabIndex = 20;
            this.comboBoxColorCH5.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorCH5_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "CH5:";
            // 
            // textBoxNameCH5
            // 
            this.textBoxNameCH5.Location = new System.Drawing.Point(65, 156);
            this.textBoxNameCH5.MaxLength = 30;
            this.textBoxNameCH5.Name = "textBoxNameCH5";
            this.textBoxNameCH5.Size = new System.Drawing.Size(136, 22);
            this.textBoxNameCH5.TabIndex = 18;
            this.textBoxNameCH5.TextChanged += new System.EventHandler(this.textBoxNameCH5_TextChanged);
            // 
            // textBoxColorCH4
            // 
            this.textBoxColorCH4.Location = new System.Drawing.Point(207, 128);
            this.textBoxColorCH4.Name = "textBoxColorCH4";
            this.textBoxColorCH4.Size = new System.Drawing.Size(22, 22);
            this.textBoxColorCH4.TabIndex = 17;
            // 
            // comboBoxColorCH4
            // 
            this.comboBoxColorCH4.FormattingEnabled = true;
            this.comboBoxColorCH4.Location = new System.Drawing.Point(235, 128);
            this.comboBoxColorCH4.Name = "comboBoxColorCH4";
            this.comboBoxColorCH4.Size = new System.Drawing.Size(128, 24);
            this.comboBoxColorCH4.TabIndex = 16;
            this.comboBoxColorCH4.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorCH4_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "CH4:";
            // 
            // textBoxNameCH4
            // 
            this.textBoxNameCH4.Location = new System.Drawing.Point(65, 128);
            this.textBoxNameCH4.MaxLength = 30;
            this.textBoxNameCH4.Name = "textBoxNameCH4";
            this.textBoxNameCH4.Size = new System.Drawing.Size(136, 22);
            this.textBoxNameCH4.TabIndex = 14;
            this.textBoxNameCH4.TextChanged += new System.EventHandler(this.textBoxNameCH4_TextChanged);
            // 
            // textBoxColorCH3
            // 
            this.textBoxColorCH3.Location = new System.Drawing.Point(207, 100);
            this.textBoxColorCH3.Name = "textBoxColorCH3";
            this.textBoxColorCH3.Size = new System.Drawing.Size(22, 22);
            this.textBoxColorCH3.TabIndex = 13;
            // 
            // comboBoxColorCH3
            // 
            this.comboBoxColorCH3.FormattingEnabled = true;
            this.comboBoxColorCH3.Location = new System.Drawing.Point(235, 100);
            this.comboBoxColorCH3.Name = "comboBoxColorCH3";
            this.comboBoxColorCH3.Size = new System.Drawing.Size(128, 24);
            this.comboBoxColorCH3.TabIndex = 12;
            this.comboBoxColorCH3.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorCH3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "CH3:";
            // 
            // textBoxNameCH3
            // 
            this.textBoxNameCH3.Location = new System.Drawing.Point(65, 100);
            this.textBoxNameCH3.MaxLength = 30;
            this.textBoxNameCH3.Name = "textBoxNameCH3";
            this.textBoxNameCH3.Size = new System.Drawing.Size(136, 22);
            this.textBoxNameCH3.TabIndex = 10;
            this.textBoxNameCH3.TextChanged += new System.EventHandler(this.textBoxNameCH3_TextChanged);
            // 
            // textBoxColorCH2
            // 
            this.textBoxColorCH2.Location = new System.Drawing.Point(207, 72);
            this.textBoxColorCH2.Name = "textBoxColorCH2";
            this.textBoxColorCH2.Size = new System.Drawing.Size(22, 22);
            this.textBoxColorCH2.TabIndex = 9;
            // 
            // comboBoxColorCH2
            // 
            this.comboBoxColorCH2.FormattingEnabled = true;
            this.comboBoxColorCH2.Location = new System.Drawing.Point(235, 72);
            this.comboBoxColorCH2.Name = "comboBoxColorCH2";
            this.comboBoxColorCH2.Size = new System.Drawing.Size(128, 24);
            this.comboBoxColorCH2.TabIndex = 8;
            this.comboBoxColorCH2.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorCH2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "CH2:";
            // 
            // textBoxNameCH2
            // 
            this.textBoxNameCH2.Location = new System.Drawing.Point(65, 72);
            this.textBoxNameCH2.MaxLength = 30;
            this.textBoxNameCH2.Name = "textBoxNameCH2";
            this.textBoxNameCH2.Size = new System.Drawing.Size(136, 22);
            this.textBoxNameCH2.TabIndex = 6;
            this.textBoxNameCH2.TextChanged += new System.EventHandler(this.textBoxNameCH2_TextChanged);
            // 
            // textBoxColorCH1
            // 
            this.textBoxColorCH1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxColorCH1.Location = new System.Drawing.Point(207, 44);
            this.textBoxColorCH1.Name = "textBoxColorCH1";
            this.textBoxColorCH1.Size = new System.Drawing.Size(22, 22);
            this.textBoxColorCH1.TabIndex = 5;
            // 
            // comboBoxColorCH1
            // 
            this.comboBoxColorCH1.FormattingEnabled = true;
            this.comboBoxColorCH1.Location = new System.Drawing.Point(235, 44);
            this.comboBoxColorCH1.Name = "comboBoxColorCH1";
            this.comboBoxColorCH1.Size = new System.Drawing.Size(128, 24);
            this.comboBoxColorCH1.TabIndex = 4;
            this.comboBoxColorCH1.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorCH1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "CH1:";
            // 
            // textBoxNameCH1
            // 
            this.textBoxNameCH1.Location = new System.Drawing.Point(65, 44);
            this.textBoxNameCH1.MaxLength = 30;
            this.textBoxNameCH1.Name = "textBoxNameCH1";
            this.textBoxNameCH1.Size = new System.Drawing.Size(136, 22);
            this.textBoxNameCH1.TabIndex = 0;
            this.textBoxNameCH1.TextChanged += new System.EventHandler(this.textBoxNameCH1_TextChanged);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dataGridView1);
            this.tabData.Location = new System.Drawing.Point(4, 29);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(777, 575);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_No,
            this.Column_Time,
            this.Column_CH1,
            this.Column_CH2,
            this.Column_CH3,
            this.Column_CH4,
            this.Column_CH5,
            this.Column_CH6,
            this.Column_CH7,
            this.Column_CH8});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 505);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column_No
            // 
            this.Column_No.Frozen = true;
            this.Column_No.HeaderText = "Sample Number";
            this.Column_No.Name = "Column_No";
            this.Column_No.ReadOnly = true;
            this.Column_No.Width = 70;
            // 
            // Column_Time
            // 
            this.Column_Time.Frozen = true;
            this.Column_Time.HeaderText = "Time [HH:MM:SS]";
            this.Column_Time.Name = "Column_Time";
            this.Column_Time.ReadOnly = true;
            // 
            // Column_CH1
            // 
            this.Column_CH1.Frozen = true;
            this.Column_CH1.HeaderText = "CH1 [°C]";
            this.Column_CH1.Name = "Column_CH1";
            this.Column_CH1.Width = 65;
            // 
            // Column_CH2
            // 
            this.Column_CH2.Frozen = true;
            this.Column_CH2.HeaderText = "CH2 [°C]";
            this.Column_CH2.Name = "Column_CH2";
            this.Column_CH2.Width = 65;
            // 
            // Column_CH3
            // 
            this.Column_CH3.Frozen = true;
            this.Column_CH3.HeaderText = "CH3 [°C]";
            this.Column_CH3.Name = "Column_CH3";
            this.Column_CH3.Width = 65;
            // 
            // Column_CH4
            // 
            this.Column_CH4.Frozen = true;
            this.Column_CH4.HeaderText = "CH4 [°C]";
            this.Column_CH4.Name = "Column_CH4";
            this.Column_CH4.Width = 65;
            // 
            // Column_CH5
            // 
            this.Column_CH5.Frozen = true;
            this.Column_CH5.HeaderText = "CH5 [°C]";
            this.Column_CH5.Name = "Column_CH5";
            this.Column_CH5.Width = 65;
            // 
            // Column_CH6
            // 
            this.Column_CH6.Frozen = true;
            this.Column_CH6.HeaderText = "CH6 [°C]";
            this.Column_CH6.Name = "Column_CH6";
            this.Column_CH6.Width = 65;
            // 
            // Column_CH7
            // 
            this.Column_CH7.Frozen = true;
            this.Column_CH7.HeaderText = "CH7 [°C]";
            this.Column_CH7.Name = "Column_CH7";
            this.Column_CH7.Width = 65;
            // 
            // Column_CH8
            // 
            this.Column_CH8.Frozen = true;
            this.Column_CH8.HeaderText = "CH8 [°C]";
            this.Column_CH8.Name = "Column_CH8";
            this.Column_CH8.Width = 65;
            // 
            // tabPreview
            // 
            this.tabPreview.Controls.Add(this.groupBox11);
            this.tabPreview.Controls.Add(this.groupBox10);
            this.tabPreview.Controls.Add(this.groupBoxCH8);
            this.tabPreview.Controls.Add(this.groupBoxCH7);
            this.tabPreview.Controls.Add(this.groupBoxCH6);
            this.tabPreview.Controls.Add(this.groupBoxCH5);
            this.tabPreview.Controls.Add(this.groupBoxCH4);
            this.tabPreview.Controls.Add(this.groupBoxCH3);
            this.tabPreview.Controls.Add(this.groupBoxCH2);
            this.tabPreview.Controls.Add(this.groupBoxCH1);
            this.tabPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPreview.Location = new System.Drawing.Point(4, 29);
            this.tabPreview.Name = "tabPreview";
            this.tabPreview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreview.Size = new System.Drawing.Size(777, 575);
            this.tabPreview.TabIndex = 0;
            this.tabPreview.Text = "Preview";
            this.tabPreview.UseVisualStyleBackColor = true;
            this.tabPreview.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Controls.Add(this.label25);
            this.groupBox11.Controls.Add(this.label24);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(413, 17);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(347, 180);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Info";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label26.Location = new System.Drawing.Point(183, 27);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 29);
            this.label26.TabIndex = 25;
            this.label26.Text = "00:00:25";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label25.Location = new System.Drawing.Point(39, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(138, 29);
            this.label25.TabIndex = 24;
            this.label25.Text = "Next Scan:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(183, 124);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 29);
            this.label24.TabIndex = 23;
            this.label24.Text = "00:34:25";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(47, 124);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(130, 29);
            this.label23.TabIndex = 22;
            this.label23.Text = "Time Left:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(183, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 29);
            this.label22.TabIndex = 21;
            this.label22.Text = "458";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(55, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 29);
            this.label21.TabIndex = 20;
            this.label21.Text = "Samples:";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonStart.Location = new System.Drawing.Point(12, 627);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(97, 27);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.CH_A_Act);
            this.groupBox10.Controls.Add(this.CHA_Value);
            this.groupBox10.Controls.Add(this.CH_A_Max);
            this.groupBox10.Controls.Add(this.CH_A_Avg);
            this.groupBox10.Controls.Add(this.CH_A_Min);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(17, 513);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(380, 56);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Logger Ambient";
            // 
            // CH_A_Act
            // 
            this.CH_A_Act.BackColor = System.Drawing.Color.Gainsboro;
            this.CH_A_Act.Location = new System.Drawing.Point(170, 17);
            this.CH_A_Act.Name = "CH_A_Act";
            this.CH_A_Act.Size = new System.Drawing.Size(46, 29);
            this.CH_A_Act.TabIndex = 36;
            this.CH_A_Act.Text = "Act";
            this.CH_A_Act.UseVisualStyleBackColor = false;
            this.CH_A_Act.Click += new System.EventHandler(this.CH_A_Act_Click);
            // 
            // CHA_Value
            // 
            this.CHA_Value.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CHA_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHA_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CHA_Value.Location = new System.Drawing.Point(-2, 17);
            this.CHA_Value.Name = "CHA_Value";
            this.CHA_Value.Size = new System.Drawing.Size(166, 31);
            this.CHA_Value.TabIndex = 8;
            this.CHA_Value.Text = " -254.25 °C";
            this.CHA_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CH_A_Max
            // 
            this.CH_A_Max.BackColor = System.Drawing.Color.White;
            this.CH_A_Max.Location = new System.Drawing.Point(222, 17);
            this.CH_A_Max.Name = "CH_A_Max";
            this.CH_A_Max.Size = new System.Drawing.Size(46, 29);
            this.CH_A_Max.TabIndex = 35;
            this.CH_A_Max.Text = "Max";
            this.CH_A_Max.UseVisualStyleBackColor = false;
            this.CH_A_Max.Click += new System.EventHandler(this.CH_A_Max_Click);
            // 
            // CH_A_Avg
            // 
            this.CH_A_Avg.BackColor = System.Drawing.Color.White;
            this.CH_A_Avg.Location = new System.Drawing.Point(326, 17);
            this.CH_A_Avg.Name = "CH_A_Avg";
            this.CH_A_Avg.Size = new System.Drawing.Size(46, 29);
            this.CH_A_Avg.TabIndex = 33;
            this.CH_A_Avg.Text = "Avg";
            this.CH_A_Avg.UseVisualStyleBackColor = false;
            this.CH_A_Avg.Click += new System.EventHandler(this.CH_A_Avg_Click);
            // 
            // CH_A_Min
            // 
            this.CH_A_Min.BackColor = System.Drawing.Color.White;
            this.CH_A_Min.Location = new System.Drawing.Point(274, 17);
            this.CH_A_Min.Name = "CH_A_Min";
            this.CH_A_Min.Size = new System.Drawing.Size(46, 29);
            this.CH_A_Min.TabIndex = 34;
            this.CH_A_Min.Text = "Min";
            this.CH_A_Min.UseVisualStyleBackColor = false;
            this.CH_A_Min.Click += new System.EventHandler(this.CH_A_Min_Click);
            // 
            // groupBoxCH8
            // 
            this.groupBoxCH8.Controls.Add(this.CH_8_Act);
            this.groupBoxCH8.Controls.Add(this.CH8_Value);
            this.groupBoxCH8.Controls.Add(this.CH_8_Max);
            this.groupBoxCH8.Controls.Add(this.CH_8_Avg);
            this.groupBoxCH8.Controls.Add(this.CH_8_Min);
            this.groupBoxCH8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCH8.Location = new System.Drawing.Point(17, 451);
            this.groupBoxCH8.Name = "groupBoxCH8";
            this.groupBoxCH8.Size = new System.Drawing.Size(380, 56);
            this.groupBoxCH8.TabIndex = 1;
            this.groupBoxCH8.TabStop = false;
            this.groupBoxCH8.Text = "CH8 - ";
            // 
            // CH_8_Act
            // 
            this.CH_8_Act.BackColor = System.Drawing.Color.Gainsboro;
            this.CH_8_Act.Location = new System.Drawing.Point(170, 17);
            this.CH_8_Act.Name = "CH_8_Act";
            this.CH_8_Act.Size = new System.Drawing.Size(46, 29);
            this.CH_8_Act.TabIndex = 32;
            this.CH_8_Act.Text = "Act";
            this.CH_8_Act.UseVisualStyleBackColor = false;
            this.CH_8_Act.Click += new System.EventHandler(this.CH_8_Act_Click);
            // 
            // CH8_Value
            // 
            this.CH8_Value.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CH8_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CH8_Value.ForeColor = System.Drawing.Color.MediumOrchid;
            this.CH8_Value.Location = new System.Drawing.Point(-2, 17);
            this.CH8_Value.Name = "CH8_Value";
            this.CH8_Value.Size = new System.Drawing.Size(166, 31);
            this.CH8_Value.TabIndex = 7;
            this.CH8_Value.Text = " -254.25 °C";
            this.CH8_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CH_8_Max
            // 
            this.CH_8_Max.BackColor = System.Drawing.Color.White;
            this.CH_8_Max.Location = new System.Drawing.Point(222, 17);
            this.CH_8_Max.Name = "CH_8_Max";
            this.CH_8_Max.Size = new System.Drawing.Size(46, 29);
            this.CH_8_Max.TabIndex = 31;
            this.CH_8_Max.Text = "Max";
            this.CH_8_Max.UseVisualStyleBackColor = false;
            this.CH_8_Max.Click += new System.EventHandler(this.CH_8_Max_Click);
            // 
            // CH_8_Avg
            // 
            this.CH_8_Avg.BackColor = System.Drawing.Color.White;
            this.CH_8_Avg.Location = new System.Drawing.Point(326, 17);
            this.CH_8_Avg.Name = "CH_8_Avg";
            this.CH_8_Avg.Size = new System.Drawing.Size(46, 29);
            this.CH_8_Avg.TabIndex = 29;
            this.CH_8_Avg.Text = "Avg";
            this.CH_8_Avg.UseVisualStyleBackColor = false;
            this.CH_8_Avg.Click += new System.EventHandler(this.CH_8_Avg_Click);
            // 
            // CH_8_Min
            // 
            this.CH_8_Min.BackColor = System.Drawing.Color.White;
            this.CH_8_Min.Location = new System.Drawing.Point(274, 17);
            this.CH_8_Min.Name = "CH_8_Min";
            this.CH_8_Min.Size = new System.Drawing.Size(46, 29);
            this.CH_8_Min.TabIndex = 30;
            this.CH_8_Min.Text = "Min";
            this.CH_8_Min.UseVisualStyleBackColor = false;
            this.CH_8_Min.Click += new System.EventHandler(this.CH_8_Min_Click);
            // 
            // groupBoxCH7
            // 
            this.groupBoxCH7.Controls.Add(this.CH_7_Act);
            this.groupBoxCH7.Controls.Add(this.CH7_Value);
            this.groupBoxCH7.Controls.Add(this.CH_7_Max);
            this.groupBoxCH7.Controls.Add(this.CH_7_Avg);
            this.groupBoxCH7.Controls.Add(this.CH_7_Min);
            this.groupBoxCH7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCH7.Location = new System.Drawing.Point(17, 389);
            this.groupBoxCH7.Name = "groupBoxCH7";
            this.groupBoxCH7.Size = new System.Drawing.Size(380, 56);
            this.groupBoxCH7.TabIndex = 1;
            this.groupBoxCH7.TabStop = false;
            this.groupBoxCH7.Text = "CH7 - ";
            // 
            // CH_7_Act
            // 
            this.CH_7_Act.BackColor = System.Drawing.Color.Gainsboro;
            this.CH_7_Act.Location = new System.Drawing.Point(170, 17);
            this.CH_7_Act.Name = "CH_7_Act";
            this.CH_7_Act.Size = new System.Drawing.Size(46, 29);
            this.CH_7_Act.TabIndex = 28;
            this.CH_7_Act.Text = "Act";
            this.CH_7_Act.UseVisualStyleBackColor = false;
            this.CH_7_Act.Click += new System.EventHandler(this.CH_7_Act_Click);
            // 
            // CH7_Value
            // 
            this.CH7_Value.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CH7_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CH7_Value.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CH7_Value.Location = new System.Drawing.Point(-2, 17);
            this.CH7_Value.Name = "CH7_Value";
            this.CH7_Value.Size = new System.Drawing.Size(166, 31);
            this.CH7_Value.TabIndex = 6;
            this.CH7_Value.Text = " -254.25 °C";
            this.CH7_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CH_7_Max
            // 
            this.CH_7_Max.BackColor = System.Drawing.Color.White;
            this.CH_7_Max.Location = new System.Drawing.Point(222, 17);
            this.CH_7_Max.Name = "CH_7_Max";
            this.CH_7_Max.Size = new System.Drawing.Size(46, 29);
            this.CH_7_Max.TabIndex = 27;
            this.CH_7_Max.Text = "Max";
            this.CH_7_Max.UseVisualStyleBackColor = false;
            this.CH_7_Max.Click += new System.EventHandler(this.CH_7_Max_Click);
            // 
            // CH_7_Avg
            // 
            this.CH_7_Avg.BackColor = System.Drawing.Color.White;
            this.CH_7_Avg.Location = new System.Drawing.Point(326, 17);
            this.CH_7_Avg.Name = "CH_7_Avg";
            this.CH_7_Avg.Size = new System.Drawing.Size(46, 29);
            this.CH_7_Avg.TabIndex = 25;
            this.CH_7_Avg.Text = "Avg";
            this.CH_7_Avg.UseVisualStyleBackColor = false;
            this.CH_7_Avg.Click += new System.EventHandler(this.CH_7_Avg_Click);
            // 
            // CH_7_Min
            // 
            this.CH_7_Min.BackColor = System.Drawing.Color.White;
            this.CH_7_Min.Location = new System.Drawing.Point(274, 17);
            this.CH_7_Min.Name = "CH_7_Min";
            this.CH_7_Min.Size = new System.Drawing.Size(46, 29);
            this.CH_7_Min.TabIndex = 26;
            this.CH_7_Min.Text = "Min";
            this.CH_7_Min.UseVisualStyleBackColor = false;
            this.CH_7_Min.Click += new System.EventHandler(this.CH_7_Min_Click);
            // 
            // groupBoxCH6
            // 
            this.groupBoxCH6.Controls.Add(this.CH_6_Act);
            this.groupBoxCH6.Controls.Add(this.CH6_Value);
            this.groupBoxCH6.Controls.Add(this.CH_6_Max);
            this.groupBoxCH6.Controls.Add(this.CH_6_Avg);
            this.groupBoxCH6.Controls.Add(this.CH_6_Min);
            this.groupBoxCH6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCH6.Location = new System.Drawing.Point(17, 327);
            this.groupBoxCH6.Name = "groupBoxCH6";
            this.groupBoxCH6.Size = new System.Drawing.Size(380, 56);
            this.groupBoxCH6.TabIndex = 1;
            this.groupBoxCH6.TabStop = false;
            this.groupBoxCH6.Text = "CH6 - ";
            // 
            // CH_6_Act
            // 
            this.CH_6_Act.BackColor = System.Drawing.Color.Gainsboro;
            this.CH_6_Act.Location = new System.Drawing.Point(170, 17);
            this.CH_6_Act.Name = "CH_6_Act";
            this.CH_6_Act.Size = new System.Drawing.Size(46, 29);
            this.CH_6_Act.TabIndex = 24;
            this.CH_6_Act.Text = "Act";
            this.CH_6_Act.UseVisualStyleBackColor = false;
            this.CH_6_Act.Click += new System.EventHandler(this.CH_6_Act_Click);
            // 
            // CH6_Value
            // 
            this.CH6_Value.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CH6_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CH6_Value.ForeColor = System.Drawing.Color.DimGray;
            this.CH6_Value.Location = new System.Drawing.Point(-2, 17);
            this.CH6_Value.Name = "CH6_Value";
            this.CH6_Value.Size = new System.Drawing.Size(166, 31);
            this.CH6_Value.TabIndex = 5;
            this.CH6_Value.Text = " -254.25 °C";
            this.CH6_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CH_6_Max
            // 
            this.CH_6_Max.BackColor = System.Drawing.Color.White;
            this.CH_6_Max.Location = new System.Drawing.Point(222, 17);
            this.CH_6_Max.Name = "CH_6_Max";
            this.CH_6_Max.Size = new System.Drawing.Size(46, 29);
            this.CH_6_Max.TabIndex = 23;
            this.CH_6_Max.Text = "Max";
            this.CH_6_Max.UseVisualStyleBackColor = false;
            this.CH_6_Max.Click += new System.EventHandler(this.CH_6_Max_Click);
            // 
            // CH_6_Avg
            // 
            this.CH_6_Avg.BackColor = System.Drawing.Color.White;
            this.CH_6_Avg.Location = new System.Drawing.Point(326, 17);
            this.CH_6_Avg.Name = "CH_6_Avg";
            this.CH_6_Avg.Size = new System.Drawing.Size(46, 29);
            this.CH_6_Avg.TabIndex = 21;
            this.CH_6_Avg.Text = "Avg";
            this.CH_6_Avg.UseVisualStyleBackColor = false;
            this.CH_6_Avg.Click += new System.EventHandler(this.CH_6_Avg_Click);
            // 
            // CH_6_Min
            // 
            this.CH_6_Min.BackColor = System.Drawing.Color.White;
            this.CH_6_Min.Location = new System.Drawing.Point(274, 17);
            this.CH_6_Min.Name = "CH_6_Min";
            this.CH_6_Min.Size = new System.Drawing.Size(46, 29);
            this.CH_6_Min.TabIndex = 22;
            this.CH_6_Min.Text = "Min";
            this.CH_6_Min.UseVisualStyleBackColor = false;
            this.CH_6_Min.Click += new System.EventHandler(this.CH_6_Min_Click);
            // 
            // groupBoxCH5
            // 
            this.groupBoxCH5.Controls.Add(this.CH_5_Act);
            this.groupBoxCH5.Controls.Add(this.CH5_Value);
            this.groupBoxCH5.Controls.Add(this.CH_5_Max);
            this.groupBoxCH5.Controls.Add(this.CH_5_Avg);
            this.groupBoxCH5.Controls.Add(this.CH_5_Min);
            this.groupBoxCH5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCH5.Location = new System.Drawing.Point(17, 265);
            this.groupBoxCH5.Name = "groupBoxCH5";
            this.groupBoxCH5.Size = new System.Drawing.Size(380, 56);
            this.groupBoxCH5.TabIndex = 1;
            this.groupBoxCH5.TabStop = false;
            this.groupBoxCH5.Text = "CH5 - ";
            // 
            // CH_5_Act
            // 
            this.CH_5_Act.BackColor = System.Drawing.Color.Gainsboro;
            this.CH_5_Act.Location = new System.Drawing.Point(170, 17);
            this.CH_5_Act.Name = "CH_5_Act";
            this.CH_5_Act.Size = new System.Drawing.Size(46, 29);
            this.CH_5_Act.TabIndex = 20;
            this.CH_5_Act.Text = "Act";
            this.CH_5_Act.UseVisualStyleBackColor = false;
            this.CH_5_Act.Click += new System.EventHandler(this.CH_5_Act_Click);
            // 
            // CH5_Value
            // 
            this.CH5_Value.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CH5_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CH5_Value.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.CH5_Value.Location = new System.Drawing.Point(-2, 17);
            this.CH5_Value.Name = "CH5_Value";
            this.CH5_Value.Size = new System.Drawing.Size(166, 31);
            this.CH5_Value.TabIndex = 4;
            this.CH5_Value.Text = " -254.25 °C";
            this.CH5_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CH_5_Max
            // 
            this.CH_5_Max.BackColor = System.Drawing.Color.White;
            this.CH_5_Max.Location = new System.Drawing.Point(222, 17);
            this.CH_5_Max.Name = "CH_5_Max";
            this.CH_5_Max.Size = new System.Drawing.Size(46, 29);
            this.CH_5_Max.TabIndex = 19;
            this.CH_5_Max.Text = "Max";
            this.CH_5_Max.UseVisualStyleBackColor = false;
            this.CH_5_Max.Click += new System.EventHandler(this.CH_5_Max_Click);
            // 
            // CH_5_Avg
            // 
            this.CH_5_Avg.BackColor = System.Drawing.Color.White;
            this.CH_5_Avg.Location = new System.Drawing.Point(326, 17);
            this.CH_5_Avg.Name = "CH_5_Avg";
            this.CH_5_Avg.Size = new System.Drawing.Size(46, 29);
            this.CH_5_Avg.TabIndex = 17;
            this.CH_5_Avg.Text = "Avg";
            this.CH_5_Avg.UseVisualStyleBackColor = false;
            this.CH_5_Avg.Click += new System.EventHandler(this.CH_5_Avg_Click);
            // 
            // CH_5_Min
            // 
            this.CH_5_Min.BackColor = System.Drawing.Color.White;
            this.CH_5_Min.Location = new System.Drawing.Point(274, 17);
            this.CH_5_Min.Name = "CH_5_Min";
            this.CH_5_Min.Size = new System.Drawing.Size(46, 29);
            this.CH_5_Min.TabIndex = 18;
            this.CH_5_Min.Text = "Min";
            this.CH_5_Min.UseVisualStyleBackColor = false;
            this.CH_5_Min.Click += new System.EventHandler(this.CH_5_Min_Click);
            // 
            // groupBoxCH4
            // 
            this.groupBoxCH4.Controls.Add(this.CH_4_Act);
            this.groupBoxCH4.Controls.Add(this.CH_4_Max);
            this.groupBoxCH4.Controls.Add(this.CH_4_Min);
            this.groupBoxCH4.Controls.Add(this.CH_4_Avg);
            this.groupBoxCH4.Controls.Add(this.CH4_Value);
            this.groupBoxCH4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCH4.Location = new System.Drawing.Point(17, 203);
            this.groupBoxCH4.Name = "groupBoxCH4";
            this.groupBoxCH4.Size = new System.Drawing.Size(380, 56);
            this.groupBoxCH4.TabIndex = 1;
            this.groupBoxCH4.TabStop = false;
            this.groupBoxCH4.Text = "CH4 - ";
            // 
            // CH_4_Act
            // 
            this.CH_4_Act.BackColor = System.Drawing.Color.Gainsboro;
            this.CH_4_Act.Location = new System.Drawing.Point(170, 17);
            this.CH_4_Act.Name = "CH_4_Act";
            this.CH_4_Act.Size = new System.Drawing.Size(46, 29);
            this.CH_4_Act.TabIndex = 16;
            this.CH_4_Act.Text = "Act";
            this.CH_4_Act.UseVisualStyleBackColor = false;
            this.CH_4_Act.Click += new System.EventHandler(this.CH_4_Act_Click);
            // 
            // CH_4_Max
            // 
            this.CH_4_Max.BackColor = System.Drawing.Color.White;
            this.CH_4_Max.Location = new System.Drawing.Point(222, 17);
            this.CH_4_Max.Name = "CH_4_Max";
            this.CH_4_Max.Size = new System.Drawing.Size(46, 29);
            this.CH_4_Max.TabIndex = 15;
            this.CH_4_Max.Text = "Max";
            this.CH_4_Max.UseVisualStyleBackColor = false;
            this.CH_4_Max.Click += new System.EventHandler(this.CH_4_Max_Click);
            // 
            // CH_4_Min
            // 
            this.CH_4_Min.BackColor = System.Drawing.Color.White;
            this.CH_4_Min.Location = new System.Drawing.Point(274, 17);
            this.CH_4_Min.Name = "CH_4_Min";
            this.CH_4_Min.Size = new System.Drawing.Size(46, 29);
            this.CH_4_Min.TabIndex = 14;
            this.CH_4_Min.Text = "Min";
            this.CH_4_Min.UseVisualStyleBackColor = false;
            this.CH_4_Min.Click += new System.EventHandler(this.CH_4_Min_Click);
            // 
            // CH_4_Avg
            // 
            this.CH_4_Avg.BackColor = System.Drawing.Color.White;
            this.CH_4_Avg.Location = new System.Drawing.Point(326, 17);
            this.CH_4_Avg.Name = "CH_4_Avg";
            this.CH_4_Avg.Size = new System.Drawing.Size(46, 29);
            this.CH_4_Avg.TabIndex = 13;
            this.CH_4_Avg.Text = "Avg";
            this.CH_4_Avg.UseVisualStyleBackColor = false;
            this.CH_4_Avg.Click += new System.EventHandler(this.CH_4_Avg_Click);
            // 
            // CH4_Value
            // 
            this.CH4_Value.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CH4_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CH4_Value.ForeColor = System.Drawing.Color.DarkMagenta;
            this.CH4_Value.Location = new System.Drawing.Point(-2, 17);
            this.CH4_Value.Name = "CH4_Value";
            this.CH4_Value.Size = new System.Drawing.Size(166, 31);
            this.CH4_Value.TabIndex = 3;
            this.CH4_Value.Text = " -254.25 °C";
            this.CH4_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxCH3
            // 
            this.groupBoxCH3.Controls.Add(this.CH_3_Act);
            this.groupBoxCH3.Controls.Add(this.CH3_Value);
            this.groupBoxCH3.Controls.Add(this.CH_3_Max);
            this.groupBoxCH3.Controls.Add(this.CH_3_Min);
            this.groupBoxCH3.Controls.Add(this.CH_3_Avg);
            this.groupBoxCH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCH3.Location = new System.Drawing.Point(17, 141);
            this.groupBoxCH3.Name = "groupBoxCH3";
            this.groupBoxCH3.Size = new System.Drawing.Size(380, 56);
            this.groupBoxCH3.TabIndex = 1;
            this.groupBoxCH3.TabStop = false;
            this.groupBoxCH3.Text = "CH3 - ";
            // 
            // CH_3_Act
            // 
            this.CH_3_Act.BackColor = System.Drawing.Color.Gainsboro;
            this.CH_3_Act.Location = new System.Drawing.Point(170, 17);
            this.CH_3_Act.Name = "CH_3_Act";
            this.CH_3_Act.Size = new System.Drawing.Size(46, 29);
            this.CH_3_Act.TabIndex = 20;
            this.CH_3_Act.Text = "Act";
            this.CH_3_Act.UseVisualStyleBackColor = false;
            this.CH_3_Act.Click += new System.EventHandler(this.CH_3_Act_Click);
            // 
            // CH3_Value
            // 
            this.CH3_Value.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CH3_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CH3_Value.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CH3_Value.Location = new System.Drawing.Point(-2, 17);
            this.CH3_Value.Name = "CH3_Value";
            this.CH3_Value.Size = new System.Drawing.Size(166, 31);
            this.CH3_Value.TabIndex = 2;
            this.CH3_Value.Text = " -254.25 °C";
            this.CH3_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CH_3_Max
            // 
            this.CH_3_Max.BackColor = System.Drawing.Color.White;
            this.CH_3_Max.Location = new System.Drawing.Point(222, 17);
            this.CH_3_Max.Name = "CH_3_Max";
            this.CH_3_Max.Size = new System.Drawing.Size(46, 29);
            this.CH_3_Max.TabIndex = 19;
            this.CH_3_Max.Text = "Max";
            this.CH_3_Max.UseVisualStyleBackColor = false;
            this.CH_3_Max.Click += new System.EventHandler(this.CH_3_Max_Click);
            // 
            // CH_3_Min
            // 
            this.CH_3_Min.BackColor = System.Drawing.Color.White;
            this.CH_3_Min.Location = new System.Drawing.Point(274, 17);
            this.CH_3_Min.Name = "CH_3_Min";
            this.CH_3_Min.Size = new System.Drawing.Size(46, 29);
            this.CH_3_Min.TabIndex = 18;
            this.CH_3_Min.Text = "Min";
            this.CH_3_Min.UseVisualStyleBackColor = false;
            this.CH_3_Min.Click += new System.EventHandler(this.CH_3_Min_Click);
            // 
            // CH_3_Avg
            // 
            this.CH_3_Avg.BackColor = System.Drawing.Color.White;
            this.CH_3_Avg.Location = new System.Drawing.Point(326, 17);
            this.CH_3_Avg.Name = "CH_3_Avg";
            this.CH_3_Avg.Size = new System.Drawing.Size(46, 29);
            this.CH_3_Avg.TabIndex = 17;
            this.CH_3_Avg.Text = "Avg";
            this.CH_3_Avg.UseVisualStyleBackColor = false;
            this.CH_3_Avg.Click += new System.EventHandler(this.CH_3_Avg_Click);
            // 
            // groupBoxCH2
            // 
            this.groupBoxCH2.Controls.Add(this.CH_2_Act);
            this.groupBoxCH2.Controls.Add(this.CH2_Value);
            this.groupBoxCH2.Controls.Add(this.CH_2_Max);
            this.groupBoxCH2.Controls.Add(this.CH_2_Avg);
            this.groupBoxCH2.Controls.Add(this.CH_2_Min);
            this.groupBoxCH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCH2.Location = new System.Drawing.Point(17, 79);
            this.groupBoxCH2.Name = "groupBoxCH2";
            this.groupBoxCH2.Size = new System.Drawing.Size(380, 56);
            this.groupBoxCH2.TabIndex = 1;
            this.groupBoxCH2.TabStop = false;
            this.groupBoxCH2.Text = "CH2 - ";
            // 
            // CH_2_Act
            // 
            this.CH_2_Act.BackColor = System.Drawing.Color.Gainsboro;
            this.CH_2_Act.Location = new System.Drawing.Point(170, 17);
            this.CH_2_Act.Name = "CH_2_Act";
            this.CH_2_Act.Size = new System.Drawing.Size(46, 29);
            this.CH_2_Act.TabIndex = 16;
            this.CH_2_Act.Text = "Act";
            this.CH_2_Act.UseVisualStyleBackColor = false;
            this.CH_2_Act.Click += new System.EventHandler(this.CH_2_Act_Click);
            // 
            // CH2_Value
            // 
            this.CH2_Value.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CH2_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CH2_Value.ForeColor = System.Drawing.Color.Firebrick;
            this.CH2_Value.Location = new System.Drawing.Point(-2, 17);
            this.CH2_Value.Name = "CH2_Value";
            this.CH2_Value.Size = new System.Drawing.Size(166, 31);
            this.CH2_Value.TabIndex = 1;
            this.CH2_Value.Text = " -254.25 °C";
            this.CH2_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CH_2_Max
            // 
            this.CH_2_Max.BackColor = System.Drawing.Color.White;
            this.CH_2_Max.Location = new System.Drawing.Point(222, 17);
            this.CH_2_Max.Name = "CH_2_Max";
            this.CH_2_Max.Size = new System.Drawing.Size(46, 29);
            this.CH_2_Max.TabIndex = 15;
            this.CH_2_Max.Text = "Max";
            this.CH_2_Max.UseVisualStyleBackColor = false;
            this.CH_2_Max.Click += new System.EventHandler(this.CH_2_Max_Click);
            // 
            // CH_2_Avg
            // 
            this.CH_2_Avg.BackColor = System.Drawing.Color.White;
            this.CH_2_Avg.Location = new System.Drawing.Point(326, 17);
            this.CH_2_Avg.Name = "CH_2_Avg";
            this.CH_2_Avg.Size = new System.Drawing.Size(46, 29);
            this.CH_2_Avg.TabIndex = 13;
            this.CH_2_Avg.Text = "Avg";
            this.CH_2_Avg.UseVisualStyleBackColor = false;
            this.CH_2_Avg.Click += new System.EventHandler(this.CH_2_Avg_Click);
            // 
            // CH_2_Min
            // 
            this.CH_2_Min.BackColor = System.Drawing.Color.White;
            this.CH_2_Min.Location = new System.Drawing.Point(274, 17);
            this.CH_2_Min.Name = "CH_2_Min";
            this.CH_2_Min.Size = new System.Drawing.Size(46, 29);
            this.CH_2_Min.TabIndex = 14;
            this.CH_2_Min.Text = "Min";
            this.CH_2_Min.UseVisualStyleBackColor = false;
            this.CH_2_Min.Click += new System.EventHandler(this.CH_2_Min_Click);
            // 
            // groupBoxCH1
            // 
            this.groupBoxCH1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCH1.Controls.Add(this.CH_1_Act);
            this.groupBoxCH1.Controls.Add(this.CH_1_Max);
            this.groupBoxCH1.Controls.Add(this.CH_1_Min);
            this.groupBoxCH1.Controls.Add(this.CH_1_Avg);
            this.groupBoxCH1.Controls.Add(this.CH1_Value);
            this.groupBoxCH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCH1.ForeColor = System.Drawing.Color.Black;
            this.groupBoxCH1.Location = new System.Drawing.Point(17, 17);
            this.groupBoxCH1.Name = "groupBoxCH1";
            this.groupBoxCH1.Size = new System.Drawing.Size(380, 56);
            this.groupBoxCH1.TabIndex = 0;
            this.groupBoxCH1.TabStop = false;
            this.groupBoxCH1.Text = "CH1 - ";
            // 
            // CH_1_Act
            // 
            this.CH_1_Act.BackColor = System.Drawing.Color.Gainsboro;
            this.CH_1_Act.Location = new System.Drawing.Point(170, 17);
            this.CH_1_Act.Name = "CH_1_Act";
            this.CH_1_Act.Size = new System.Drawing.Size(46, 29);
            this.CH_1_Act.TabIndex = 12;
            this.CH_1_Act.Text = "Act";
            this.CH_1_Act.UseVisualStyleBackColor = false;
            this.CH_1_Act.Click += new System.EventHandler(this.CH_1_Act_Click);
            // 
            // CH_1_Max
            // 
            this.CH_1_Max.BackColor = System.Drawing.Color.White;
            this.CH_1_Max.Location = new System.Drawing.Point(222, 17);
            this.CH_1_Max.Name = "CH_1_Max";
            this.CH_1_Max.Size = new System.Drawing.Size(46, 29);
            this.CH_1_Max.TabIndex = 11;
            this.CH_1_Max.Text = "Max";
            this.CH_1_Max.UseVisualStyleBackColor = false;
            this.CH_1_Max.Click += new System.EventHandler(this.CH_1_Max_Click);
            // 
            // CH_1_Min
            // 
            this.CH_1_Min.BackColor = System.Drawing.Color.White;
            this.CH_1_Min.Location = new System.Drawing.Point(274, 17);
            this.CH_1_Min.Name = "CH_1_Min";
            this.CH_1_Min.Size = new System.Drawing.Size(46, 29);
            this.CH_1_Min.TabIndex = 10;
            this.CH_1_Min.Text = "Min";
            this.CH_1_Min.UseVisualStyleBackColor = false;
            this.CH_1_Min.Click += new System.EventHandler(this.CH_1_Min_Click);
            // 
            // CH_1_Avg
            // 
            this.CH_1_Avg.BackColor = System.Drawing.Color.White;
            this.CH_1_Avg.Location = new System.Drawing.Point(326, 17);
            this.CH_1_Avg.Name = "CH_1_Avg";
            this.CH_1_Avg.Size = new System.Drawing.Size(46, 29);
            this.CH_1_Avg.TabIndex = 9;
            this.CH_1_Avg.Text = "Avg";
            this.CH_1_Avg.UseVisualStyleBackColor = false;
            this.CH_1_Avg.Click += new System.EventHandler(this.CH_1_Avg_Click);
            // 
            // CH1_Value
            // 
            this.CH1_Value.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CH1_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CH1_Value.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CH1_Value.Location = new System.Drawing.Point(-2, 17);
            this.CH1_Value.Name = "CH1_Value";
            this.CH1_Value.Size = new System.Drawing.Size(166, 31);
            this.CH1_Value.TabIndex = 0;
            this.CH1_Value.Text = " -254.25 °C";
            this.CH1_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPreview);
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabGraph);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabDebug);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 25);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 608);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.chart1);
            this.tabGraph.Location = new System.Drawing.Point(4, 29);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(777, 575);
            this.tabGraph.TabIndex = 4;
            this.tabGraph.Text = "Graph";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.sampleBindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DarkGoldenrod;
            series1.Legend = "Legend1";
            series1.Name = "CH1";
            series1.XValueMember = "SampleNumber";
            series1.YValueMembers = "Channel1Values";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Firebrick;
            series2.Legend = "Legend1";
            series2.Name = "CH2";
            series2.XValueMember = "SampleNumber";
            series2.YValueMembers = "Channel2Values";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.RoyalBlue;
            series3.Legend = "Legend1";
            series3.Name = "CH3";
            series3.XValueMember = "SampleNumber";
            series3.YValueMembers = "Channel3Values";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "CH4";
            series4.XValueMember = "SampleNumber";
            series4.YValueMembers = "Channel4Values";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "CH5";
            series5.XValueMember = "SampleNumber";
            series5.YValueMembers = "Channel5Values";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "CH6";
            series6.XValueMember = "SampleNumber";
            series6.YValueMembers = "Channel6Values";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "CH7";
            series7.XValueMember = "SampleNumber";
            series7.YValueMembers = "Channel7Values";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "CH8";
            series8.XValueMember = "SampleNumber";
            series8.YValueMembers = "Channel8Values";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(765, 577);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(6, 546);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(123, 30);
            this.buttonA.TabIndex = 70;
            this.buttonA.Text = "Function A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // richTextBoxTests
            // 
            this.richTextBoxTests.Location = new System.Drawing.Point(6, 330);
            this.richTextBoxTests.Name = "richTextBoxTests";
            this.richTextBoxTests.Size = new System.Drawing.Size(252, 210);
            this.richTextBoxTests.TabIndex = 71;
            this.richTextBoxTests.Text = "";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(135, 546);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(123, 30);
            this.x.TabIndex = 72;
            this.x.Text = "Function B";
            this.x.UseVisualStyleBackColor = true;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // sampleBindingSource1
            // 
            this.sampleBindingSource1.DataSource = typeof(ThermoCoupleLogger.Sample);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.textBox4);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.textBox3);
            this.groupBox9.Controls.Add(this.textBox2);
            this.groupBox9.Controls.Add(this.textBox1);
            this.groupBox9.Controls.Add(this.numericUpDown4);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.checkBox1);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.numericUpDown3);
            this.groupBox9.Controls.Add(this.numericUpDown2);
            this.groupBox9.Controls.Add(this.numericUpDown1);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(402, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(369, 242);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Acquisition Settings";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(280, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 16);
            this.label20.TabIndex = 19;
            this.label20.Text = "Sec:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(225, 139);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 16);
            this.label19.TabIndex = 18;
            this.label19.Text = "Min:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(167, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "Hrs:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(98, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 16);
            this.label17.TabIndex = 16;
            this.label17.Text = "Days:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(263, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 22);
            this.textBox4.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Total Time:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(89, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(147, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(205, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 22);
            this.textBox1.TabIndex = 11;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Location = new System.Drawing.Point(89, 100);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(105, 22);
            this.numericUpDown4.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "Samples:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(200, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(104, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Sample Limit";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(250, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "mSec:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(190, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Sec:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(122, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Min:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(231, 50);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown3.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(160, 50);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 50);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Period:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 663);
            this.Controls.Add(this.labelConnectionStatus);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ThermoCoupler";
            this.tabDebug.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPreview.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBoxCH8.ResumeLayout(false);
            this.groupBoxCH7.ResumeLayout(false);
            this.groupBoxCH6.ResumeLayout(false);
            this.groupBoxCH5.ResumeLayout(false);
            this.groupBoxCH4.ResumeLayout(false);
            this.groupBoxCH3.ResumeLayout(false);
            this.groupBoxCH2.ResumeLayout(false);
            this.groupBoxCH1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TabPage tabDebug;
        private System.Windows.Forms.Button buttonDebugMode;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxCOMs;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CH1_Fault;
        private System.Windows.Forms.Label CH8_Binary;
        private System.Windows.Forms.Label CH7_Binary;
        private System.Windows.Forms.Label CH6_Binary;
        private System.Windows.Forms.Label CH5_Binary;
        private System.Windows.Forms.Label CH4_Binary;
        private System.Windows.Forms.Label CH3_Binary;
        private System.Windows.Forms.Label CH2_Binary;
        private System.Windows.Forms.Label CH1_Binary;
        private System.Windows.Forms.TextBox textBoxCalcCheckSum;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBoxFrameCheckSum;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button buttonSendFrame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDebug;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox Data5A;
        private System.Windows.Forms.TextBox Data5B;
        private System.Windows.Forms.TextBox Data5C;
        private System.Windows.Forms.TextBox Data5D;
        private System.Windows.Forms.TextBox Data2D;
        private System.Windows.Forms.TextBox Data1A;
        private System.Windows.Forms.TextBox Data2C;
        private System.Windows.Forms.TextBox Data1B;
        private System.Windows.Forms.TextBox Data2B;
        private System.Windows.Forms.TextBox Data1C;
        private System.Windows.Forms.TextBox Data2A;
        private System.Windows.Forms.TextBox Data1D;
        private System.Windows.Forms.TextBox Data6D;
        private System.Windows.Forms.TextBox Data7A;
        private System.Windows.Forms.TextBox Data6C;
        private System.Windows.Forms.TextBox Data7B;
        private System.Windows.Forms.TextBox Data6B;
        private System.Windows.Forms.TextBox Data7C;
        private System.Windows.Forms.TextBox Data6A;
        private System.Windows.Forms.TextBox Data7D;
        private System.Windows.Forms.TextBox Data4D;
        private System.Windows.Forms.TextBox Data3A;
        private System.Windows.Forms.TextBox Data4C;
        private System.Windows.Forms.TextBox Data3B;
        private System.Windows.Forms.TextBox Data4B;
        private System.Windows.Forms.TextBox Data3C;
        private System.Windows.Forms.TextBox Data4A;
        private System.Windows.Forms.TextBox Data3D;
        private System.Windows.Forms.TextBox Data8D;
        private System.Windows.Forms.TextBox Data8A;
        private System.Windows.Forms.TextBox Data8C;
        private System.Windows.Forms.TextBox Data8B;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClearNames;
        private System.Windows.Forms.Button buttonDefaultColors;
        private System.Windows.Forms.TextBox textBoxColorCH8;
        private System.Windows.Forms.ComboBox comboBoxColorCH8;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBoxNameCH8;
        private System.Windows.Forms.TextBox textBoxColorCH7;
        private System.Windows.Forms.ComboBox comboBoxColorCH7;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBoxNameCH7;
        private System.Windows.Forms.TextBox textBoxColorCH6;
        private System.Windows.Forms.ComboBox comboBoxColorCH6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNameCH6;
        private System.Windows.Forms.TextBox textBoxColorCH5;
        private System.Windows.Forms.ComboBox comboBoxColorCH5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNameCH5;
        private System.Windows.Forms.TextBox textBoxColorCH4;
        private System.Windows.Forms.ComboBox comboBoxColorCH4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNameCH4;
        private System.Windows.Forms.TextBox textBoxColorCH3;
        private System.Windows.Forms.ComboBox comboBoxColorCH3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNameCH3;
        private System.Windows.Forms.TextBox textBoxColorCH2;
        private System.Windows.Forms.ComboBox comboBoxColorCH2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNameCH2;
        private System.Windows.Forms.TextBox textBoxColorCH1;
        private System.Windows.Forms.ComboBox comboBoxColorCH1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameCH1;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CH2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CH3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CH4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CH5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CH6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CH7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CH8;
        private System.Windows.Forms.TabPage tabPreview;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button CH_A_Act;
        private System.Windows.Forms.Label CHA_Value;
        private System.Windows.Forms.Button CH_A_Max;
        private System.Windows.Forms.Button CH_A_Avg;
        private System.Windows.Forms.Button CH_A_Min;
        private System.Windows.Forms.GroupBox groupBoxCH8;
        private System.Windows.Forms.Button CH_8_Act;
        private System.Windows.Forms.Label CH8_Value;
        private System.Windows.Forms.Button CH_8_Max;
        private System.Windows.Forms.Button CH_8_Avg;
        private System.Windows.Forms.Button CH_8_Min;
        private System.Windows.Forms.GroupBox groupBoxCH7;
        private System.Windows.Forms.Button CH_7_Act;
        private System.Windows.Forms.Label CH7_Value;
        private System.Windows.Forms.Button CH_7_Max;
        private System.Windows.Forms.Button CH_7_Avg;
        private System.Windows.Forms.Button CH_7_Min;
        private System.Windows.Forms.GroupBox groupBoxCH6;
        private System.Windows.Forms.Button CH_6_Act;
        private System.Windows.Forms.Label CH6_Value;
        private System.Windows.Forms.Button CH_6_Max;
        private System.Windows.Forms.Button CH_6_Avg;
        private System.Windows.Forms.Button CH_6_Min;
        private System.Windows.Forms.GroupBox groupBoxCH5;
        private System.Windows.Forms.Button CH_5_Act;
        private System.Windows.Forms.Label CH5_Value;
        private System.Windows.Forms.Button CH_5_Max;
        private System.Windows.Forms.Button CH_5_Avg;
        private System.Windows.Forms.Button CH_5_Min;
        private System.Windows.Forms.GroupBox groupBoxCH4;
        private System.Windows.Forms.Button CH_4_Act;
        private System.Windows.Forms.Button CH_4_Max;
        private System.Windows.Forms.Button CH_4_Min;
        private System.Windows.Forms.Button CH_4_Avg;
        private System.Windows.Forms.Label CH4_Value;
        private System.Windows.Forms.GroupBox groupBoxCH3;
        private System.Windows.Forms.Button CH_3_Act;
        private System.Windows.Forms.Label CH3_Value;
        private System.Windows.Forms.Button CH_3_Max;
        private System.Windows.Forms.Button CH_3_Min;
        private System.Windows.Forms.Button CH_3_Avg;
        private System.Windows.Forms.GroupBox groupBoxCH2;
        private System.Windows.Forms.Button CH_2_Act;
        private System.Windows.Forms.Label CH2_Value;
        private System.Windows.Forms.Button CH_2_Max;
        private System.Windows.Forms.Button CH_2_Avg;
        private System.Windows.Forms.Button CH_2_Min;
        private System.Windows.Forms.GroupBox groupBoxCH1;
        private System.Windows.Forms.Button CH_1_Act;
        private System.Windows.Forms.Button CH_1_Max;
        private System.Windows.Forms.Button CH_1_Min;
        private System.Windows.Forms.Button CH_1_Avg;
        private System.Windows.Forms.Label CH1_Value;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.RichTextBox richTextBoxTests;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.BindingSource sampleBindingSource1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
    }
}

