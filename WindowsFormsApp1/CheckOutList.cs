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
    public partial class CheckOutList : Form
    {
        public CheckOutList()
        {
            InitializeComponent();
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

        private void CheckOutList_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            statusStrip1.BackColor = Color.DarkGray;
        }

        private void Reservationsbtn_Click(object sender, EventArgs e)
        {
            var myform = new Reservation();
            myform.Show();
        }

        private void ReservationListBtn_Click(object sender, EventArgs e)
        {
            var myform = new ReservationsList();
            myform.Show();
        }

        private void CheckInBtn_Click(object sender, EventArgs e)
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

        private void ReservationListbtn_Click_1(object sender, EventArgs e)
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

        private void CheckInListbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new CheckInList();
            this.Hide();
            myform.ShowDialog();
        }

        private void CheckOutbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new CheckOut();
            this.Hide();
            myform.ShowDialog();
        }

        private void CheckOutListbtn_Click_1(object sender, EventArgs e)
        {
            var myform = new CheckOutList();
            this.Hide();
            myform.ShowDialog();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            var myform = new LOG_IN();
            this.Hide();
            myform.Show();
        }

        private void FromDate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click To Choose Check In Date";
        }

        private void FromDate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void ToDate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click To Choose Check Out Date";
        }

        private void ToDate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void ClosePic_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChOListbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string cs = @"server=localhost;userid=root;password=Mirsad123;database=hotel";

            var con = new MySqlConnection(cs);
            con.Open();
            MySqlDataAdapter reg_data = new MySqlDataAdapter("SELECT * FROM reg_list where checked = 2", con);
            DataTable data = new DataTable();
            reg_data.Fill(data);

            foreach (DataRow row in data.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = row["guest_name"];
                dataGridView1.Rows[n].Cells[1].Value = row["room_number"];
                dataGridView1.Rows[n].Cells[2].Value = row["days"];
                dataGridView1.Rows[n].Cells[3].Value = row["checkin"];
                dataGridView1.Rows[n].Cells[4].Value = row["checkout"];
                dataGridView1.Rows[n].Cells[5].Value = row["room_type"];
                dataGridView1.Rows[n].Cells[6].Value = row["adults"];
                dataGridView1.Rows[n].Cells[7].Value = row["children"];
                dataGridView1.Rows[n].Cells[8].Value = row["gender"];
                dataGridView1.Rows[n].Cells[9].Value = row["food"];
                dataGridView1.Rows[n].Cells[10].Value = row["total"];
            }
        }

        private void ChOListbtn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click To See Check Out List";
        }

        private void ChOListbtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void Filterbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string cs = @"server=localhost;userid=root;password=Mirsad123;database=hotel";

            var con = new MySqlConnection(cs);
            con.Open();
            // MySqlDataAdapter reg_data = new MySqlDataAdapter("SELECT * FROM reg_list WHERE guest_name= 'Mirsad Syla'", con);
            MySqlDataAdapter reg_data = new MySqlDataAdapter("SELECT * FROM reg_list WHERE checkin = '" + FromDate.Value.ToString("dd/MM/yyyy") + "'and checkout ='" + ToDate.Value.ToString("dd/MM/yyyy") + "'", con);
            var cmd = new MySqlCommand();
            DataTable data = new DataTable();
            reg_data.Fill(data);

            foreach (DataRow row in data.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = row["guest_name"];
                dataGridView1.Rows[n].Cells[1].Value = row["room_number"];
                dataGridView1.Rows[n].Cells[2].Value = row["days"];
                dataGridView1.Rows[n].Cells[3].Value = row["checkin"];
                dataGridView1.Rows[n].Cells[4].Value = row["checkout"];
                dataGridView1.Rows[n].Cells[5].Value = row["room_type"];
                dataGridView1.Rows[n].Cells[6].Value = row["adults"];
                dataGridView1.Rows[n].Cells[7].Value = row["children"];
                dataGridView1.Rows[n].Cells[8].Value = row["gender"];
                dataGridView1.Rows[n].Cells[9].Value = row["food"];
                dataGridView1.Rows[n].Cells[10].Value = row["total"];
            }
        }

        private void Filterbtn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click To Filter Data";
        }

        private void Filterbtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
