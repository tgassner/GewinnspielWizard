using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GewinnspielWizard {
    public partial class Gewinnspielhelper : Form {

        public Gewinnspielhelper() {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e) {
            if (!File.Exists(textBoxPersistanceFile.Text)) {
                MessageBox.Show("File " + textBoxPersistanceFile.Text + " does not exists!");
            } else {
                PersistentContainer pc = Persister.Load(textBoxPersistanceFile.Text);
                flowLayoutPanelMailSender.Controls.Clear();

                textBoxMailBody.Text = pc.MailBody;
                textBoxMailServer.Text = pc.MailServer;
                textBoxMailUserName.Text = pc.MailUsername;
                textBoxMailSubject.Text = pc.MailSubject;
                textBoxDestinationEmailAddress.Text = pc.DestinationEmailAddress;

                foreach (EmailEntry ee in pc.EmailEntries) {
                    EmailEntryForm eef = new EmailEntryForm();
                    eef.TextBoxSenderNameText = ee.Name;
                    eef.TextBoxSenderEmailText = ee.EmailAdress;
                    eef.TextBoxSenderFooterText = ee.ContactInfo;
                    flowLayoutPanelMailSender.Controls.Add(eef);
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBoxPersistanceFile.Text)) {
                MessageBox.Show("File Textbox is blank");
            } else
            {
                PersistentContainer pc = new PersistentContainer();
                pc.MailBody = textBoxMailBody.Text;
                pc.MailServer = textBoxMailServer.Text;
                pc.MailSubject = textBoxMailSubject.Text;
                pc.MailUsername = textBoxMailUserName.Text;
                pc.DestinationEmailAddress = textBoxDestinationEmailAddress.Text;
                pc.EmailEntries = new List<EmailEntry>();

                foreach (var control in flowLayoutPanelMailSender.Controls) {
                    if (control is EmailEntryForm)
                    {
                        EmailEntryForm eef = (EmailEntryForm) control;
                        EmailEntry ee = new EmailEntry();
                        ee.EmailAdress = eef.TextBoxSenderEmailText;
                        ee.ContactInfo = eef.TextBoxSenderFooterText;
                        ee.Name = eef.TextBoxSenderNameText;
                        pc.EmailEntries.Add(ee);
                    }
                }

                Persister.Store(textBoxPersistanceFile.Text, pc);
            }
        }

        private void buttonAddSenderEntry_Click(object sender, EventArgs e) { 
            EmailEntryForm eef = new EmailEntryForm();
            flowLayoutPanelMailSender.Controls.Add(eef);
        }

        private void buttonFileLoadDialogClick(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            odf.CheckFileExists = false;
            if (odf.ShowDialog() == DialogResult.OK)
            {
                textBoxPersistanceFile.Text = odf.FileName;
            }
        }
    }
}