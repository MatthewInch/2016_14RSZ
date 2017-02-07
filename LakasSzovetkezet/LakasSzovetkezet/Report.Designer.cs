namespace LakasSzovetkezet
{
    partial class Report
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
            this.cbflat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.lbOwner = new System.Windows.Forms.Label();
            this.lbResident = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbflat
            // 
            this.cbflat.FormattingEnabled = true;
            this.cbflat.Location = new System.Drawing.Point(70, 12);
            this.cbflat.Name = "cbflat";
            this.cbflat.Size = new System.Drawing.Size(121, 21);
            this.cbflat.TabIndex = 0;
            this.cbflat.SelectedIndexChanged += new System.EventHandler(this.cbflat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lakás";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbResident);
            this.panel1.Controls.Add(this.lbOwner);
            this.panel1.Location = new System.Drawing.Point(23, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 414);
            this.panel1.TabIndex = 2;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(197, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Location = new System.Drawing.Point(31, 12);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(35, 13);
            this.lbOwner.TabIndex = 0;
            this.lbOwner.Text = "label2";
            // 
            // lbResident
            // 
            this.lbResident.AutoSize = true;
            this.lbResident.Location = new System.Drawing.Point(213, 12);
            this.lbResident.Name = "lbResident";
            this.lbResident.Size = new System.Drawing.Size(35, 13);
            this.lbResident.TabIndex = 1;
            this.lbResident.Text = "label2";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 465);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbflat);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbflat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.Label lbResident;
    }
}