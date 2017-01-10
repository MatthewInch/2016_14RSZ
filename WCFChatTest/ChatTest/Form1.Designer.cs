namespace ChatTest
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddPartner = new System.Windows.Forms.Button();
            this.txtPartners = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(13, 13);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(309, 20);
            this.txtText.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(13, 40);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(13, 70);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(414, 440);
            this.txtMessages.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "192.168.1.91";
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.Location = new System.Drawing.Point(671, 12);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(75, 23);
            this.btnAddPartner.TabIndex = 4;
            this.btnAddPartner.Text = "Add partner";
            this.btnAddPartner.UseVisualStyleBackColor = true;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            // 
            // txtPartners
            // 
            this.txtPartners.Location = new System.Drawing.Point(496, 70);
            this.txtPartners.Multiline = true;
            this.txtPartners.Name = "txtPartners";
            this.txtPartners.Size = new System.Drawing.Size(347, 440);
            this.txtPartners.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 522);
            this.Controls.Add(this.txtPartners);
            this.Controls.Add(this.btnAddPartner);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddPartner;
        private System.Windows.Forms.TextBox txtPartners;
    }
}

