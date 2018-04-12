namespace GewinnspielWizard
{
    partial class Gewinnspielhelper
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_persistance_file = new System.Windows.Forms.Label();
            this.textBox_persistance_file = new System.Windows.Forms.TextBox();
            this.button_file_load_dialog = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_mail_username = new System.Windows.Forms.Label();
            this.textBoxMailUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelMailServer = new System.Windows.Forms.Label();
            this.textBoxMailServer = new System.Windows.Forms.TextBox();
            this.labelMailSubject = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMailBody = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelMailSender = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMailSender = new System.Windows.Forms.Label();
            this.buttonAddSenderEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_persistance_file
            // 
            this.label_persistance_file.AutoSize = true;
            this.label_persistance_file.Location = new System.Drawing.Point(10, 13);
            this.label_persistance_file.Name = "label_persistance_file";
            this.label_persistance_file.Size = new System.Drawing.Size(84, 13);
            this.label_persistance_file.TabIndex = 0;
            this.label_persistance_file.Text = "Persistance File:";
            // 
            // textBox_persistance_file
            // 
            this.textBox_persistance_file.Location = new System.Drawing.Point(100, 10);
            this.textBox_persistance_file.Name = "textBox_persistance_file";
            this.textBox_persistance_file.Size = new System.Drawing.Size(596, 20);
            this.textBox_persistance_file.TabIndex = 1;
            // 
            // button_file_load_dialog
            // 
            this.button_file_load_dialog.Location = new System.Drawing.Point(702, 7);
            this.button_file_load_dialog.Name = "button_file_load_dialog";
            this.button_file_load_dialog.Size = new System.Drawing.Size(75, 23);
            this.button_file_load_dialog.TabIndex = 2;
            this.button_file_load_dialog.Text = "FileOpenDialog";
            this.button_file_load_dialog.UseVisualStyleBackColor = true;
            this.button_file_load_dialog.Click += new System.EventHandler(this.button_file_load_dialog_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(702, 33);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 3;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(702, 60);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_mail_username
            // 
            this.label_mail_username.AutoSize = true;
            this.label_mail_username.Location = new System.Drawing.Point(14, 39);
            this.label_mail_username.Name = "label_mail_username";
            this.label_mail_username.Size = new System.Drawing.Size(80, 13);
            this.label_mail_username.TabIndex = 5;
            this.label_mail_username.Text = "Mail Username:";
            // 
            // textBoxMailUserName
            // 
            this.textBoxMailUserName.Location = new System.Drawing.Point(100, 36);
            this.textBoxMailUserName.Name = "textBoxMailUserName";
            this.textBoxMailUserName.Size = new System.Drawing.Size(434, 20);
            this.textBoxMailUserName.TabIndex = 6;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(38, 65);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(100, 62);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(434, 20);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelMailServer
            // 
            this.labelMailServer.AutoSize = true;
            this.labelMailServer.Location = new System.Drawing.Point(31, 91);
            this.labelMailServer.Name = "labelMailServer";
            this.labelMailServer.Size = new System.Drawing.Size(63, 13);
            this.labelMailServer.TabIndex = 9;
            this.labelMailServer.Text = "Mail Server:";
            // 
            // textBoxMailServer
            // 
            this.textBoxMailServer.Location = new System.Drawing.Point(100, 88);
            this.textBoxMailServer.Name = "textBoxMailServer";
            this.textBoxMailServer.Size = new System.Drawing.Size(434, 20);
            this.textBoxMailServer.TabIndex = 10;
            // 
            // labelMailSubject
            // 
            this.labelMailSubject.AutoSize = true;
            this.labelMailSubject.Location = new System.Drawing.Point(26, 117);
            this.labelMailSubject.Name = "labelMailSubject";
            this.labelMailSubject.Size = new System.Drawing.Size(68, 13);
            this.labelMailSubject.TabIndex = 11;
            this.labelMailSubject.Text = "Mail Subject:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(677, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mail Body:";
            // 
            // textBoxMailBody
            // 
            this.textBoxMailBody.Location = new System.Drawing.Point(100, 140);
            this.textBoxMailBody.Multiline = true;
            this.textBoxMailBody.Name = "textBoxMailBody";
            this.textBoxMailBody.Size = new System.Drawing.Size(677, 129);
            this.textBoxMailBody.TabIndex = 14;
            // 
            // flowLayoutPanelMailSender
            // 
            this.flowLayoutPanelMailSender.AutoScroll = true;
            this.flowLayoutPanelMailSender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanelMailSender.Location = new System.Drawing.Point(12, 319);
            this.flowLayoutPanelMailSender.Name = "flowLayoutPanelMailSender";
            this.flowLayoutPanelMailSender.Size = new System.Drawing.Size(765, 568);
            this.flowLayoutPanelMailSender.TabIndex = 15;
            // 
            // labelMailSender
            // 
            this.labelMailSender.AutoSize = true;
            this.labelMailSender.Location = new System.Drawing.Point(12, 301);
            this.labelMailSender.Name = "labelMailSender";
            this.labelMailSender.Size = new System.Drawing.Size(63, 13);
            this.labelMailSender.TabIndex = 16;
            this.labelMailSender.Text = "Mail Sender";
            // 
            // buttonAddSenderEntry
            // 
            this.buttonAddSenderEntry.Image = global::GewinnspielWizard.Properties.Resources.add;
            this.buttonAddSenderEntry.Location = new System.Drawing.Point(81, 275);
            this.buttonAddSenderEntry.Name = "buttonAddSenderEntry";
            this.buttonAddSenderEntry.Size = new System.Drawing.Size(40, 40);
            this.buttonAddSenderEntry.TabIndex = 17;
            this.buttonAddSenderEntry.UseVisualStyleBackColor = true;
            this.buttonAddSenderEntry.Click += new System.EventHandler(this.buttonAddSenderEntry_Click);
            // 
            // Gewinnspielhelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 899);
            this.Controls.Add(this.buttonAddSenderEntry);
            this.Controls.Add(this.labelMailSender);
            this.Controls.Add(this.flowLayoutPanelMailSender);
            this.Controls.Add(this.textBoxMailBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelMailSubject);
            this.Controls.Add(this.textBoxMailServer);
            this.Controls.Add(this.labelMailServer);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxMailUserName);
            this.Controls.Add(this.label_mail_username);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_file_load_dialog);
            this.Controls.Add(this.textBox_persistance_file);
            this.Controls.Add(this.label_persistance_file);
            this.Name = "Gewinnspielhelper";
            this.Text = "Gewinnspiel Wizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_persistance_file;
        private System.Windows.Forms.TextBox textBox_persistance_file;
        private System.Windows.Forms.Button button_file_load_dialog;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_mail_username;
        private System.Windows.Forms.TextBox textBoxMailUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelMailServer;
        private System.Windows.Forms.TextBox textBoxMailServer;
        private System.Windows.Forms.Label labelMailSubject;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMailBody;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMailSender;
        private System.Windows.Forms.Label labelMailSender;
        private System.Windows.Forms.Button buttonAddSenderEntry;
    }
}

