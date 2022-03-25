using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_obvestila
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        Storage s = new Storage();
        private void Window_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            timerLoad.Enabled = true;
            askBox.Checked = Properties.Settings.Default.ask;
            panelAdd.Height = 0;
            ReadAllLines();
            listBox1.DataSource = obvestilas;
            listBox1.DisplayMember = "Obvestilo";
            listBox1.ValueMember = "Datum";
            listBox1.ClearSelected();
            textBoxObvestilo.Text = "";
            dateTimeDatum.Value = DateTime.Today;
            datumUpDown.Value = 0;
        }

        string obvestila;
        


        // Save all elements of List obvestilas to csv file

        // Load all elements of csv file to List obvestilas
        List<Obvestila> obvestilas = new List<Obvestila>();

        
        private void displayBtn_Click(object sender, EventArgs e)
        {
            s.RefreshList(listBox1, obvestilas);
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                textBoxObvestilo.Text = obvestilas[listBox1.SelectedIndex].Obvestilo;
                dateTimeDatum.Value = obvestilas[listBox1.SelectedIndex].Datum;
                datumUpDown.Value = obvestilas[listBox1.SelectedIndex].Delay;

                //obvestiloLabel.Text = obvestilas[listBox1.SelectedIndex].Obvestilo;
                //datumLabel.Text = listBox1.SelectedValue.ToString().Substring(0, listBox1.SelectedValue.ToString().Length - 9);

                textBoxObvestilo.Enabled = false;
                dateTimeDatum.Enabled = false;
                datumUpDown.Enabled = false;

                panelAdd.Height = 0;
                dodajBtn.Visible = false;
            }

        }




        private void editValueBtn_Click(object sender, EventArgs e)
        { 
            if(listBox1.SelectedIndex >= 0)
            {
                textBoxObvestilo.Enabled = true;
                textBoxObvestilo.Text = obvestilas[listBox1.SelectedIndex].Obvestilo;
                dateTimeDatum.Enabled = true;
                dateTimeDatum.Value = DateTime.Parse(listBox1.SelectedValue.ToString());
                datumUpDown.Enabled = true;
                datumUpDown.Value = obvestilas[listBox1.SelectedIndex].Delay;
                saveDataBtn.Enabled = true;
            }
            
        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            obvestilas[listBox1.SelectedIndex].Obvestilo = textBoxObvestilo.Text;
            obvestilas[listBox1.SelectedIndex].Datum = dateTimeDatum.Value;
            obvestilas[listBox1.SelectedIndex].Delay = Convert.ToInt32(datumUpDown.Value);
            s.RefreshList(listBox1, obvestilas);
            saveDataBtn.Enabled = false;
        }



        private void addBtn_Click(object sender, EventArgs e)
        {
            timerDrop.Enabled = true;
            dodajBtn.Visible = true;
        }
        private void dodajBtn_Click(object sender, EventArgs e)
        {
            obvestilas.Add(new Obvestila(addObvestilo.Text, addDatum.Value, (int)addDelay.Value));
            s.RefreshList(listBox1, obvestilas);
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                DialogResult dr = MessageBox.Show("Dokončno izbriši izbrani element.\nTega se ne da razveljaviti.", "Brisanje", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    obvestilas.Remove(obvestilas[listBox1.SelectedIndex]);
                    s.RefreshList(listBox1, obvestilas);
                }
            }
        }



        private void saveBtn_Click(object sender, EventArgs e)
        {
            s.ExportAll(obvestilas);
        }

        //      Timers      //
        private void timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == 12)
            {
                int j = 0;
                string[] poslji = new string[200];
                for (int i = 0; i < obvestilas.Count; i++)
                {
                    if (obvestilas[i].Datum.Year <= DateTime.Now.Year && obvestilas[i].Datum.Month <= DateTime.Now.Month && obvestilas[i].Datum.Day - obvestilas[i].Delay <= DateTime.Now.Day)
                    {
                        poslji[j] = obvestilas[i].Obvestilo.ToString();
                        j++;
                        label1.Text = "Že mimo";
                        label1.ForeColor = Color.Red;
                    }
                    else
                    {
                        label1.Text = "ni še";
                        label1.ForeColor = Color.Green;
                    }
                }
                SendExpired(poslji);
            }
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            Opacity += 0.05;
        }

        private void timerDrop_Tick(object sender, EventArgs e)
        {
            if (panelAdd.Height <= 80) panelAdd.Height += 2;
            else timerDrop.Enabled = false;
        }



        //      External        //


        // Reload the List obvestilas
        public void ReadAllLines()
        {
            obvestilas = s.ImportAll();
        }

        // Send notif thru email
        public string sender;
        public string password;
        public string reciever;
        public string server;
        public int port;
        public void SendExpired(string[] e)
        {
            if (e.Length > 0)
            {
                foreach (string o in e)
                {
                    if (o != null)
                    {
                        obvestila += o;
                        obvestila += ", <br>";
                    }
                }
                SendNotif sn = new SendNotif();
                sn.Email(sn.getHtml(obvestila, "Neopravljene zadeve:"));
                obvestila = "";
            }
        }





        //      Form movement       //      Form buttons        //



        private void exitIcon_Click(object sender, EventArgs e)
        {
            if (askBox.Checked)
            {
                DialogResult dr = MessageBox.Show("Ali želite zapustiti program?\nVsi podatki bodo shranjeni.", "Shrani & zapri", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    s.ExportAll(obvestilas);
                    Application.Exit();
                }
            }
            else
            {
                s.ExportAll(obvestilas);
                Application.Exit();
            }
        }

        private void exitIcon_MouseHover(object sender, EventArgs e)
        {
            exitIcon.IconColor = Color.FromArgb(14, 14, 14);
        }

        private void exitIcon_MouseLeave(object sender, EventArgs e)
        {
            exitIcon.IconColor= Color.FromArgb(52, 73, 94);
        }

        private void minIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minIcon_MouseHover(object sender, EventArgs e)
        {
            minIcon.IconColor = Color.FromArgb(14, 14, 14);
        }

        private void minIcon_MouseLeave(object sender, EventArgs e)
        {
            minIcon.IconColor = Color.FromArgb(52, 73, 94);
        }

        private bool mouseDown;
        private Point lastLocation;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Window_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            s.ExportAll(obvestilas);
        }

        private void askBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ask) Properties.Settings.Default.ask = false;
            else Properties.Settings.Default.ask = true;
            Properties.Settings.Default.Save();
        }


        //      TEMP - TESTING      //

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string[] poslji = new string[200];
            int j = 0;
            for (int i = 0; i < obvestilas.Count - 1; i++)
            {
                if (obvestilas[i].Datum.Year <= DateTime.Now.Year && obvestilas[i].Datum.Month <= DateTime.Now.Month && obvestilas[i].Datum.Day - obvestilas[i].Delay <= DateTime.Now.Day)
                {
                    poslji[j] = obvestilas[i].Obvestilo.ToString();
                    j++;
                    label1.Text = "Že mimo";
                    label1.ForeColor = Color.Red;
                }
                else
                {
                    label1.Text = "ni še";
                    label1.ForeColor = Color.Green;
                }
            }
            SendExpired(poslji);

        }

        private void backgroundBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        void credentialsBtn_Click(object sender, EventArgs e)
        {
            Credentials cr = new Credentials();
            cr.Show();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }
    }
}
