namespace Utoolity.UserControls
{
    partial class ucNetwork
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBlank = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBlank = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.rdoNetStat = new System.Windows.Forms.RadioButton();
            this.rdoNameServ = new System.Windows.Forms.RadioButton();
            this.rdoARP = new System.Windows.Forms.RadioButton();
            this.rdoTracert = new System.Windows.Forms.RadioButton();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.rdoPing = new System.Windows.Forms.RadioButton();
            this.rdoIPConfig = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBlank
            // 
            this.txtBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlank.Location = new System.Drawing.Point(41, 318);
            this.txtBlank.Name = "txtBlank";
            this.txtBlank.Size = new System.Drawing.Size(303, 26);
            this.txtBlank.TabIndex = 7;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(41, 24);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(389, 216);
            this.txtOutput.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(-16, 321);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "label3";
            this.lblStatus.Visible = false;
            // 
            // btnBlank
            // 
            this.btnBlank.AutoSize = true;
            this.btnBlank.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlank.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBlank.Location = new System.Drawing.Point(350, 316);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Size = new System.Drawing.Size(80, 30);
            this.btnBlank.TabIndex = 6;
            this.btnBlank.Text = "IPConfig";
            this.btnBlank.UseVisualStyleBackColor = true;
            this.btnBlank.Click += new System.EventHandler(this.btnBlank_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.BackColor = System.Drawing.Color.DarkGray;
            this.grpOptions.Controls.Add(this.rdoNetStat);
            this.grpOptions.Controls.Add(this.rdoNameServ);
            this.grpOptions.Controls.Add(this.rdoARP);
            this.grpOptions.Controls.Add(this.rdoTracert);
            this.grpOptions.Controls.Add(this.chkAll);
            this.grpOptions.Controls.Add(this.rdoPing);
            this.grpOptions.Controls.Add(this.rdoIPConfig);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOptions.Location = new System.Drawing.Point(468, 0);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(112, 437);
            this.grpOptions.TabIndex = 9;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "OPTIONS";
            // 
            // rdoNetStat
            // 
            this.rdoNetStat.AutoSize = true;
            this.rdoNetStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNetStat.Location = new System.Drawing.Point(6, 185);
            this.rdoNetStat.Name = "rdoNetStat";
            this.rdoNetStat.Size = new System.Drawing.Size(75, 22);
            this.rdoNetStat.TabIndex = 14;
            this.rdoNetStat.Text = "NetStat";
            this.rdoNetStat.UseVisualStyleBackColor = true;
            this.rdoNetStat.CheckedChanged += new System.EventHandler(this.rdoNetStat_CheckedChanged);
            // 
            // rdoNameServ
            // 
            this.rdoNameServ.AutoSize = true;
            this.rdoNameServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNameServ.Location = new System.Drawing.Point(5, 157);
            this.rdoNameServ.Name = "rdoNameServ";
            this.rdoNameServ.Size = new System.Drawing.Size(100, 22);
            this.rdoNameServ.TabIndex = 13;
            this.rdoNameServ.Text = "NSLookUp";
            this.rdoNameServ.UseVisualStyleBackColor = true;
            this.rdoNameServ.CheckedChanged += new System.EventHandler(this.rdoNameServ_CheckedChanged);
            // 
            // rdoARP
            // 
            this.rdoARP.AutoSize = true;
            this.rdoARP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoARP.Location = new System.Drawing.Point(6, 129);
            this.rdoARP.Name = "rdoARP";
            this.rdoARP.Size = new System.Drawing.Size(56, 22);
            this.rdoARP.TabIndex = 12;
            this.rdoARP.Text = "ARP";
            this.rdoARP.UseVisualStyleBackColor = true;
            this.rdoARP.CheckedChanged += new System.EventHandler(this.rdoARP_CheckedChanged);
            // 
            // rdoTracert
            // 
            this.rdoTracert.AutoSize = true;
            this.rdoTracert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTracert.Location = new System.Drawing.Point(6, 101);
            this.rdoTracert.Name = "rdoTracert";
            this.rdoTracert.Size = new System.Drawing.Size(73, 22);
            this.rdoTracert.TabIndex = 11;
            this.rdoTracert.Text = "Tracert";
            this.rdoTracert.UseVisualStyleBackColor = true;
            this.rdoTracert.CheckedChanged += new System.EventHandler(this.rdoTracert_CheckedChanged);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.Location = new System.Drawing.Point(19, 50);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(45, 22);
            this.chkAll.TabIndex = 10;
            this.chkAll.Text = "/all";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // rdoPing
            // 
            this.rdoPing.AutoSize = true;
            this.rdoPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPing.Location = new System.Drawing.Point(6, 73);
            this.rdoPing.Name = "rdoPing";
            this.rdoPing.Size = new System.Drawing.Size(55, 22);
            this.rdoPing.TabIndex = 1;
            this.rdoPing.Text = "Ping";
            this.rdoPing.UseVisualStyleBackColor = true;
            this.rdoPing.CheckedChanged += new System.EventHandler(this.rdoPing_CheckedChanged);
            // 
            // rdoIPConfig
            // 
            this.rdoIPConfig.AutoSize = true;
            this.rdoIPConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdoIPConfig.Checked = true;
            this.rdoIPConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIPConfig.Location = new System.Drawing.Point(6, 24);
            this.rdoIPConfig.Name = "rdoIPConfig";
            this.rdoIPConfig.Size = new System.Drawing.Size(82, 22);
            this.rdoIPConfig.TabIndex = 0;
            this.rdoIPConfig.TabStop = true;
            this.rdoIPConfig.Text = "IPConfig";
            this.rdoIPConfig.UseVisualStyleBackColor = true;
            this.rdoIPConfig.CheckedChanged += new System.EventHandler(this.rdoIPConfig_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExport.Location = new System.Drawing.Point(41, 246);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(65, 30);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(288, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(205, 246);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(225, 18);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Visible = false;
            // 
            // ucNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtBlank);
            this.Controls.Add(this.btnBlank);
            this.Controls.Add(this.txtOutput);
            this.Name = "ucNetwork";
            this.Size = new System.Drawing.Size(580, 437);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBlank;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rdoIPConfig;
        private System.Windows.Forms.RadioButton rdoPing;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdoTracert;
        private System.Windows.Forms.RadioButton rdoARP;
        private System.Windows.Forms.RadioButton rdoNameServ;
        private System.Windows.Forms.RadioButton rdoNetStat;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
