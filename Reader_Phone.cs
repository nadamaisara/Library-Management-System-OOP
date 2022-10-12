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
    public partial class Reader_Phone : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");

        public Reader_Phone()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from ReaderPhone";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReadersDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Reader_Phone_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Rid.Text == "" || Rphone.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                //SqlCommand cmd = new SqlCommand("Insert into ReadersTbl values (" + BUser_id.Text + ",'" + RdrFname.Text + "','" + RdrLname.Text + "','" + RdrEmail.Text, Con);
                SqlCommand cmd = new SqlCommand("Insert into ReaderPhone values (" + Rid.Text + ",'" + Rphone.Text  + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reader's Phone Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Rid.Text == "" || Rphone.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "Update ReaderPhone set RPhone= '" + Rphone.Text + "' where UserID=" + Rid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reader's Phone Successfully Updated");
                Con.Close();
                populate();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Rid.Text == "")
            {
                MessageBox.Show("Enter the Reader ID");

            }
            else
            {
                Con.Open();
                string query = "Delete from ReaderPhone where UserID= " + Rid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reader's Phone Successfully Deleted");
                Con.Close();
                populate();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rid.Text = "";
            Rphone.Text = "";
        }
    }
}
