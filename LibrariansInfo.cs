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
    public partial class LibrariansForm : Form
    {
        // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mr-m-\Documents\MyLibraryDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");

        LibraryStaff staff = new LibraryStaff();
        public LibrariansForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LibrariansForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from StaffInfo";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LibrarianDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           x:

            if (Staff_id.Text == "" || StFname.Text == "" || stfLname.Text == "" || is_Admin.Text == "" || StfLogin.Text == "" || salary.Text == "" || staffEmail.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                if (EmailValidation(staffEmail.Text))
                {

                }
                else
                {
                    
                    staffEmail.Text = "";
                    goto x;
                }
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into StaffInfo values (" + Staff_id.Text.ToString() + ",'" + StFname.Text.ToString() + "','" + stfLname.Text.ToString() + "','" + is_Admin.Text.ToString() + "','" + StfLogin.Text.ToString() + "','" + staffSalary.Text.ToString() + "','" + staffEmail.Text.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Staff Added Successfully");
                Con.Close();
                populate();
                //if (EmailValidation(staffEmail.Text))
                //{
                    
                //}
                
               
                //   IsValidEmail(staffEmail.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            if (Staff_id.Text == "")
            {
                MessageBox.Show("Enter the Staff ID");

            }
            else
            {
               


                Con.Open();
                string query = "Delete from StaffInfo where StaffID= " + Staff_id.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Successfully Deleted");
                Staff_id.Text = "";
                Con.Close();
                populate();

            }
        }

        private void LibrarianDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Staff_id.Text = LibrarianDGV.SelectedRows[0].Cells[0].Value.ToString();
            //StFname.Text = LibrarianDGV.SelectedRows[0].Cells[1].Value.ToString();
            //stfLname.Text = LibrarianDGV.SelectedRows[0].Cells[2].Value.ToString();
            //is_Admin.Text = LibrarianDGV.SelectedRows[0].Cells[3].Value.ToString();
            //StfLogin.Text = LibrarianDGV.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            x:
            if (Staff_id.Text == "" || StFname.Text == "" || stfLname.Text == "" || is_Admin.Text == "" || StfLogin.Text == "" || salary.Text == "" || staffEmail.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                if (EmailValidation(staffEmail.Text))
                {

                }
                else
                {

                    staffEmail.Text = "";
                    goto x;
                }
                Con.Open();
                string query = "Update StaffInfo set StFname= '" + StFname.Text + "',StLname='" + stfLname.Text + "',isAdmin='" + is_Admin.Text + "',LoginID='" + StfLogin.Text + "',Salary='" + staffSalary.Text + "',Email='" + staffEmail.Text + "' where StaffID=" + Staff_id.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Successfully Updated");
                Con.Close();
                populate();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = staff.showSalary2();
            if (dt.Rows.Count > 0)
            {
                LibrarianDGV.DataSource = dt;

            }
            else
            {
                LibrarianDGV.DataSource = null;
            }

            //populate();

            //MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            //sqlCon.Open();
            //MyLibrary.LibraryStaff.salaryOrder();
            //sqlCon.Close();

            //try
            //{
            //    MyLibrary.DataAccessLayer sqlCon2 = new MyLibrary.DataAccessLayer();
            //    sqlCon2.Open();
            //    MyLibrary.LibraryStaff.salaryOrder();
            //    sqlCon2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid Operation ");
            //    MessageBox.Show(ex.Message);
            //}


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Staff_id.Text = "";
            is_Admin.Text = "";
            StFname.Text = "";
            stfLname.Text = "";
            StfLogin.Text = "";
            staffSalary.Text = "";
            staffEmail.Text = "";



        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Phone main = new Staff_Phone();
            main.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Address main = new Staff_Address();
            main.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Reader main = new Staff_Reader();
            main.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LibraryStaff staff = new LibraryStaff();
            Con.Open();
            staff.addStaff(Convert.ToInt32(Staff_id.Text), StFname.Text, stfLname.Text, is_Admin.Text, Convert.ToInt32(StfLogin.Text), Convert.ToInt32(staffSalary.Text), staffEmail.Text);
            MessageBox.Show("New Staff Member Added Successfully!!!");
            Con.Close();
            populate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LibraryStaff staff = new LibraryStaff();
            Con.Open();
            staff.updateStaff(Convert.ToInt32(Staff_id.Text), StFname.Text, stfLname.Text, is_Admin.Text, Convert.ToInt32(StfLogin.Text), Convert.ToInt32(staffSalary.Text), staffEmail.Text);
            MessageBox.Show("New Staff Member Updated Successfully!!!");
            Con.Close();
            populate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LibraryStaff staff = new LibraryStaff();
            Con.Open();
            staff.deleteStaff(Convert.ToInt32(Staff_id.Text));
            MessageBox.Show("New Staff Member Deleted Successfully!!!");
            Con.Close();
            populate();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            LibraryStaff staff = new LibraryStaff();
            DataTable dt = staff.showUsers();
            if (dt.Rows.Count > 0)
            {
                LibrarianDGV.DataSource = dt;

            }
            else
            {
                LibrarianDGV.DataSource = null;
            }
        }

        private void staffEmail_TextChanged(object sender, EventArgs e)
        {


            ////  IsValidEmail(staffEmail.Text);
            //  if (IsValidEmail(staffEmail.Text))
            //  {

            //  }
            //  else
            //  {
            //      MessageBox.Show("Email is in the wrong format");
            //      staffEmail.Text = "";
            //  }

        }


        //public bool IsValidEmail(string email)
        //{
        //    if (email.EndsWith('.')&&email.('@'))
        //    {

        //    }



        //char[] invalidEmail = new char[] {'@','%','&','*' };
        //foreach (var x in invalidEmail)
        //{
        //    if (email.Contains(x))
        //    {
        //        return true;
        //    }

        //}
        //return false;

        //if (email.Contains('@'))
        //{
        //    return true;
        //}
        //return false;
        //}

        private void staffEmail_Leave(object sender, EventArgs e)
        {
            string email=staffEmail.Text;
            string pattern = "^([0 - 9a - zA - Z] ([-\\\\w][0 - 9a - zA - Z]) *@([0 - 9a - zA - Z][-\\w] *[0 - 9a - zA - Z]\\.)+[a - zA - Z]{ 2,9})$";
            if (Regex.IsMatch(staffEmail.Text, pattern)|| email.Contains('@'))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.staffEmail, "Please provide a valid email address");
                
                return;
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


    }
}
