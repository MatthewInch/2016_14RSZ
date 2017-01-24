namespace LakasSzovetkezet
{
    partial class NewDeposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFlat = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOwner = new System.Windows.Forms.Label();
            this.lbResident = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lakás";
            // 
            // cbFlat
            // 
            this.cbFlat.FormattingEnabled = true;
            this.cbFlat.Location = new System.Drawing.Point(56, 13);
            this.cbFlat.Name = "cbFlat";
            this.cbFlat.Size = new System.Drawing.Size(121, 21);
            this.cbFlat.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbResident);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbOwner);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 421);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tulajdonos:";
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Location = new System.Drawing.Point(72, 4);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(0, 13);
            this.lbOwner.TabIndex = 1;
            // 
            // lbResident
            // 
            this.lbResident.AutoSize = true;
            this.lbResident.Location = new System.Drawing.Point(72, 31);
            this.lbResident.Name = "lbResident";
            this.lbResident.Size = new System.Drawing.Size(0, 13);
            this.lbResident.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lakó:";
            // 
            // NewDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbFlat);
            this.Controls.Add(this.label1);
            this.Name = "NewDeposit";
            this.Text = "NewDeposit";
            this.Load += new System.EventHandler(this.NewDeposit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFlat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbResident;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.Label label2;
    }
}