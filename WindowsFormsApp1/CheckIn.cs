using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class CheckIn : Form
    {
        string outselected = "";
        public CheckIn()
        {
            InitializeComponent();           
            string cs = @"server=localhost;userid=root;password=Mirsad123;database=hotel";

            var con = new MySqlConnection(cs);
            con.Open();
            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT guest_name FROM reg_list WHERE checked = 0";
            using (MySqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    GuestNamecombo.Items.Add(oReader["guest_name"].ToString());
                }
                con.Close();
            }
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            statusStrip1.BackColor = Color.DarkGray;

        }

        private void Closepic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateAndTimelbl.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void Reservationsbtn_Click(object sender, EventArgs e)
        {
            var myform = new Reservation();
            myform.Show();
        }

        private void ReservationListbtn_Click(object sender, EventArgs e)
        {
            var myform = new ReservationsList();
            myform.Show();
        }

        private void CheckInBtnn_Click(object sender, EventArgs e)
        {
            var myform = new CheckIn();
            myform.Show();
        }

        private void CheckInListbtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckInList();
            myform.Show();
        }

        private void CheckOutbtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckOut();
            myform.Show();
        }

        private void CheckOutListbtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckOutList();
            myform.Show();
        }

        private void ClosePic_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void MinimizePic_Click_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void reservationsbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new Reservation();
            this.Hide();
            myform.ShowDialog();
        }

        private void reservationlistbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new ReservationsList();
            this.Hide();
            myform.ShowDialog();
        }

        private void CheckInbtn_Click(object sender, EventArgs e)
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

        private void GuestNamecombo_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose Guest Name";
        }

        private void GuestNamecombo_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void Check_INbtn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click To Check In";
        }

        private void Check_INbtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void FoodMenubtn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click To See Food And Menu Of Guest";

        }

        private void FoodMenubtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void Check_INbtn_Click(object sender, EventArgs e)
        {
            if (GuestNamecombo.Text == "")
            {
                MessageBox.Show("Please Choose a Guest Name!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (outselected != "")
                {
                    string cs = @"server=localhost;userid=root;password=Mirsad123;database=hotel";

                    var con = new MySqlConnection(cs);
                    con.Open();
                    var cmd = new MySqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "UPDATE reg_list SET checked = 1 WHERE guest_name = '" + outselected + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Checked In!");
                }
            }
        }

        private void ClosePic_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            var myform = new LOG_IN();
            this.Hide();
            myform.Show();
        }

        private void GuestNamecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selected = (string)comboBox.SelectedItem;
            outselected = selected;

            string cs = @"server=localhost;userid=root;password=Mirsad123;database=hotel";

            var con = new MySqlConnection(cs);
            con.Open();
            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM reg_list WHERE guest_name = '"+ selected +"'";
            using (MySqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    //GuestNamecombo.Items.Add(oReader["guest_name"].ToString());
                    RoomNtxt.Text = oReader["room_number"].ToString();
                    NumberDtxt.Text = oReader["days"].ToString();
                    NumberAtxt.Text = oReader["adults"].ToString();
                    NumberChtxt.Text = oReader["children"].ToString();
                    //checkin
                    var checkin = oReader["checkin"].ToString();
                    DateTime iDate = DateTime.ParseExact(checkin, "dd/MM/yyyy", null);
                    CheckInDate.Value = iDate;
                    //checkout
                    var checkout = oReader["checkout"].ToString();
                    DateTime oDate = DateTime.ParseExact(checkout, "dd/MM/yyyy", null);
                    CheckoutDate.Value = oDate;
                    RoomTypetxt.Text = oReader["room_type"].ToString();
                    Subtotaltxt.Text = oReader["total"].ToString();
                    Foodtxt.Text = oReader["food"].ToString();

                }
                con.Close();
            }

        }
    }
}
    
