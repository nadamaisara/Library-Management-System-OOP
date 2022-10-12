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
    public partial class Reports : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");
        public Reports()
        {
            InitializeComponent();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from Reports";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReportsDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Reg_no.Text == "" || RissueDate.Text == "" || RUser_id.Text == "" || Rbook_no.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                //SqlCommand cmd = new SqlCommand("Insert into ReadersTbl values (" + BUser_id.Text + ",'" + RdrFname.Text + "','" + RdrLname.Text + "','" + RdrEmail.Text, Con);
                // SqlCommand cmd = new SqlCommand("Insert into Reports values (" + Reg_no.Text + ",'" + RissueDate.Text + ",'" +RUser_id.Text + ",'"+Rbook_no.Text  + "')", Con);
                SqlCommand cmd = new SqlCommand("Insert into Reports values (" + Reg_no.Text + ",'" + RissueDate.Text + "','" + RUser_id.Text + "','" + Rbook_no.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Report Added Successfully");
                if (suggestions.Text != "")
                {
                    MessageBox.Show("Thank you for your suggestions. We are looking forward to improve our performance!");

                }
                Con.Close();
                populate();

                // working
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Reg_no.Text == "")
            {
                MessageBox.Show("Enter the Register Number");

            }
            else
            {
                Con.Open();
                string query = "Delete from Reports where RegisterNo= " + Reg_no.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Report Successfully Deleted");
                Reg_no.Text = "";
               
                Con.Close();
                populate();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Reg_no.Text == "" || RissueDate.Text == "" || RUser_id.Text == "" || Rbook_no.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "Update Reports set Issue_ReturnDate= '" + RissueDate.Text + "',UserID='" + RUser_id.Text + "',BookNo='" + Rbook_no.Text + "' where RegisterNo=" + Reg_no.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Report Successfully Updated");
                // MessageBox.Show("Thank you for your suggestions. We are looking forward to improve our performance!");
                if (suggestions.Text != "")
                {
                    MessageBox.Show("Thank you for your suggestions. We are looking forward to improve our performance!");

                }
                Con.Close();
                populate();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reg_no.Text = "";
            RUser_id.Text = "";
            RissueDate.Text = "";
            Rbook_no.Text = "";
            suggestions.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryStaff staff = new LibraryStaff();
            DataTable dt = staff.showUsers();
            if (dt.Rows.Count > 0)
            {
                ReportsDGV.DataSource = dt;

            }
            else
            {
                ReportsDGV.DataSource = null;
            }
        }

        private void Reg_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void RissueDate_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(RissueDate, "Format:YYYY-MM-DD");
        }
    }
}
