using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GewinnspielWizard
{
    public partial class EmailEntryForm : UserControl
    {
        public EmailEntryForm()
        {
            InitializeComponent();
        }

        private void buttonDeleteSenderEntry_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO Delete");
        }

        public string TextBoxSenderNameText { get => textBoxSenderName.Text; set => textBoxSenderName.Text = value; }

        public string TextBoxSenderEmailText { get => textBoxSenderEmail.Text; set => textBoxSenderEmail.Text = value; }

        public string TextBoxSenderFooterText { get => textBoxSenderFooter.Text; set => textBoxSenderFooter.Text = value; }
    }
}
