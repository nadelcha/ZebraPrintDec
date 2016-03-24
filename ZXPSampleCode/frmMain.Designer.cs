namespace ZXPSampleCode
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
            this.gbSamples = new System.Windows.Forms.GroupBox();
            this.lblDest = new System.Windows.Forms.Label();
            this.lblSrc = new System.Windows.Forms.Label();
            this.cboDest = new System.Windows.Forms.ComboBox();
            this.cboSrc = new System.Windows.Forms.ComboBox();
            this.lbSamples = new System.Windows.Forms.ListBox();
            this.gbMsg = new System.Windows.Forms.GroupBox();
            this.tbDescr = new System.Windows.Forms.TextBox();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.lbJobStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.gbPrinters = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEthernet = new System.Windows.Forms.RadioButton();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.btnLocatePrinters = new System.Windows.Forms.Button();
            this.btnConnectToPrinter = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.cboPrn = new System.Windows.Forms.ComboBox();
            this.lblVersions = new System.Windows.Forms.Label();
            this.snEnd = new System.Windows.Forms.NumericUpDown();
            this.snStart = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.snDigits = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.snPrevStart = new System.Windows.Forms.Label();
            this.snPrevEnd = new System.Windows.Forms.Label();
            this.gbSamples.SuspendLayout();
            this.gbMsg.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.gbPrinters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snStart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snDigits)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSamples
            // 
            this.gbSamples.Controls.Add(this.lblDest);
            this.gbSamples.Controls.Add(this.lblSrc);
            this.gbSamples.Controls.Add(this.cboDest);
            this.gbSamples.Controls.Add(this.cboSrc);
            this.gbSamples.Controls.Add(this.lbSamples);
            this.gbSamples.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSamples.Location = new System.Drawing.Point(8, 172);
            this.gbSamples.Name = "gbSamples";
            this.gbSamples.Size = new System.Drawing.Size(270, 272);
            this.gbSamples.TabIndex = 1;
            this.gbSamples.TabStop = false;
            this.gbSamples.Text = "Samples:";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(10, 240);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(92, 16);
            this.lblDest.TabIndex = 12;
            this.lblDest.Text = "Destination:";
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.Location = new System.Drawing.Point(10, 205);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(62, 16);
            this.lblSrc.TabIndex = 11;
            this.lblSrc.Text = "Source:";
            // 
            // cboDest
            // 
            this.cboDest.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDest.FormattingEnabled = true;
            this.cboDest.Items.AddRange(new object[] {
            "Output Bin",
            "Reject Bin",
            "Hold",
            "Feeder"});
            this.cboDest.Location = new System.Drawing.Point(120, 237);
            this.cboDest.Name = "cboDest";
            this.cboDest.Size = new System.Drawing.Size(121, 24);
            this.cboDest.TabIndex = 2;
            // 
            // cboSrc
            // 
            this.cboSrc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSrc.FormattingEnabled = true;
            this.cboSrc.Items.AddRange(new object[] {
            "ATM Slot",
            "Feeder",
            "Internal"});
            this.cboSrc.Location = new System.Drawing.Point(120, 202);
            this.cboSrc.Name = "cboSrc";
            this.cboSrc.Size = new System.Drawing.Size(121, 24);
            this.cboSrc.TabIndex = 1;
            // 
            // lbSamples
            // 
            this.lbSamples.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSamples.FormattingEnabled = true;
            this.lbSamples.ItemHeight = 16;
            this.lbSamples.Location = new System.Drawing.Point(10, 25);
            this.lbSamples.Name = "lbSamples";
            this.lbSamples.Size = new System.Drawing.Size(250, 164);
            this.lbSamples.TabIndex = 0;
            this.lbSamples.SelectedIndexChanged += new System.EventHandler(this.lbSamples_SelectedIndexChanged);
            // 
            // gbMsg
            // 
            this.gbMsg.Controls.Add(this.tbDescr);
            this.gbMsg.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMsg.Location = new System.Drawing.Point(288, 172);
            this.gbMsg.Name = "gbMsg";
            this.gbMsg.Size = new System.Drawing.Size(445, 272);
            this.gbMsg.TabIndex = 2;
            this.gbMsg.TabStop = false;
            this.gbMsg.Text = "Description:";
            // 
            // tbDescr
            // 
            this.tbDescr.BackColor = System.Drawing.SystemColors.Control;
            this.tbDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescr.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescr.Location = new System.Drawing.Point(10, 25);
            this.tbDescr.Multiline = true;
            this.tbDescr.Name = "tbDescr";
            this.tbDescr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescr.Size = new System.Drawing.Size(425, 234);
            this.tbDescr.TabIndex = 0;
            this.tbDescr.TabStop = false;
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.lbJobStatus);
            this.gbButtons.Controls.Add(this.btnExit);
            this.gbButtons.Controls.Add(this.btnRun);
            this.gbButtons.Location = new System.Drawing.Point(8, 531);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(725, 49);
            this.gbButtons.TabIndex = 3;
            this.gbButtons.TabStop = false;
            // 
            // lbJobStatus
            // 
            this.lbJobStatus.AutoSize = true;
            this.lbJobStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobStatus.Location = new System.Drawing.Point(12, 19);
            this.lbJobStatus.Name = "lbJobStatus";
            this.lbJobStatus.Size = new System.Drawing.Size(157, 16);
            this.lbJobStatus.TabIndex = 18;
            this.lbJobStatus.Text = "Searching for Printers";
            this.lbJobStatus.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(655, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRun.Location = new System.Drawing.Point(582, 15);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(60, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // gbPrinters
            // 
            this.gbPrinters.Controls.Add(this.groupBox1);
            this.gbPrinters.Controls.Add(this.btnConnectToPrinter);
            this.gbPrinters.Controls.Add(this.lbStatus);
            this.gbPrinters.Controls.Add(this.label2);
            this.gbPrinters.Controls.Add(this.label1);
            this.gbPrinters.Controls.Add(this.cboCardType);
            this.gbPrinters.Controls.Add(this.cboPrn);
            this.gbPrinters.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrinters.Location = new System.Drawing.Point(10, 21);
            this.gbPrinters.Name = "gbPrinters";
            this.gbPrinters.Size = new System.Drawing.Size(725, 133);
            this.gbPrinters.TabIndex = 0;
            this.gbPrinters.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEthernet);
            this.groupBox1.Controls.Add(this.rbUSB);
            this.groupBox1.Controls.Add(this.btnLocatePrinters);
            this.groupBox1.Location = new System.Drawing.Point(531, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discover Printers";
            // 
            // rbEthernet
            // 
            this.rbEthernet.AutoSize = true;
            this.rbEthernet.Checked = true;
            this.rbEthernet.Location = new System.Drawing.Point(25, 45);
            this.rbEthernet.Name = "rbEthernet";
            this.rbEthernet.Size = new System.Drawing.Size(79, 20);
            this.rbEthernet.TabIndex = 15;
            this.rbEthernet.TabStop = true;
            this.rbEthernet.Text = "Ethernet";
            this.rbEthernet.UseVisualStyleBackColor = true;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Location = new System.Drawing.Point(25, 21);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(57, 20);
            this.rbUSB.TabIndex = 14;
            this.rbUSB.Text = "USB ";
            this.rbUSB.UseVisualStyleBackColor = true;
            // 
            // btnLocatePrinters
            // 
            this.btnLocatePrinters.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocatePrinters.ForeColor = System.Drawing.Color.Black;
            this.btnLocatePrinters.Location = new System.Drawing.Point(25, 71);
            this.btnLocatePrinters.Name = "btnLocatePrinters";
            this.btnLocatePrinters.Size = new System.Drawing.Size(142, 23);
            this.btnLocatePrinters.TabIndex = 16;
            this.btnLocatePrinters.Text = "Locate Printers";
            this.btnLocatePrinters.UseVisualStyleBackColor = true;
            this.btnLocatePrinters.Click += new System.EventHandler(this.btnLocatePrinters_Click);
            // 
            // btnConnectToPrinter
            // 
            this.btnConnectToPrinter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectToPrinter.ForeColor = System.Drawing.Color.Black;
            this.btnConnectToPrinter.Location = new System.Drawing.Point(367, 23);
            this.btnConnectToPrinter.Name = "btnConnectToPrinter";
            this.btnConnectToPrinter.Size = new System.Drawing.Size(142, 23);
            this.btnConnectToPrinter.TabIndex = 18;
            this.btnConnectToPrinter.Text = "Connect to Printer";
            this.btnConnectToPrinter.UseVisualStyleBackColor = true;
            this.btnConnectToPrinter.Click += new System.EventHandler(this.btnConnectToPrinter_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(97, 101);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(147, 16);
            this.lbStatus.TabIndex = 17;
            this.lbStatus.Text = "Searching for Printers";
            this.lbStatus.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Card Types:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Printer:";
            // 
            // cboCardType
            // 
            this.cboCardType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCardType.Location = new System.Drawing.Point(100, 55);
            this.cboCardType.Name = "cboCardType";
            this.cboCardType.Size = new System.Drawing.Size(250, 24);
            this.cboCardType.TabIndex = 1;
            // 
            // cboPrn
            // 
            this.cboPrn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrn.Location = new System.Drawing.Point(100, 20);
            this.cboPrn.Name = "cboPrn";
            this.cboPrn.Size = new System.Drawing.Size(250, 24);
            this.cboPrn.TabIndex = 0;
            // 
            // lblVersions
            // 
            this.lblVersions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersions.ForeColor = System.Drawing.Color.Navy;
            this.lblVersions.Location = new System.Drawing.Point(233, 4);
            this.lblVersions.Name = "lblVersions";
            this.lblVersions.Size = new System.Drawing.Size(500, 16);
            this.lblVersions.TabIndex = 5;
            this.lblVersions.Text = "lblVersions";
            this.lblVersions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // snEnd
            // 
            this.snEnd.Location = new System.Drawing.Point(252, 45);
            this.snEnd.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.snEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.snEnd.Name = "snEnd";
            this.snEnd.Size = new System.Drawing.Size(77, 20);
            this.snEnd.TabIndex = 6;
            this.snEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.snEnd.ValueChanged += new System.EventHandler(this.snEnd_ValueChanged);
            // 
            // snStart
            // 
            this.snStart.Location = new System.Drawing.Point(252, 19);
            this.snStart.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.snStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.snStart.Name = "snStart";
            this.snStart.Size = new System.Drawing.Size(77, 20);
            this.snStart.TabIndex = 7;
            this.snStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.snStart.ValueChanged += new System.EventHandler(this.snStart_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serial End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serial Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Serial Prefix";
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(79, 18);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(100, 20);
            this.tbPrefix.TabIndex = 11;
            this.tbPrefix.Text = "SN-";
            this.tbPrefix.TextChanged += new System.EventHandler(this.tbPrefix_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.snPrevEnd);
            this.groupBox2.Controls.Add(this.snPrevStart);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.snDigits);
            this.groupBox2.Controls.Add(this.snStart);
            this.groupBox2.Controls.Add(this.tbPrefix);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.snEnd);
            this.groupBox2.Location = new System.Drawing.Point(8, 452);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 79);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Batch Print Settings";
            // 
            // snDigits
            // 
            this.snDigits.Location = new System.Drawing.Point(102, 45);
            this.snDigits.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.snDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.snDigits.Name = "snDigits";
            this.snDigits.Size = new System.Drawing.Size(77, 20);
            this.snDigits.TabIndex = 12;
            this.snDigits.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.snDigits.ValueChanged += new System.EventHandler(this.snDigits_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Number of Digits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Serial Start Preview:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Serial End Preview:";
            // 
            // snPrevStart
            // 
            this.snPrevStart.AutoSize = true;
            this.snPrevStart.Location = new System.Drawing.Point(488, 21);
            this.snPrevStart.Name = "snPrevStart";
            this.snPrevStart.Size = new System.Drawing.Size(49, 13);
            this.snPrevStart.TabIndex = 16;
            this.snPrevStart.Text = "SN-0001";
            // 
            // snPrevEnd
            // 
            this.snPrevEnd.AutoSize = true;
            this.snPrevEnd.Location = new System.Drawing.Point(488, 47);
            this.snPrevEnd.Name = "snPrevEnd";
            this.snPrevEnd.Size = new System.Drawing.Size(49, 13);
            this.snPrevEnd.TabIndex = 17;
            this.snPrevEnd.Text = "SN-0002";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 592);
            this.Controls.Add(this.lblVersions);
            this.Controls.Add(this.gbPrinters);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbMsg);
            this.Controls.Add(this.gbSamples);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZXP Sample Code 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.gbSamples.ResumeLayout(false);
            this.gbSamples.PerformLayout();
            this.gbMsg.ResumeLayout(false);
            this.gbMsg.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.gbButtons.PerformLayout();
            this.gbPrinters.ResumeLayout(false);
            this.gbPrinters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snStart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snDigits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSamples;
        private System.Windows.Forms.ListBox lbSamples;
        private System.Windows.Forms.GroupBox gbMsg;
        private System.Windows.Forms.TextBox tbDescr;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox gbPrinters;
        private System.Windows.Forms.ComboBox cboPrn;
        private System.Windows.Forms.Label lblVersions;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.ComboBox cboDest;
        private System.Windows.Forms.ComboBox cboSrc;
        private System.Windows.Forms.ComboBox cboCardType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEthernet;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.Button btnLocatePrinters;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnConnectToPrinter;
        private System.Windows.Forms.Label lbJobStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown snEnd;
        private System.Windows.Forms.NumericUpDown snStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label snPrevEnd;
        private System.Windows.Forms.Label snPrevStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown snDigits;
        private System.Windows.Forms.Label label6;
    }
}

