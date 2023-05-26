namespace Utoolity.UserControls
{
    partial class ucSystem
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
            this.btnSFC = new System.Windows.Forms.Button();
            this.lblNoDrives = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnDefrag = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lstDrives = new System.Windows.Forms.ListBox();
            this.btnSFCVerify = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFileShare = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSFC
            // 
            this.btnSFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSFC.Location = new System.Drawing.Point(76, 53);
            this.btnSFC.Name = "btnSFC";
            this.btnSFC.Size = new System.Drawing.Size(91, 50);
            this.btnSFC.TabIndex = 0;
            this.btnSFC.Text = "System File Check";
            this.btnSFC.UseVisualStyleBackColor = true;
            this.btnSFC.Click += new System.EventHandler(this.btnSFC_Click);
            // 
            // lblNoDrives
            // 
            this.lblNoDrives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoDrives.AutoSize = true;
            this.lblNoDrives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDrives.Location = new System.Drawing.Point(202, 17);
            this.lblNoDrives.Name = "lblNoDrives";
            this.lblNoDrives.Size = new System.Drawing.Size(104, 16);
            this.lblNoDrives.TabIndex = 11;
            this.lblNoDrives.Text = "Drives Detected";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(48, 248);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(474, 161);
            this.txtOutput.TabIndex = 12;
            // 
            // btnDefrag
            // 
            this.btnDefrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefrag.Location = new System.Drawing.Point(139, 144);
            this.btnDefrag.Name = "btnDefrag";
            this.btnDefrag.Size = new System.Drawing.Size(85, 44);
            this.btnDefrag.TabIndex = 13;
            this.btnDefrag.Text = "Disk Defrag";
            this.btnDefrag.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 222);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(474, 20);
            this.progressBar1.TabIndex = 14;
            // 
            // lstDrives
            // 
            this.lstDrives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDrives.FormattingEnabled = true;
            this.lstDrives.ItemHeight = 16;
            this.lstDrives.Location = new System.Drawing.Point(201, 39);
            this.lstDrives.Name = "lstDrives";
            this.lstDrives.Size = new System.Drawing.Size(181, 84);
            this.lstDrives.TabIndex = 15;
            this.lstDrives.SelectedIndexChanged += new System.EventHandler(this.lstDrives_SelectedIndexChanged);
            // 
            // btnSFCVerify
            // 
            this.btnSFCVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSFCVerify.Location = new System.Drawing.Point(48, 144);
            this.btnSFCVerify.Name = "btnSFCVerify";
            this.btnSFCVerify.Size = new System.Drawing.Size(85, 44);
            this.btnSFCVerify.TabIndex = 16;
            this.btnSFCVerify.Text = "Verify File";
            this.btnSFCVerify.UseVisualStyleBackColor = true;
            this.btnSFCVerify.Click += new System.EventHandler(this.btnSFCVerify_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(48, 194);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(406, 22);
            this.txtInput.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(460, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFileShare
            // 
            this.btnFileShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileShare.Location = new System.Drawing.Point(230, 144);
            this.btnFileShare.Name = "btnFileShare";
            this.btnFileShare.Size = new System.Drawing.Size(86, 44);
            this.btnFileShare.TabIndex = 19;
            this.btnFileShare.Text = "Folder Share";
            this.btnFileShare.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(322, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 44);
            this.button3.TabIndex = 20;
            this.button3.Text = "Map Net Drives";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(429, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "Backup Files";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ucSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFileShare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSFCVerify);
            this.Controls.Add(this.lstDrives);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDefrag);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblNoDrives);
            this.Controls.Add(this.btnSFC);
            this.Name = "ucSystem";
            this.Size = new System.Drawing.Size(580, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSFC;
        private System.Windows.Forms.Label lblNoDrives;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnDefrag;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox lstDrives;
        private System.Windows.Forms.Button btnSFCVerify;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFileShare;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
