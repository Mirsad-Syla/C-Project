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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateAndTimelbl.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        //Hapja e formes Rezervimi
        private void CheckInbtn_Click(object sender, EventArgs e)
        {
            var myform = new Reservation();
            myform.Show();
        }

        private void MinimizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReservationListBtn_Click(object sender, EventArgs e)
        {
            var myform = new ReservationsList();
            this.Hide();
            myform.Show();
        }

        private void CheckInBtnn_Click(object sender, EventArgs e)
        {
            var myform = new CheckIn();
            this.Hide();
            myform.Show();
        }

        private void CheckInListbtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckInList();
            this.Hide();
            myform.Show();
        }

        private void CheckOutbtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckOut();
            this.Hide();
            myform.Show();
        }

        private void CheckOutlistbtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckOutList();
            this.Hide();
            myform.Show();
        }

        private void MinimizePic_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void MaxPicture_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void reservationlistbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new ReservationsList();
            this.Hide();
            myform.ShowDialog();
        }

        private void CheckInbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new CheckIn();
            this.Hide();
            myform.ShowDialog();
        }

        private void CheckInlistbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new CheckInList();
            this.Hide();
            myform.ShowDialog();
        }

        private void checkoutbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new CheckOut();
            this.Hide();
            myform.ShowDialog();
        }

        private void Checkoutlistbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new CheckOutList();
            this.Hide();
            myform.ShowDialog();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            var myform = new LOG_IN();
            myform.Show();
            this.Close();
        }

        private void ClosePic_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reservationsbtn_Click(object sender, EventArgs e)
        {
            var myform = new Reservation();
            this.Hide();
            myform.Show();
        }
    }
}
