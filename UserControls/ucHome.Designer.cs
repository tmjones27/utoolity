namespace Utoolity.UserControls
{
    partial class ucHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPCName = new System.Windows.Forms.TextBox();
            this.txtIPAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameOS = new System.Windows.Forms.TextBox();
            this.lblNameOS = new System.Windows.Forms.Label();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.txtDriveNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC Name:";
            // 
            // txtPCName
            // 
            this.txtPCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCName.Location = new System.Drawing.Point(217, 50);
            this.txtPCName.Name = "txtPCName";
            this.txtPCName.ReadOnly = true;
            this.txtPCName.Size = new System.Drawing.Size(199, 22);
            this.txtPCName.TabIndex = 1;
            // 
            // txtIPAddr
            // 
            this.txtIPAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddr.Location = new System.Drawing.Point(217, 78);
            this.txtIPAddr.Name = "txtIPAddr";
            this.txtIPAddr.ReadOnly = true;
            this.txtIPAddr.Size = new System.Drawing.Size(199, 22);
            this.txtIPAddr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address:";
            // 
            // txtNameOS
            // 
            this.txtNameOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOS.Location = new System.Drawing.Point(217, 106);
            this.txtNameOS.Name = "txtNameOS";
            this.txtNameOS.ReadOnly = true;
            this.txtNameOS.Size = new System.Drawing.Size(199, 22);
            this.txtNameOS.TabIndex = 4;
            // 
            // lblNameOS
            // 
            this.lblNameOS.AutoSize = true;
            this.lblNameOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOS.Location = new System.Drawing.Point(94, 109);
            this.lblNameOS.Name = "lblNameOS";
            this.lblNameOS.Size = new System.Drawing.Size(117, 16);
            this.lblNameOS.TabIndex = 5;
            this.lblNameOS.Text = "Operating System:";
            // 
            // txtRAM
            // 
            this.txtRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRAM.Location = new System.Drawing.Point(217, 134);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.ReadOnly = true;
            this.txtRAM.Size = new System.Drawing.Size(199, 22);
            this.txtRAM.TabIndex = 6;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(64, 137);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(147, 16);
            this.lblRAM.TabIndex = 7;
            this.lblRAM.Text = "Total Physical Memory:";
            // 
            // txtDriveNo
            // 
            this.txtDriveNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriveNo.Location = new System.Drawing.Point(217, 162);
            this.txtDriveNo.Name = "txtDriveNo";
            this.txtDriveNo.ReadOnly = true;
            this.txtDriveNo.Size = new System.Drawing.Size(199, 22);
            this.txtDriveNo.TabIndex = 9;
            this.txtDriveNo.Visible = false;
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.txtDriveNo);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.lblNameOS);
            this.Controls.Add(this.txtNameOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPAddr);
            this.Controls.Add(this.txtPCName);
            this.Controls.Add(this.label1);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(580, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPCName;
        private System.Windows.Forms.TextBox txtIPAddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameOS;
        private System.Windows.Forms.Label lblNameOS;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.TextBox txtDriveNo;
    }
}
