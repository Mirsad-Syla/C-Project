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
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void reservationbtn_Click(object sender, EventArgs e)
        {
            var myform = new LOG_IN();
            this.Hide();
            myform.ShowDialog();
        }
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
