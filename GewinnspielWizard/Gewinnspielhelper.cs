using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GewinnspielWizard {
    public partial class Gewinnspielhelper : Form {

        public Gewinnspielhelper() {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e) {
            if (!File.Exists(textBox_persistance_file.Text)) {
                MessageBox.Show("File " + textBox_persistance_file.Text + " does not exists!");
            } else {
                Persister.Load(textBox_persistance_file.Text);
            }
        }

        private void button_save_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBox_persistance_file.Text)) {
                MessageBox.Show("File Textbox is blank");
            } else {
                Persister.Store(textBox_persistance_file.Text, new PersistentContainer());
            }
        }

        private void button_file_load_dialog_Click(object sender, EventArgs e) {

        }

        private void buttonAddSenderEntry_Click(object sender, EventArgs e) { 
            EmailEntryForm eef = new EmailEntryForm();
            flowLayoutPanelMailSender.Controls.Add(eef);
        }
    }
}
