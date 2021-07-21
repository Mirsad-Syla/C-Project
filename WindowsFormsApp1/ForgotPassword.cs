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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write Your City Where You were born";
            toolStripStatusLabel1.Text = "";
        }

        private void MovieAnswertxt_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void MovieAnswertxt_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write Your Favorite Movie";

        }

        private void MovieAnswertxt_MouseHover_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write Your Favorite Movie";
        }

        private void MovieAnswertxt_MouseLeave_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void CityAnswertxt_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write Your City Where You Were Borned";

        }

        private void CityAnswertxt_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
                    
            string cs = @"server=localhost;userid=root;password=Mirsad123;database=hotel";

            var con = new MySqlConnection(cs);
            con.Open();
            var stm = "SELECT * FROM employee WHERE FavoriteMovie = '" + MovieAnswertxt.Text + "' AND CityBorn = '" + CityAnswertxt.Text + "'";
            MySqlCommand cmd = new MySqlCommand(stm, con);
            MySqlDataReader rows = cmd.ExecuteReader();

            if(rows.Read())
            {
                usernametxt.Text = rows.GetString("username");
                passwordtxt.Text = rows.GetString("password");
            }
            else
            {
                if (MovieAnswertxt.Text == "" || CityAnswertxt.Text == "")
                {
                    MessageBox.Show("Please Answer Questions!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("The Favorite Movie or City Born answers is incorrect!", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MovieAnswertxt.Text = "";
                    CityAnswertxt.Text = "";
                }
            }
        }
        private void Submitbtn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Submit To Get Results";

        }

        private void Submitbtn_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }
    }
}
