namespace LakasSzovetkezet
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
            this.btnNewDeposit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewDeposit
            // 
            this.btnNewDeposit.Location = new System.Drawing.Point(13, 13);
            this.btnNewDeposit.Name = "btnNewDeposit";
            this.btnNewDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnNewDeposit.TabIndex = 0;
            this.btnNewDeposit.Text = "Új befizetés";
            this.btnNewDeposit.UseVisualStyleBackColor = true;
            this.btnNewDeposit.Click += new System.EventHandler(this.btnNewDeposit_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(13, 43);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Kimutatás";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnNewDeposit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewDeposit;
        private System.Windows.Forms.Button btnReport;
    }
}

