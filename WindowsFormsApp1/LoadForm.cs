using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 1;
            if (rectangleShape2.Width >= 257)
            {
                timer1.Stop();
                this.Hide();
                MainForm logfrm = new MainForm();
                logfrm.Show();
            }
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
