using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace MyLibrary
{
    public partial class ReaderInfo : Form
    {
        public ReaderInfo()
        {
            InitializeComponent();
        }
        //  SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mr-m-\Documents\MyLibraryDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        public void populate()
        {
            Con.Open();
            string query = "select * from ReaderInfo";
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

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x:
            if (BUser_id.Text == "" || RdrFname.Text == "" || RdrLname.Text == "" || RdrEmail.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                if (EmailValidation(RdrEmail.Text))
                {

                }
                else
                {

                    RdrEmail.Text = "";
                    goto x;
                }


                Con.Open();
                //SqlCommand cmd = new SqlCommand("Insert into ReadersTbl values (" + BUser_id.Text + ",'" + RdrFname.Text + "','" + RdrLname.Text + "','" + RdrEmail.Text, Con);
                  SqlCommand cmd = new SqlCommand("Insert into ReaderInfo values (" + BUser_id.Text + ",'" + RdrFname.Text + "','" + RdrLname.Text + "','" + RdrEmail.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reader Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BUser_id.Text == "")
            {
                MessageBox.Show("Enter the Reader ID");

            }
            else
            {
                Con.Open();
                string query = "Delete from ReaderInfo where UserID= " + BUser_id.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();  
                MessageBox.Show("Reader Successfully Deleted");
                Con.Close();
                populate();

            }
        }

        public bool EmailValidation(string email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Email");
                return false;
            }


        }

        private void ReadersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //BUser_id.Text = ReadersDGV.SelectedRows[0].Cells[0].Value.ToString();
            //RdrFname.Text = ReadersDGV.SelectedRows[0].Cells[1].Value.ToString();
            //RdrLname.Text = ReadersDGV.SelectedRows[0].Cells[2].Value.ToString();
            //RdrEmail.Text = ReadersDGV.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x:
            if (BUser_id.Text == "" || RdrFname.Text == "" || RdrLname.Text == "" ||  RdrEmail.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (EmailValidation(RdrEmail.Text))
                {

                }
                else
                {

                    RdrEmail.Text = "";
                    goto x;
                }
                Con.Open();
                string query = "Update ReaderInfo set RdFname= '" + RdrFname.Text + "',RdLname='" + RdrLname.Text + "',Remail='" + RdrEmail.Text + "' where UserID=" + BUser_id.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reader Successfully Updated");
                Con.Close();
                populate();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BUser_id.Text = "";
            RdrFname.Text = "";
            RdrLname.Text = "";
            RdrEmail.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LibraryReaders readers = new LibraryReaders();
            //try
            //{
            //  MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            Con.Open();
            readers.addReader(Convert.ToInt32(BUser_id.Text), RdrFname.Text, RdrLname.Text, RdrEmail.Text);
            MessageBox.Show("New Reader Added Successfully!!!");
            Con.Close();
            populate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LibraryReaders readers = new LibraryReaders();
            
            Con.Open();
            readers.updateReader(Convert.ToInt32(BUser_id.Text), RdrFname.Text, RdrLname.Text, RdrEmail.Text);
            MessageBox.Show("New Reader Updated Successfully!!!");
            Con.Close();
            populate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LibraryReaders readers = new LibraryReaders();
            
            Con.Open();
            readers.deleteReader(Convert.ToInt32(BUser_id.Text), RdrFname.Text, RdrLname.Text, RdrEmail.Text);
            MessageBox.Show("New Reader Deleted Successfully!!!");
            Con.Close();
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ReaderEmail_Leave(object sender, EventArgs e)
        {
           



        }

        private void RdrEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void RdrEmail_Leave(object sender, EventArgs e)
        {
            string email = RdrEmail.Text;
            string pattern = "^([0 - 9a - zA - Z] ([-\\\\w][0 - 9a - zA - Z]) *@([0 - 9a - zA - Z][-\\w] *[0 - 9a - zA - Z]\\.)+[a - zA - Z]{ 2,9})$";
            if (Regex.IsMatch(RdrEmail.Text, pattern) || email.Contains('@'))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.RdrEmail, "Please provide a valid email address");

                return;
            }
        }
    }
}



//DGV doesnt show automatically like video but it is not necessary (same in LibForm) 