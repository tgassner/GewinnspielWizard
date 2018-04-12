namespace GewinnspielWizard
{
    partial class EmailEntryForm
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSenderName = new System.Windows.Forms.Label();
            this.labelSenderEmail = new System.Windows.Forms.Label();
            this.labelFooter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonDeleteSenderEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSenderName
            // 
            this.labelSenderName.AutoSize = true;
            this.labelSenderName.Location = new System.Drawing.Point(4, 6);
            this.labelSenderName.Name = "labelSenderName";
            this.labelSenderName.Size = new System.Drawing.Size(75, 13);
            this.labelSenderName.TabIndex = 0;
            this.labelSenderName.Text = "Sender Name:";
            // 
            // labelSenderEmail
            // 
            this.labelSenderEmail.AutoSize = true;
            this.labelSenderEmail.Location = new System.Drawing.Point(6, 32);
            this.labelSenderEmail.Name = "labelSenderEmail";
            this.labelSenderEmail.Size = new System.Drawing.Size(73, 13);
            this.labelSenderEmail.TabIndex = 1;
            this.labelSenderEmail.Text = "Sender EMail:";
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Location = new System.Drawing.Point(198, 6);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(77, 13);
            this.labelFooter.TabIndex = 2;
            this.labelFooter.Text = "Sender Footer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(281, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(366, 99);
            this.textBox3.TabIndex = 5;
            // 
            // buttonDeleteSenderEntry
            // 
            this.buttonDeleteSenderEntry.BackgroundImage = global::GewinnspielWizard.Properties.Resources.cancel;
            this.buttonDeleteSenderEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteSenderEntry.Location = new System.Drawing.Point(653, 3);
            this.buttonDeleteSenderEntry.Name = "buttonDeleteSenderEntry";
            this.buttonDeleteSenderEntry.Size = new System.Drawing.Size(40, 40);
            this.buttonDeleteSenderEntry.TabIndex = 6;
            this.buttonDeleteSenderEntry.UseVisualStyleBackColor = true;
            this.buttonDeleteSenderEntry.Click += new System.EventHandler(this.buttonDeleteSenderEntry_Click);
            // 
            // EmailEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeleteSenderEntry);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFooter);
            this.Controls.Add(this.labelSenderEmail);
            this.Controls.Add(this.labelSenderName);
            this.Name = "EmailEntryForm";
            this.Size = new System.Drawing.Size(699, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSenderName;
        private System.Windows.Forms.Label labelSenderEmail;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonDeleteSenderEntry;
    }
}
