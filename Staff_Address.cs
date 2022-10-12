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

    public partial class Staff_Address : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");
        public Staff_Address()
        {
            InitializeComponent();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from StaffAddress";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReadersDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();

        }

        private void Staff_Address_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Sid.Text == "" || Saddress.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                //SqlCommand cmd = new SqlCommand("Insert into ReadersTbl values (" + BUser_id.Text + ",'" + RdrFname.Text + "','" + RdrLname.Text + "','" + RdrEmail.Text, Con);
                // SqlCommand cmd = new SqlCommand("Insert into Reports values (" + Reg_no.Text + ",'" + RissueDate.Text + ",'" +RUser_id.Text + ",'"+Rbook_no.Text  + "')", Con);
                SqlCommand cmd = new SqlCommand("Insert into StaffAddress values (" + Sid.Text + ",'" + Saddress.Text +  "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff's Address Added Successfully");
                Con.Close();
                populate();

                // working
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Sid.Text == "" || Saddress.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "Update StaffAddress set SAddress= '" + Saddress.Text + "' where StaffID=" + Sid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff's Address Successfully Updated");
                Con.Close();
                populate();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Sid.Text == "")
            {
                MessageBox.Show("Enter the Staff ID");

            }
            else
            {
                Con.Open();
                string query = "Delete from StaffAddress where StaffID= " + Sid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff's Address Successfully Deleted");
                Con.Close();
                populate();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sid.Text = "";
            Saddress.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibrariansForm librarians = new LibrariansForm();
            librarians.Show();
            this.Hide();

        }
    }
}
