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
    public partial class LOG_IN : Form
    {
        public LOG_IN() {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e) {
            string cs = @"server=localhost;userid=root;password=Mirsad123;database=hotel";

            var con = new MySqlConnection(cs);
            con.Open();

            var stm = "SELECT * FROM employee WHERE username = '" + userTxt.Text + "' AND password = '" + pswTxt.Text + "'";
            MySqlCommand cmd = new MySqlCommand(stm, con);

            MySqlDataReader rows = cmd.ExecuteReader();
            if( rows.HasRows && rows.FieldCount >= 1 )
            {
                Home form2 = new Home();
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userTxt.Text = "";
                pswTxt.Text = "";
            }


        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PswLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myform = new ForgotPassword();
            myform.Show();
        }
    }
}
