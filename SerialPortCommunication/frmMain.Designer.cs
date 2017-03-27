namespace PCComm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cboData = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoHex = new System.Windows.Forms.RadioButton();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.chkBoxEOL = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cycleLable = new System.Windows.Forms.Label();
            this.cycle = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AnnealDuration = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.AnnealTemprature = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ExtendDuration = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.ExtendTemprature = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnealDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnealTemprature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendTemprature)).BeginInit();
            this.SuspendLayout();
            // 
            // cboData
            // 
            this.cboData.FormattingEnabled = true;
            this.cboData.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cboData.Location = new System.Drawing.Point(9, 180);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(76, 20);
            this.cboData.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Stop Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data Bits";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(468, 312);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 21);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "Close Port";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoText);
            this.groupBox3.Controls.Add(this.rdoHex);
            this.groupBox3.Location = new System.Drawing.Point(574, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 55);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode";
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Location = new System.Drawing.Point(6, 35);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(47, 16);
            this.rdoText.TabIndex = 1;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Text";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoHex
            // 
            this.rdoHex.AutoSize = true;
            this.rdoHex.Location = new System.Drawing.Point(6, 15);
            this.rdoHex.Name = "rdoHex";
            this.rdoHex.Size = new System.Drawing.Size(41, 16);
            this.rdoHex.TabIndex = 0;
            this.rdoHex.TabStop = true;
            this.rdoHex.Text = "Hex";
            this.rdoHex.UseVisualStyleBackColor = true;
            this.rdoHex.CheckedChanged += new System.EventHandler(this.rdoHex_CheckedChanged);
            // 
            // cboStop
            // 
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(9, 143);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(76, 20);
            this.cboStop.TabIndex = 13;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cmdSend);
            this.GroupBox1.Controls.Add(this.txtSend);
            this.GroupBox1.Controls.Add(this.rtbDisplay);
            this.GroupBox1.Location = new System.Drawing.Point(12, 41);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(556, 266);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Serial Port Communication";
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(475, 239);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(75, 21);
            this.cmdSend.TabIndex = 5;
            this.cmdSend.Text = "Send";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Enabled = false;
            this.txtSend.Location = new System.Drawing.Point(7, 239);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(454, 21);
            this.txtSend.TabIndex = 4;
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(7, 18);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(543, 216);
            this.rtbDisplay.TabIndex = 3;
            this.rtbDisplay.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboData);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboStop);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboParity);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.cboBaud);
            this.groupBox2.Controls.Add(this.cboPort);
            this.groupBox2.Location = new System.Drawing.Point(578, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 204);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Baud Rate";
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(9, 105);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(76, 20);
            this.cboParity.TabIndex = 12;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 12);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Port";
            // 
            // cboBaud
            // 
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000",
            "115200"});
            this.cboBaud.Location = new System.Drawing.Point(9, 68);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(76, 20);
            this.cboBaud.TabIndex = 11;
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(9, 31);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(76, 20);
            this.cboPort.TabIndex = 10;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(580, 312);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(100, 21);
            this.cmdOpen.TabIndex = 8;
            this.cmdOpen.Text = "Open Port";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // chkBoxEOL
            // 
            this.chkBoxEOL.AutoSize = true;
            this.chkBoxEOL.Checked = true;
            this.chkBoxEOL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxEOL.Location = new System.Drawing.Point(21, 314);
            this.chkBoxEOL.Name = "chkBoxEOL";
            this.chkBoxEOL.Size = new System.Drawing.Size(66, 16);
            this.chkBoxEOL.TabIndex = 9;
            this.chkBoxEOL.Text = "Add EOL";
            this.chkBoxEOL.UseVisualStyleBackColor = true;
            this.chkBoxEOL.CheckedChanged += new System.EventHandler(this.chkBoxEOL_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cycleLable
            // 
            this.cycleLable.AutoSize = true;
            this.cycleLable.Location = new System.Drawing.Point(370, 382);
            this.cycleLable.Name = "cycleLable";
            this.cycleLable.Size = new System.Drawing.Size(41, 12);
            this.cycleLable.TabIndex = 11;
            this.cycleLable.Text = "周期：";
            this.cycleLable.Click += new System.EventHandler(this.label6_Click);
            // 
            // cycle
            // 
            this.cycle.Location = new System.Drawing.Point(428, 380);
            this.cycle.Name = "cycle";
            this.cycle.Size = new System.Drawing.Size(120, 21);
            this.cycle.TabIndex = 12;
            this.cycle.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "次";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "低温退火";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AnnealDuration
            // 
            this.AnnealDuration.Location = new System.Drawing.Point(465, 472);
            this.AnnealDuration.Name = "AnnealDuration";
            this.AnnealDuration.Size = new System.Drawing.Size(120, 21);
            this.AnnealDuration.TabIndex = 15;
            this.AnnealDuration.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "温度";
            // 
            // AnnealTemprature
            // 
            this.AnnealTemprature.Location = new System.Drawing.Point(268, 473);
            this.AnnealTemprature.Name = "AnnealTemprature";
            this.AnnealTemprature.Size = new System.Drawing.Size(120, 21);
            this.AnnealTemprature.TabIndex = 17;
            this.AnnealTemprature.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "时间";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "高温变性";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(465, 445);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "温度";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(268, 447);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown2.TabIndex = 17;
            this.numericUpDown2.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "时间";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 14;
            this.label13.Click += new System.EventHandler(this.label7_Click);
            // 
            // ExtendDuration
            // 
            this.ExtendDuration.Location = new System.Drawing.Point(465, 502);
            this.ExtendDuration.Name = "ExtendDuration";
            this.ExtendDuration.Size = new System.Drawing.Size(120, 21);
            this.ExtendDuration.TabIndex = 15;
            this.ExtendDuration.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ExtendDuration.ValueChanged += new System.EventHandler(this.ExtendDuration_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(215, 504);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 16;
            this.label14.Text = "温度";
            // 
            // ExtendTemprature
            // 
            this.ExtendTemprature.Location = new System.Drawing.Point(268, 500);
            this.ExtendTemprature.Name = "ExtendTemprature";
            this.ExtendTemprature.Size = new System.Drawing.Size(120, 21);
            this.ExtendTemprature.TabIndex = 17;
            this.ExtendTemprature.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(412, 504);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 18;
            this.label15.Text = "时间";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(138, 502);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "适温延伸";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(40, 353);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 20;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(40, 408);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 21;
            this.stop.Text = "结束";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(40, 469);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 22;
            this.test.Text = "测试";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 607);
            this.Controls.Add(this.test);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExtendTemprature);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.AnnealTemprature);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExtendDuration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AnnealDuration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cycle);
            this.Controls.Add(this.cycleLable);
            this.Controls.Add(this.chkBoxEOL);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communication Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnealDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnealTemprature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendTemprature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoHex;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.CheckBox chkBoxEOL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label cycleLable;
        private System.Windows.Forms.NumericUpDown cycle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown AnnealDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown AnnealTemprature;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown ExtendDuration;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown ExtendTemprature;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button test;
    }
}