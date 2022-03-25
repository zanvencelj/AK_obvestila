using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_obvestila
{
    public partial class Credentials : Form
    {
        public string sender;
        public string password;
        public string reciever;
        public string server;
        public int port;

        public Credentials()
        {
            InitializeComponent();
        }
        private void Credentials_Load(object sender, EventArgs e)
        {
            senderTB.Texts = Properties.Settings.Default.sender;
            passwordTB.Texts = Properties.Settings.Default.password;
            recieverTB.Texts = Properties.Settings.Default.reciever;
            serverTB.Texts = Properties.Settings.Default.server;
            portUD.Texts = Properties.Settings.Default.port.ToString();   
        }

        private void Credentials_saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.sender = senderTB.Texts;
                Properties.Settings.Default.password = passwordTB.Texts;
                Properties.Settings.Default.reciever = recieverTB.Texts;
                Properties.Settings.Default.server = serverTB.Texts;
                Properties.Settings.Default.port = int.Parse(portUD.Texts);

                Properties.Settings.Default.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Zaprem brez shranjevanja?", "Exit", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
