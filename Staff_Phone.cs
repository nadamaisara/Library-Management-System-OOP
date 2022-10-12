﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyLibrary
{
    public partial class Staff_Phone : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");

        public Staff_Phone()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from StaffPhone";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (SPid.Text == "" || SPhone.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                //SqlCommand cmd = new SqlCommand("Insert into ReadersTbl values (" + BUser_id.Text + ",'" + RdrFname.Text + "','" + RdrLname.Text + "','" + RdrEmail.Text, Con);
                SqlCommand cmd = new SqlCommand("Insert into StaffPhone values (" + SPid.Text + ",'" + SPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff's Phone Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SPid.Text = "";
            SPhone.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Staff_Phone_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SPid.Text == "" || SPhone.Text == "") { 
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "Update StaffPhone set SPhone= '" + SPhone.Text +  "' where StaffID=" + SPid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff's Phone Successfully Updated");
                Con.Close();
                populate();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SPid.Text == "")
            {
                MessageBox.Show("Enter the Staff ID");

            }
            else
            {
                Con.Open();
                string query = "Delete from StaffPhone where StaffID= " + SPid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff's Phone Successfully Deleted");
                Con.Close();
                populate();

            }
        }
    }
}
