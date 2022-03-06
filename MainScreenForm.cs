using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Fake_Ransomware
{
    public partial class MainScreenForm : Form
    {

        public MainScreenForm ()
        {
            InitializeComponent();
            SecondaryScreenForm dlg = new SecondaryScreenForm();
            Screen[] screens = Screen.AllScreens;
            Rectangle bounds = screens[1].Bounds;
            dlg.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            dlg.StartPosition = FormStartPosition.Manual;
            dlg.Show();
            string hostName = Dns.GetHostName();
            string str2 = Dns.GetHostEntry(hostName).AddressList[1].ToString();
            try
            {
                StreamWriter writer = File.AppendText(@"Ip_Host_Ransomware.txt");
                writer.Write("IP Adress:" + str2 + ";");
                writer.Write(" Hostname:" + hostName + ";");
                writer.WriteLine(" Opening date:" + DateTime.Now.ToString());
                writer.Close();
            }
            finally
            {
                Console.WriteLine();
            }
        }
        private void Key_text(object sender, EventArgs e)
        {
            Validate_btn.Enabled = true;
        }

        private void Validate_key(object sender, EventArgs e)
        {
            if(Key_txtbx.Text == "P@ssw0rd!")
            {
                Application.Exit();
            }
            else
            {
                Key_txtbx.Text = "Incorrect key. Please retry";
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);
        }

    }
}
