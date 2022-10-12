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
    public partial class PublisherDGV : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");
        // MyLibrary.DataAccessLayer conn = new MyLibrary.DataAccessLayer("server=DESKTOP-QSG3N0B;database=LibraryMS;Integrated Security=true");
        


        public PublisherDGV()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from PublisherInfo";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PublishersDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LibraryBooks books = new LibraryBooks();


            DataTable dt = books.showPublishers();
            if (dt.Rows.Count > 0)
            {
                PublishersDGV.DataSource = dt;

            }
            else
            {
                PublishersDGV.DataSource = null;
            }



            //MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            //sqlCon.Open();
            //MyLibrary.LibraryBooks.showPublishers();
            //sqlCon.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Pid.Text == "" || YearOFpublish.Text == "" || Pname.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                //SqlCommand cmd = new SqlCommand("Insert into ReadersTbl values (" + BUser_id.Text + ",'" + RdrFname.Text + "','" + RdrLname.Text + "','" + RdrEmail.Text, Con);
                SqlCommand cmd = new SqlCommand("Insert into PublisherInfo values (" + Pid.Text + ",'" + YearOFpublish.Text + "','" + Pname.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Publisher Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Publisher_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Pid.Text == "" || YearOFpublish.Text == "" || Pname.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "Update PublisherInfo set YearofPublish= '" + YearOFpublish.Text + "',PublisherName='" + Pname.Text + "' where PublisherID=" + Pid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Publisher Successfully Updated");
                Con.Close();
                populate();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Pid.Text == "")
            {
                MessageBox.Show("Enter the Publisher ID");

            }
            else
            {
                Con.Open();
                string query = "Delete from PublisherInfo where PublisherID= " + Pid.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Publisher Successfully Deleted");
                Con.Close();
                populate();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pid.Text = "";
            YearOFpublish.Text = "";
            Pname.Text = "";
        }

        private void Pname_MouseHover(object sender, EventArgs e)
        {

        }

        private void YearOFpublish_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(YearOFpublish, "Format:YYYY-MM-DD");
        }
    }
}
