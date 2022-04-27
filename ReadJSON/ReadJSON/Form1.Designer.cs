namespace ReadJSON
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
            this.textBoxRowCount = new System.Windows.Forms.TextBox();
            this.labXmlns = new System.Windows.Forms.Label();
            this.textBoxXmlns = new System.Windows.Forms.TextBox();
            this.labIdentifier = new System.Windows.Forms.Label();
            this.labSender = new System.Windows.Forms.Label();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.labSent = new System.Windows.Forms.Label();
            this.textBoxSent = new System.Windows.Forms.TextBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labMsgType = new System.Windows.Forms.Label();
            this.textBoxMsgType = new System.Windows.Forms.TextBox();
            this.labDataid = new System.Windows.Forms.Label();
            this.textBoxDataid = new System.Windows.Forms.TextBox();
            this.labScope = new System.Windows.Forms.Label();
            this.textBoxScope = new System.Windows.Forms.TextBox();
            this.labDataset = new System.Windows.Forms.Label();
            this.textBoxDataset = new System.Windows.Forms.TextBox();
            this.dgvWeather = new System.Windows.Forms.DataGridView();
            this.labRowCount = new System.Windows.Forms.Label();
            this.ofdWeather = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.cbbIdentifier = new System.Windows.Forms.ComboBox();
            this.cbxReadOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRowCount
            // 
            this.textBoxRowCount.Location = new System.Drawing.Point(567, 119);
            this.textBoxRowCount.Multiline = true;
            this.textBoxRowCount.Name = "textBoxRowCount";
            this.textBoxRowCount.Size = new System.Drawing.Size(303, 25);
            this.textBoxRowCount.TabIndex = 0;
            // 
            // labXmlns
            // 
            this.labXmlns.AutoSize = true;
            this.labXmlns.Location = new System.Drawing.Point(12, 9);
            this.labXmlns.Name = "labXmlns";
            this.labXmlns.Size = new System.Drawing.Size(41, 15);
            this.labXmlns.TabIndex = 1;
            this.labXmlns.Text = "xmlns";
            // 
            // textBoxXmlns
            // 
            this.textBoxXmlns.Location = new System.Drawing.Point(103, 6);
            this.textBoxXmlns.Name = "textBoxXmlns";
            this.textBoxXmlns.Size = new System.Drawing.Size(303, 25);
            this.textBoxXmlns.TabIndex = 2;
            // 
            // labIdentifier
            // 
            this.labIdentifier.AutoSize = true;
            this.labIdentifier.Location = new System.Drawing.Point(12, 38);
            this.labIdentifier.Name = "labIdentifier";
            this.labIdentifier.Size = new System.Drawing.Size(59, 15);
            this.labIdentifier.TabIndex = 3;
            this.labIdentifier.Text = "identifier";
            // 
            // labSender
            // 
            this.labSender.AutoSize = true;
            this.labSender.Location = new System.Drawing.Point(12, 66);
            this.labSender.Name = "labSender";
            this.labSender.Size = new System.Drawing.Size(43, 15);
            this.labSender.TabIndex = 5;
            this.labSender.Text = "sender";
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(103, 63);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(303, 25);
            this.textBoxSender.TabIndex = 6;
            // 
            // labSent
            // 
            this.labSent.AutoSize = true;
            this.labSent.Location = new System.Drawing.Point(12, 94);
            this.labSent.Name = "labSent";
            this.labSent.Size = new System.Drawing.Size(29, 15);
            this.labSent.TabIndex = 7;
            this.labSent.Text = "sent";
            // 
            // textBoxSent
            // 
            this.textBoxSent.Location = new System.Drawing.Point(103, 91);
            this.textBoxSent.Name = "textBoxSent";
            this.textBoxSent.Size = new System.Drawing.Size(303, 25);
            this.textBoxSent.TabIndex = 8;
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(12, 122);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(38, 15);
            this.labStatus.TabIndex = 9;
            this.labStatus.Text = "status";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(103, 119);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(303, 25);
            this.textBoxStatus.TabIndex = 10;
            // 
            // labMsgType
            // 
            this.labMsgType.AutoSize = true;
            this.labMsgType.Location = new System.Drawing.Point(458, 9);
            this.labMsgType.Name = "labMsgType";
            this.labMsgType.Size = new System.Drawing.Size(59, 15);
            this.labMsgType.TabIndex = 11;
            this.labMsgType.Text = "msgType";
            // 
            // textBoxMsgType
            // 
            this.textBoxMsgType.Location = new System.Drawing.Point(567, 6);
            this.textBoxMsgType.Name = "textBoxMsgType";
            this.textBoxMsgType.Size = new System.Drawing.Size(303, 25);
            this.textBoxMsgType.TabIndex = 12;
            // 
            // labDataid
            // 
            this.labDataid.AutoSize = true;
            this.labDataid.Location = new System.Drawing.Point(458, 38);
            this.labDataid.Name = "labDataid";
            this.labDataid.Size = new System.Drawing.Size(41, 15);
            this.labDataid.TabIndex = 13;
            this.labDataid.Text = "dataid";
            // 
            // textBoxDataid
            // 
            this.textBoxDataid.Location = new System.Drawing.Point(567, 35);
            this.textBoxDataid.Name = "textBoxDataid";
            this.textBoxDataid.Size = new System.Drawing.Size(303, 25);
            this.textBoxDataid.TabIndex = 14;
            // 
            // labScope
            // 
            this.labScope.AutoSize = true;
            this.labScope.Location = new System.Drawing.Point(458, 66);
            this.labScope.Name = "labScope";
            this.labScope.Size = new System.Drawing.Size(38, 15);
            this.labScope.TabIndex = 15;
            this.labScope.Text = "scope";
            // 
            // textBoxScope
            // 
            this.textBoxScope.Location = new System.Drawing.Point(567, 63);
            this.textBoxScope.Name = "textBoxScope";
            this.textBoxScope.Size = new System.Drawing.Size(303, 25);
            this.textBoxScope.TabIndex = 16;
            // 
            // labDataset
            // 
            this.labDataset.AutoSize = true;
            this.labDataset.Location = new System.Drawing.Point(458, 94);
            this.labDataset.Name = "labDataset";
            this.labDataset.Size = new System.Drawing.Size(45, 15);
            this.labDataset.TabIndex = 17;
            this.labDataset.Text = "dataset";
            // 
            // textBoxDataset
            // 
            this.textBoxDataset.Location = new System.Drawing.Point(567, 91);
            this.textBoxDataset.Name = "textBoxDataset";
            this.textBoxDataset.Size = new System.Drawing.Size(303, 25);
            this.textBoxDataset.TabIndex = 18;
            // 
            // dgvWeather
            // 
            this.dgvWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeather.Location = new System.Drawing.Point(15, 150);
            this.dgvWeather.Name = "dgvWeather";
            this.dgvWeather.RowTemplate.Height = 27;
            this.dgvWeather.Size = new System.Drawing.Size(1016, 351);
            this.dgvWeather.TabIndex = 19;
            // 
            // labRowCount
            // 
            this.labRowCount.AutoSize = true;
            this.labRowCount.Location = new System.Drawing.Point(458, 122);
            this.labRowCount.Name = "labRowCount";
            this.labRowCount.Size = new System.Drawing.Size(71, 15);
            this.labRowCount.TabIndex = 20;
            this.labRowCount.Text = "Row Count";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(913, 6);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(118, 25);
            this.btnOpenFile.TabIndex = 21;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cbbIdentifier
            // 
            this.cbbIdentifier.FormattingEnabled = true;
            this.cbbIdentifier.Location = new System.Drawing.Point(103, 35);
            this.cbbIdentifier.Name = "cbbIdentifier";
            this.cbbIdentifier.Size = new System.Drawing.Size(303, 23);
            this.cbbIdentifier.TabIndex = 22;
            this.cbbIdentifier.SelectedIndexChanged += new System.EventHandler(this.cbbIdentifier_SelectedIndexChanged);
            // 
            // cbxReadOnly
            // 
            this.cbxReadOnly.AutoSize = true;
            this.cbxReadOnly.Checked = true;
            this.cbxReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxReadOnly.Location = new System.Drawing.Point(913, 121);
            this.cbxReadOnly.Name = "cbxReadOnly";
            this.cbxReadOnly.Size = new System.Drawing.Size(89, 19);
            this.cbxReadOnly.TabIndex = 23;
            this.cbxReadOnly.Text = "Read Only";
            this.cbxReadOnly.UseVisualStyleBackColor = true;
            this.cbxReadOnly.CheckedChanged += new System.EventHandler(this.cbxReadOnly_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 513);
            this.Controls.Add(this.cbxReadOnly);
            this.Controls.Add(this.cbbIdentifier);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.labRowCount);
            this.Controls.Add(this.dgvWeather);
            this.Controls.Add(this.textBoxDataset);
            this.Controls.Add(this.labDataset);
            this.Controls.Add(this.textBoxScope);
            this.Controls.Add(this.labScope);
            this.Controls.Add(this.textBoxDataid);
            this.Controls.Add(this.labDataid);
            this.Controls.Add(this.textBoxMsgType);
            this.Controls.Add(this.labMsgType);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.textBoxSent);
            this.Controls.Add(this.labSent);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.labSender);
            this.Controls.Add(this.labIdentifier);
            this.Controls.Add(this.textBoxXmlns);
            this.Controls.Add(this.labXmlns);
            this.Controls.Add(this.textBoxRowCount);
            this.Name = "Form1";
            this.Text = "「https://opendata.cwb.gov.tw/dataset/observation/O-A0001-001」JSON 剖析程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRowCount;
        private System.Windows.Forms.Label labXmlns;
        private System.Windows.Forms.TextBox textBoxXmlns;
        private System.Windows.Forms.Label labIdentifier;
        private System.Windows.Forms.Label labSender;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.Label labSent;
        private System.Windows.Forms.TextBox textBoxSent;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labMsgType;
        private System.Windows.Forms.TextBox textBoxMsgType;
        private System.Windows.Forms.Label labDataid;
        private System.Windows.Forms.TextBox textBoxDataid;
        private System.Windows.Forms.Label labScope;
        private System.Windows.Forms.TextBox textBoxScope;
        private System.Windows.Forms.Label labDataset;
        private System.Windows.Forms.TextBox textBoxDataset;
        private System.Windows.Forms.DataGridView dgvWeather;
        private System.Windows.Forms.Label labRowCount;
        private System.Windows.Forms.OpenFileDialog ofdWeather;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.ComboBox cbbIdentifier;
        private System.Windows.Forms.CheckBox cbxReadOnly;
    }
}

