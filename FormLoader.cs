using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GangBuilderV2
{
    public partial class FormLoader : Form
    {

  
        public FormLoader()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Width += 3;

            if (panelSlide.Width > 250) tBoxLoader.Text = "Fetching data...";
            if (panelSlide.Width > 500) tBoxLoader.Text = "Find dir..";
            if (panelSlide.Width > 750) tBoxLoader.Text = "Find files..";
            if (panelSlide.Width > 1000) tBoxLoader.Text = "Initialisation..";


            if (panelSlide.Width > 1358)
            {
                timer1.Stop();
                Form1 GB = new Form1();
                GB.Show();
                this.Hide();
            }
        }

        private void FormLoader_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnMinimize2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
