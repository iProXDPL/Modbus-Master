namespace Lab_5__Modbus_
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.StatusStrip statusStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.TextConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PlikiToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SavetoFileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.połaczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polaczMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.rozlaczMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainWindow = new System.Windows.Forms.TabPage();
            this.DebugBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChangeBTN = new System.Windows.Forms.Button();
            this.WartoscValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.RegValue = new System.Windows.Forms.NumericUpDown();
            this.Rejestr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Function = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LengthRead = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Device = new System.Windows.Forms.NumericUpDown();
            this.ConnectionWindow = new System.Windows.Forms.TabPage();
            this.Disconnect = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TimeRefresh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Timeout = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.TCPSelect = new System.Windows.Forms.RadioButton();
            this.SelectTypeModbus = new System.Windows.Forms.Label();
            this.RTUSelect = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TCPPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TCPIP = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RefreshComs = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxStopbits = new System.Windows.Forms.ComboBox();
            this.comboBoxPorty = new System.Windows.Forms.ComboBox();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MainWindow.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WartoscValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Device)).BeginInit();
            this.ConnectionWindow.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressLabel,
            this.ProgressBar,
            this.TextConnect});
            statusStrip1.Location = new System.Drawing.Point(0, 458);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(890, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(66, 17);
            this.ProgressLabel.Text = "Rozłączone";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // TextConnect
            // 
            this.TextConnect.Name = "TextConnect";
            this.TextConnect.Size = new System.Drawing.Size(12, 17);
            this.TextConnect.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlikiToolStrip,
            this.połaczenieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PlikiToolStrip
            // 
            this.PlikiToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavetoFileMenuStrip});
            this.PlikiToolStrip.Name = "PlikiToolStrip";
            this.PlikiToolStrip.Size = new System.Drawing.Size(41, 20);
            this.PlikiToolStrip.Text = "Pliki";
            // 
            // SavetoFileMenuStrip
            // 
            this.SavetoFileMenuStrip.Name = "SavetoFileMenuStrip";
            this.SavetoFileMenuStrip.Size = new System.Drawing.Size(153, 22);
            this.SavetoFileMenuStrip.Text = "Zapisz do pliku";
            this.SavetoFileMenuStrip.Click += new System.EventHandler(this.SavetoFileMenuStrip_Click);
            // 
            // połaczenieToolStripMenuItem
            // 
            this.połaczenieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polaczMenuClick,
            this.rozlaczMenuClick});
            this.połaczenieToolStripMenuItem.Name = "połaczenieToolStripMenuItem";
            this.połaczenieToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.połaczenieToolStripMenuItem.Text = "Połaczenie";
            // 
            // polaczMenuClick
            // 
            this.polaczMenuClick.Name = "polaczMenuClick";
            this.polaczMenuClick.Size = new System.Drawing.Size(180, 22);
            this.polaczMenuClick.Text = "Połącz";
            this.polaczMenuClick.Click += new System.EventHandler(this.PolaczMenu_Click);
            // 
            // rozlaczMenuClick
            // 
            this.rozlaczMenuClick.Enabled = false;
            this.rozlaczMenuClick.Name = "rozlaczMenuClick";
            this.rozlaczMenuClick.Size = new System.Drawing.Size(180, 22);
            this.rozlaczMenuClick.Text = "Rozłącz";
            this.rozlaczMenuClick.Click += new System.EventHandler(this.RozlaczMenu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainWindow);
            this.tabControl1.Controls.Add(this.ConnectionWindow);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 433);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.MainWindow.Controls.Add(this.DebugBox);
            this.MainWindow.Controls.Add(this.groupBox4);
            this.MainWindow.Controls.Add(this.groupBox3);
            this.MainWindow.Controls.Add(this.groupBox1);
            this.MainWindow.Location = new System.Drawing.Point(4, 22);
            this.MainWindow.Name = "MainWindow";
            this.MainWindow.Padding = new System.Windows.Forms.Padding(3);
            this.MainWindow.Size = new System.Drawing.Size(882, 407);
            this.MainWindow.TabIndex = 0;
            this.MainWindow.Text = "Główne okno";
            this.MainWindow.UseVisualStyleBackColor = true;
            // 
            // DebugBox
            // 
            this.DebugBox.Location = new System.Drawing.Point(617, 6);
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.ReadOnly = true;
            this.DebugBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugBox.Size = new System.Drawing.Size(254, 97);
            this.DebugBox.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DataGrid);
            this.groupBox4.Location = new System.Drawing.Point(8, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(866, 292);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Value});
            this.DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(3, 16);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.Size = new System.Drawing.Size(860, 273);
            this.DataGrid.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Wartość";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.ChangeBTN);
            this.groupBox3.Controls.Add(this.WartoscValue);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.RegValue);
            this.groupBox3.Controls.Add(this.Rejestr);
            this.groupBox3.Location = new System.Drawing.Point(280, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 116);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zmianna";
            // 
            // ChangeBTN
            // 
            this.ChangeBTN.Location = new System.Drawing.Point(249, 74);
            this.ChangeBTN.Name = "ChangeBTN";
            this.ChangeBTN.Size = new System.Drawing.Size(75, 23);
            this.ChangeBTN.TabIndex = 11;
            this.ChangeBTN.Text = "Zmień";
            this.ChangeBTN.UseVisualStyleBackColor = true;
            this.ChangeBTN.Click += new System.EventHandler(this.ChangeBTN_Click);
            // 
            // WartoscValue
            // 
            this.WartoscValue.Location = new System.Drawing.Point(68, 48);
            this.WartoscValue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.WartoscValue.Name = "WartoscValue";
            this.WartoscValue.Size = new System.Drawing.Size(256, 20);
            this.WartoscValue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wartość";
            // 
            // RegValue
            // 
            this.RegValue.Location = new System.Drawing.Point(68, 17);
            this.RegValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.RegValue.Name = "RegValue";
            this.RegValue.Size = new System.Drawing.Size(256, 20);
            this.RegValue.TabIndex = 8;
            // 
            // Rejestr
            // 
            this.Rejestr.AutoSize = true;
            this.Rejestr.Location = new System.Drawing.Point(6, 19);
            this.Rejestr.Name = "Rejestr";
            this.Rejestr.Size = new System.Drawing.Size(34, 13);
            this.Rejestr.TabIndex = 8;
            this.Rejestr.Text = "Adres";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Function);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LengthRead);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Adres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Device);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia ModBus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Funkcje:";
            // 
            // Function
            // 
            this.Function.FormattingEnabled = true;
            this.Function.Items.AddRange(new object[] {
            "Coil",
            "Input",
            "Holding Register",
            "Internal Register"});
            this.Function.Location = new System.Drawing.Point(113, 32);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(147, 21);
            this.Function.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wielkość odczytu";
            // 
            // LengthRead
            // 
            this.LengthRead.Location = new System.Drawing.Point(207, 72);
            this.LengthRead.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LengthRead.Name = "LengthRead";
            this.LengthRead.Size = new System.Drawing.Size(53, 20);
            this.LengthRead.TabIndex = 4;
            this.LengthRead.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adres";
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(53, 72);
            this.Adres.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(51, 20);
            this.Adres.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device";
            // 
            // Device
            // 
            this.Device.Location = new System.Drawing.Point(53, 33);
            this.Device.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Device.Name = "Device";
            this.Device.Size = new System.Drawing.Size(51, 20);
            this.Device.TabIndex = 0;
            this.Device.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ConnectionWindow
            // 
            this.ConnectionWindow.Controls.Add(this.Disconnect);
            this.ConnectionWindow.Controls.Add(this.groupBox7);
            this.ConnectionWindow.Controls.Add(this.Connect);
            this.ConnectionWindow.Controls.Add(this.TCPSelect);
            this.ConnectionWindow.Controls.Add(this.SelectTypeModbus);
            this.ConnectionWindow.Controls.Add(this.RTUSelect);
            this.ConnectionWindow.Controls.Add(this.groupBox6);
            this.ConnectionWindow.Controls.Add(this.groupBox5);
            this.ConnectionWindow.Location = new System.Drawing.Point(4, 22);
            this.ConnectionWindow.Name = "ConnectionWindow";
            this.ConnectionWindow.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionWindow.Size = new System.Drawing.Size(882, 407);
            this.ConnectionWindow.TabIndex = 1;
            this.ConnectionWindow.Text = "Połaczenie";
            this.ConnectionWindow.UseVisualStyleBackColor = true;
            // 
            // Disconnect
            // 
            this.Disconnect.Enabled = false;
            this.Disconnect.Location = new System.Drawing.Point(718, 381);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 9;
            this.Disconnect.Text = "Rozłącz";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_BTNClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.TimeRefresh);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.Timeout);
            this.groupBox7.Location = new System.Drawing.Point(11, 192);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(863, 186);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Globalne";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Czas odświerzania:";
            // 
            // TimeRefresh
            // 
            this.TimeRefresh.Location = new System.Drawing.Point(120, 45);
            this.TimeRefresh.Name = "TimeRefresh";
            this.TimeRefresh.Size = new System.Drawing.Size(120, 20);
            this.TimeRefresh.TabIndex = 6;
            this.TimeRefresh.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Timeout:";
            // 
            // Timeout
            // 
            this.Timeout.Location = new System.Drawing.Point(70, 19);
            this.Timeout.Name = "Timeout";
            this.Timeout.Size = new System.Drawing.Size(120, 20);
            this.Timeout.TabIndex = 4;
            this.Timeout.Text = "1000";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(799, 381);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Połącz";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_BTNClick);
            // 
            // TCPSelect
            // 
            this.TCPSelect.AutoSize = true;
            this.TCPSelect.Location = new System.Drawing.Point(176, 11);
            this.TCPSelect.Name = "TCPSelect";
            this.TCPSelect.Size = new System.Drawing.Size(46, 17);
            this.TCPSelect.TabIndex = 4;
            this.TCPSelect.Text = "TCP";
            this.TCPSelect.UseVisualStyleBackColor = true;
            this.TCPSelect.CheckedChanged += new System.EventHandler(this.TCPSelect_CheckedChanged);
            // 
            // SelectTypeModbus
            // 
            this.SelectTypeModbus.AutoSize = true;
            this.SelectTypeModbus.Location = new System.Drawing.Point(8, 11);
            this.SelectTypeModbus.Name = "SelectTypeModbus";
            this.SelectTypeModbus.Size = new System.Drawing.Size(108, 13);
            this.SelectTypeModbus.TabIndex = 3;
            this.SelectTypeModbus.Text = "Sposób podłączenia:";
            // 
            // RTUSelect
            // 
            this.RTUSelect.Location = new System.Drawing.Point(122, 11);
            this.RTUSelect.Name = "RTUSelect";
            this.RTUSelect.Size = new System.Drawing.Size(48, 17);
            this.RTUSelect.TabIndex = 2;
            this.RTUSelect.Text = "RTU";
            this.RTUSelect.UseVisualStyleBackColor = true;
            this.RTUSelect.CheckedChanged += new System.EventHandler(this.RTUSelect_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.TCPPort);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.TCPIP);
            this.groupBox6.Location = new System.Drawing.Point(437, 34);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(437, 152);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TCP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Port:";
            // 
            // TCPPort
            // 
            this.TCPPort.Enabled = false;
            this.TCPPort.Location = new System.Drawing.Point(59, 45);
            this.TCPPort.Name = "TCPPort";
            this.TCPPort.Size = new System.Drawing.Size(120, 20);
            this.TCPPort.TabIndex = 2;
            this.TCPPort.Text = "502";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "IP:";
            // 
            // TCPIP
            // 
            this.TCPIP.Enabled = false;
            this.TCPIP.Location = new System.Drawing.Point(59, 19);
            this.TCPIP.Name = "TCPIP";
            this.TCPIP.Size = new System.Drawing.Size(120, 20);
            this.TCPIP.TabIndex = 0;
            this.TCPIP.Text = "127.0.0.1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RefreshComs);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.comboBoxBaudRate);
            this.groupBox5.Controls.Add(this.comboBoxParity);
            this.groupBox5.Controls.Add(this.comboBoxStopbits);
            this.groupBox5.Controls.Add(this.comboBoxPorty);
            this.groupBox5.Location = new System.Drawing.Point(8, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(423, 152);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RTU";
            // 
            // RefreshComs
            // 
            this.RefreshComs.Location = new System.Drawing.Point(208, 32);
            this.RefreshComs.Name = "RefreshComs";
            this.RefreshComs.Size = new System.Drawing.Size(75, 23);
            this.RefreshComs.TabIndex = 9;
            this.RefreshComs.Text = "Odswież";
            this.RefreshComs.UseVisualStyleBackColor = true;
            this.RefreshComs.Click += new System.EventHandler(this.RefreshComs_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Stop bit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Parity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "BaudRate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Port COM:";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Enabled = false;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "19200",
            "9600",
            "4800",
            "2400",
            "1200",
            "300",
            "110",
            "75"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(81, 59);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 3;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Enabled = false;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(81, 86);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParity.TabIndex = 2;
            // 
            // comboBoxStopbits
            // 
            this.comboBoxStopbits.Enabled = false;
            this.comboBoxStopbits.FormattingEnabled = true;
            this.comboBoxStopbits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.comboBoxStopbits.Location = new System.Drawing.Point(81, 113);
            this.comboBoxStopbits.Name = "comboBoxStopbits";
            this.comboBoxStopbits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStopbits.TabIndex = 1;
            // 
            // comboBoxPorty
            // 
            this.comboBoxPorty.Enabled = false;
            this.comboBoxPorty.FormattingEnabled = true;
            this.comboBoxPorty.Location = new System.Drawing.Point(81, 32);
            this.comboBoxPorty.Name = "comboBoxPorty";
            this.comboBoxPorty.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorty.Sorted = true;
            this.comboBoxPorty.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 480);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Modbus Master by K.W";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.MainWindow.ResumeLayout(false);
            this.MainWindow.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WartoscValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Device)).EndInit();
            this.ConnectionWindow.ResumeLayout(false);
            this.ConnectionWindow.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PlikiToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SavetoFileMenuStrip;
        private System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel TextConnect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainWindow;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ChangeBTN;
        private System.Windows.Forms.NumericUpDown WartoscValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown RegValue;
        private System.Windows.Forms.Label Rejestr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Function;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown LengthRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Device;
        private System.Windows.Forms.TabPage ConnectionWindow;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.RadioButton TCPSelect;
        private System.Windows.Forms.Label SelectTypeModbus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TCPPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TCPIP;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TimeRefresh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Timeout;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxStopbits;
        private System.Windows.Forms.ComboBox comboBoxPorty;
        private System.Windows.Forms.Button RefreshComs;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.RadioButton RTUSelect;
        private System.Windows.Forms.TextBox DebugBox;
        private System.Windows.Forms.ToolStripMenuItem połaczenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polaczMenuClick;
        private System.Windows.Forms.ToolStripMenuItem rozlaczMenuClick;
    }
}

