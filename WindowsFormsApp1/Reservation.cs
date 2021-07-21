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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void reservationlistbtn_Click(object sender, EventArgs e)
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

        private void CheckInlistbtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckInList();
            this.Hide();
            myform.ShowDialog();
        }

        private void checkoutbtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckOut();
            this.Hide();
            myform.ShowDialog();
        }

        private void Checkoutlistbtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckOutList();
            this.Hide();
            myform.ShowDialog();
        }

        private void Reservebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to register this Guest?", "Question",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {
                var myform = new Home();
                this.Hide();
                myform.ShowDialog();
            }
            else
            {
                // TextBox duhet te jene obligative qe te plotesohen
                if (GuestNametxt.Text == "" || RoomNtxt.Text == "" || NumberDlbl.Text == ""
                  || RoomTypecmb.Text == "" || CheckInDate.Text == ""
                    || CheckoutDate.Text == "" || FemaleRB.Text == "" || MaleRB.Text == "")
                {
                    MessageBox.Show("Please write requested information!", "Warning",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string cs = @"server=localhost;userid=root;password=Mirsad123;database=hotel";

                    var con = new MySqlConnection(cs);
                    con.Open();
                    var cmd = new MySqlCommand();
                    cmd.Connection = con;
                    string gender;
                    gender = "Empty";
                    if (MaleRB.Checked)
                    {
                        gender = "M";
                    }
                    if (FemaleRB.Checked)
                    {
                        gender = "F";
                    }

                    string food = "";
                    food += (Breakfastchk.Checked) ? "Breakfast " : "";
                    food += (Lunchchk.Checked) ? "Lunch " : "";
                    food += (Dinnerchk.Checked) ? "Dinner " : "";

                    cmd.CommandText = "INSERT INTO reg_list(guest_name, room_number, days, checkin, checkout, room_type, adults, children, gender, food, total) VALUES('" + GuestNametxt.Text + "', '" + RoomNtxt.Text + "', '" + NumberDlbl.Text + "', '" + CheckInDate.Text + "', '" + CheckoutDate.Text + "', '" + RoomTypecmb.Text + "', '" + UpdownAdults.Value + "', '" + UpDownChildren.Value + "', '" + gender + "', '" + food + "', '" + SubTlbl.Text + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(GuestNametxt.Text + ", Successfully Reserved the Room!");
                    Clear();
                }
            }
        }
        public void Clear()
        {
            GuestNametxt.Text = "";
            RoomNtxt.Text = "";
            NumberDlbl.Text = "";
            CheckInDate.Text = "";
            CheckoutDate.Text = "";
            UpdownAdults.ResetText();
            UpDownChildren.ResetText();
            SubTlbl.Text = "";
            RoomTypecmb.SelectedIndex = -1;
            MaleRB.Checked = false;
            FemaleRB.Checked = false;
            RoomTypecmb.Text = "";
            Breakfastchk.Checked = false;
            Lunchchk.Checked = false;
            Dinnerchk.Checked = false;
        }
        private void MinimizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            statusStrip2.BackColor = Color.DarkGray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTimelbl.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void DateAndTimelbl_Click(object sender, EventArgs e)
        {
            DateTimelbl.Text = DateTime.Now.ToString();
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

        private void Clearbtn_Click(object sender, EventArgs e)
        { 
            Clear();
            MessageBox.Show("Successfully Cleared!");
        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            int Number;
            int.TryParse(RoomNtxt.Text, out Number);
            if (RoomNtxt.Text == "")
            {
                MessageBox.Show("Please Choose a Room in range (1 - 60).");
            }
            if (Number > 0 && Number < 21)
            {
                UpdownAdults.Maximum = 2;
                UpDownChildren.Maximum = 0;
                RoomTypecmb.SelectedIndex = 0;
                if (UpdownAdults.Value >= 2)
                {
                    UpdownAdults.Value = 2;
                }
                if (UpDownChildren.Value >=0)
                {
                    UpDownChildren.Value = 0;
                }
            }

            else if (Number >= 21 && Number < 41)
            {
                UpdownAdults.Maximum = 2;
                UpDownChildren.Maximum = 2;
                RoomTypecmb.SelectedIndex = 1;
                if (UpdownAdults.Value >= 2)
                {
                    UpdownAdults.Value = 2;
                }

                if (UpDownChildren.Value >= 2)
                {
                    UpDownChildren.Value = 2;
                }

            }
            else if (Number >= 40 && Number < 61)
            {
                UpdownAdults.Maximum = 3;
                UpDownChildren.Maximum = 3;
                RoomTypecmb.SelectedIndex = 2;

                if (UpdownAdults.Value >= 3)
                {
                    UpdownAdults.Value = 3;
                }

                if (UpDownChildren.Value >= 3)
                {
                    UpDownChildren.Value = 3;
                }
            }
            else
            {
                MessageBox.Show("In Hotel Are Only 60 Rooms!");
            }

            NumberDlbl.Text = CheckoutDate.Value.Subtract(CheckInDate.Value).Days.ToString();

            const double Standard = 30;
            const double Quad = 60;
            const double Suite = 80;
            double b;
            const double breakfast = 5;
            const double lunch = 15;
            const double dinner = 18;
            double FoodPrice = 0;
            double subtotal;
            int adults = (int)UpdownAdults.Value;
            int children = (int)UpDownChildren.Value;


            if (Breakfastchk.Checked)
                FoodPrice = FoodPrice + breakfast;
            if (Lunchchk.Checked)
                FoodPrice = FoodPrice + lunch;
            if (Dinnerchk.Checked)
                FoodPrice = FoodPrice + dinner;
            // b - tregon numrin e diteve
            double.TryParse(NumberDlbl.Text, out b);

            if (RoomTypecmb.Text == "Standard")
            {

                SubTlbl.Text = (b * Standard + b*FoodPrice * (adults + children)).ToString("c");
                double.TryParse(SubTlbl.Text, out subtotal);


            }
            if (RoomTypecmb.Text == "Quad")
            {

                SubTlbl.Text = (b * Quad + b*FoodPrice * (adults + children)).ToString("c");
                double.TryParse(SubTlbl.Text, out subtotal);

            }
            if (RoomTypecmb.Text == "Suite")
            {

                SubTlbl.Text = (b * Suite + b*FoodPrice * (adults + children)).ToString("c");
                double.TryParse(SubTlbl.Text, out subtotal);
            }
        }

        private void GuestNametxt_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Write Guest Name";
        }

        private void GuestNametxt_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void RoomNtxt_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Choose Room Number In Rage 1-60";
        }

        private void RoomNtxt_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void CheckInDate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Choose CheckIn Date";
        }

        private void CheckInDate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void CheckoutDate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Choose CheckOut Date";
        }

        private void CheckoutDate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void RoomTypecmb_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Room Type Will Choose Automatically";
        }

        private void RoomTypecmb_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void FemaleRB_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Select Gender";
        }

        private void FemaleRB_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void MaleRB_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Select Gender";
        }

        private void Breakfastchk_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Breakfast 5€";
        }

        private void Breakfastchk_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void Lunchchk_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Lunch 15€";
        }

        private void Lunchchk_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";

        }

        private void Dinnerchk_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Lunch 18€";
        }

        private void Dinnerchk_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void Reservebtn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Click To Reserve";

        }

        private void Reservebtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void Clearbtn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Click To Clear";
        }

        private void Clearbtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void Calculatebtn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Click To Calculate";
        }

        private void Calculatebtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void Exitbtn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Click To Exit";
        }

        private void Exitbtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void Reservationsbtn_Click(object sender, EventArgs e)
        {
            var myform = new Reservation();
            myform.Show();
        }

        private void ReservationListbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new ReservationsList();
            this.Hide();
            myform.Show();
        }

        private void CheckInbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new CheckIn();
            this.Hide();
            myform.Show();
        }

        private void ChInbtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckInList();
            this.Hide();
            myform.Show();
        }

        private void Chobtn_Click(object sender, EventArgs e)
        {
            var myform = new CheckOut();
            this.Hide();
            myform.Show();
        }

        private void CheckOutList_Click(object sender, EventArgs e)
        {
            var myform = new CheckOutList();
            this.Hide();
            myform.Show();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            var myform = new Home();
            this.Hide();
            myform.ShowDialog();
        }

        private void Logutbtn_Click(object sender, EventArgs e)
        {
            var myform = new LOG_IN();
            this.Hide();
            myform.Show();     
        }

        private void CheckInDate_ValueChanged(object sender, EventArgs e)
        {
            CheckInDate.MinDate = DateTime.Now;
        }

        private void CheckoutDate_ValueChanged(object sender, EventArgs e)
        {
            CheckoutDate.MinDate = DateTime.Now;
        }

        private void RoomNtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            // * 8 - key code constant qendron per backspace
            if(!char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value!", "Warning");
            }
        }

        private void GuestNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsLetter(e.KeyChar) && (ch!=8))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a only alphabetic characters!", "Warning");
            }
        }
    }
}