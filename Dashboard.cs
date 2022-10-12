using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyLibrary
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sd1 = new SqlDataAdapter("select count(*) from BookInfo ", Con);
            DataTable dt = new DataTable();
            sd1.Fill(dt);
            Booklbl.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sd2 = new SqlDataAdapter("select count(*) from StaffInfo ", Con);
            DataTable dt2 = new DataTable();
            sd2.Fill(dt2);
            Stafflbl.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sd3 = new SqlDataAdapter("select count(*) from BorrowerInfo ", Con);
            DataTable dt3 = new DataTable();
            sd3.Fill(dt3);
            Borrowerlbl.Text = dt3.Rows[0][0].ToString();

            SqlDataAdapter sd4 = new SqlDataAdapter("select count(*) from ReaderInfo ", Con);
            DataTable dt4 = new DataTable();
            sd4.Fill(dt4);
            Readerlbl.Text = dt4.Rows[0][0].ToString();

            SqlDataAdapter sd5 = new SqlDataAdapter("select count(*) from Authentication ", Con);
            DataTable dt5 = new DataTable();
            sd5.Fill(dt5);
            Userlbl.Text = dt5.Rows[0][0].ToString();

            Con.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}