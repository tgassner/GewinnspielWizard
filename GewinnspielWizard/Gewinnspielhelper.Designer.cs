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
            this.textBoxPersistanceFile = new System.Windows.Forms.TextBox();
            this.buttonFileLoadDialog = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label_mail_username = new System.Windows.Forms.Label();
            this.textBoxMailUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelMailServer = new System.Windows.Forms.Label();
            this.textBoxMailServer = new System.Windows.Forms.TextBox();
            this.labelMailSubject = new System.Windows.Forms.Label();
            this.textBoxMailSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMailBody = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelMailSender = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMailSender = new System.Windows.Forms.Label();
            this.buttonAddSenderEntry = new System.Windows.Forms.Button();
            this.labelDestinationAddress = new System.Windows.Forms.Label();
            this.textBoxDestinationEmailAddress = new System.Windows.Forms.TextBox();
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
            // textBoxPersistanceFile
            // 
            this.textBoxPersistanceFile.Location = new System.Drawing.Point(100, 10);
            this.textBoxPersistanceFile.Name = "textBoxPersistanceFile";
            this.textBoxPersistanceFile.Size = new System.Drawing.Size(596, 20);
            this.textBoxPersistanceFile.TabIndex = 1;
            // 
            // buttonFileLoadDialog
            // 
            this.buttonFileLoadDialog.Location = new System.Drawing.Point(702, 7);
            this.buttonFileLoadDialog.Name = "buttonFileLoadDialog";
            this.buttonFileLoadDialog.Size = new System.Drawing.Size(75, 23);
            this.buttonFileLoadDialog.TabIndex = 2;
            this.buttonFileLoadDialog.Text = "FileOpenDialog";
            this.buttonFileLoadDialog.UseVisualStyleBackColor = true;
            this.buttonFileLoadDialog.Click += new System.EventHandler(this.buttonFileLoadDialogClick);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(702, 33);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.button_load_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(702, 60);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button_save_Click);
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
            this.labelMailSubject.Location = new System.Drawing.Point(26, 143);
            this.labelMailSubject.Name = "labelMailSubject";
            this.labelMailSubject.Size = new System.Drawing.Size(68, 13);
            this.labelMailSubject.TabIndex = 11;
            this.labelMailSubject.Text = "Mail Subject:";
            // 
            // textBoxMailSubject
            // 
            this.textBoxMailSubject.Location = new System.Drawing.Point(100, 140);
            this.textBoxMailSubject.Name = "textBoxMailSubject";
            this.textBoxMailSubject.Size = new System.Drawing.Size(677, 20);
            this.textBoxMailSubject.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mail Body:";
            // 
            // textBoxMailBody
            // 
            this.textBoxMailBody.Location = new System.Drawing.Point(100, 166);
            this.textBoxMailBody.Multiline = true;
            this.textBoxMailBody.Name = "textBoxMailBody";
            this.textBoxMailBody.Size = new System.Drawing.Size(677, 129);
            this.textBoxMailBody.TabIndex = 14;
            // 
            // flowLayoutPanelMailSender
            // 
            this.flowLayoutPanelMailSender.AutoScroll = true;
            this.flowLayoutPanelMailSender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanelMailSender.Location = new System.Drawing.Point(13, 347);
            this.flowLayoutPanelMailSender.Name = "flowLayoutPanelMailSender";
            this.flowLayoutPanelMailSender.Size = new System.Drawing.Size(765, 540);
            this.flowLayoutPanelMailSender.TabIndex = 15;
            // 
            // labelMailSender
            // 
            this.labelMailSender.AutoSize = true;
            this.labelMailSender.Location = new System.Drawing.Point(12, 327);
            this.labelMailSender.Name = "labelMailSender";
            this.labelMailSender.Size = new System.Drawing.Size(63, 13);
            this.labelMailSender.TabIndex = 16;
            this.labelMailSender.Text = "Mail Sender";
            // 
            // buttonAddSenderEntry
            // 
            this.buttonAddSenderEntry.Image = global::GewinnspielWizard.Properties.Resources.add;
            this.buttonAddSenderEntry.Location = new System.Drawing.Point(81, 301);
            this.buttonAddSenderEntry.Name = "buttonAddSenderEntry";
            this.buttonAddSenderEntry.Size = new System.Drawing.Size(40, 40);
            this.buttonAddSenderEntry.TabIndex = 17;
            this.buttonAddSenderEntry.UseVisualStyleBackColor = true;
            this.buttonAddSenderEntry.Click += new System.EventHandler(this.buttonAddSenderEntry_Click);
            // 
            // labelDestinationAddress
            // 
            this.labelDestinationAddress.AutoSize = true;
            this.labelDestinationAddress.Location = new System.Drawing.Point(2, 118);
            this.labelDestinationAddress.Name = "labelDestinationAddress";
            this.labelDestinationAddress.Size = new System.Drawing.Size(91, 13);
            this.labelDestinationAddress.TabIndex = 18;
            this.labelDestinationAddress.Text = "Destination Addr.:";
            // 
            // textBoxDestinationEmailAddress
            // 
            this.textBoxDestinationEmailAddress.Location = new System.Drawing.Point(100, 114);
            this.textBoxDestinationEmailAddress.Name = "textBoxDestinationEmailAddress";
            this.textBoxDestinationEmailAddress.Size = new System.Drawing.Size(434, 20);
            this.textBoxDestinationEmailAddress.TabIndex = 19;
            // 
            // Gewinnspielhelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 899);
            this.Controls.Add(this.textBoxDestinationEmailAddress);
            this.Controls.Add(this.labelDestinationAddress);
            this.Controls.Add(this.buttonAddSenderEntry);
            this.Controls.Add(this.labelMailSender);
            this.Controls.Add(this.flowLayoutPanelMailSender);
            this.Controls.Add(this.textBoxMailBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMailSubject);
            this.Controls.Add(this.labelMailSubject);
            this.Controls.Add(this.textBoxMailServer);
            this.Controls.Add(this.labelMailServer);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxMailUserName);
            this.Controls.Add(this.label_mail_username);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonFileLoadDialog);
            this.Controls.Add(this.textBoxPersistanceFile);
            this.Controls.Add(this.label_persistance_file);
            this.Name = "Gewinnspielhelper";
            this.Text = "Gewinnspiel Wizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_persistance_file;
        private System.Windows.Forms.TextBox textBoxPersistanceFile;
        private System.Windows.Forms.Button buttonFileLoadDialog;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label_mail_username;
        private System.Windows.Forms.TextBox textBoxMailUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelMailServer;
        private System.Windows.Forms.TextBox textBoxMailServer;
        private System.Windows.Forms.Label labelMailSubject;
        private System.Windows.Forms.TextBox textBoxMailSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMailBody;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMailSender;
        private System.Windows.Forms.Label labelMailSender;
        private System.Windows.Forms.Button buttonAddSenderEntry;
        private System.Windows.Forms.Label labelDestinationAddress;
        private System.Windows.Forms.TextBox textBoxDestinationEmailAddress;
    }
}

