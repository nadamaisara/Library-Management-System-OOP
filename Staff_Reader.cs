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
    public partial class Staff_Reader : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");

        public Staff_Reader()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from StaffReader";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReadersDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            LibrariansForm librarians = new LibrariansForm();
            librarians.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sid.Text = "";
            Rid.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Sid.Text == "" || Rid.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                //SqlCommand cmd = new SqlCommand("Insert into ReadersTbl values (" + BUser_id.Text + ",'" + RdrFname.Text + "','" + RdrLname.Text + "','" + RdrEmail.Text, Con);
                SqlCommand cmd = new SqlCommand("Insert into StaffReader values (" + Sid.Text + ",'" + Rid.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void Staff_Reader_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Sid.Text == "" || Rid.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "Update StaffReader set UserID= '" + Rid.Text + "' where StaffID=" + Sid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information Successfully Updated");
                Con.Close();
                populate();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Sid.Text == "" || Rid.Text=="")
            {
                MessageBox.Show("Enter the Staff ID with the User ID you wish to delete.");

            }
            else
            {
                Con.Open();
                string query = "Delete from StaffReader where StaffID= " + Sid.Text +"and UserID= "+Rid.Text+ ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information Successfully Deleted");
                Con.Close();
                populate();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
