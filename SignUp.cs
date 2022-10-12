using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MyLibrary
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mr-m-\Documents\MyLibraryDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");
        private void SingUp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            AuthenticationID.Text = "";
            password.Text = "";
            Email.Text = "";
            phoneNum.Text = "";
            confirmPass.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MyLibrary.LoginForm login = new MyLibrary.LoginForm();
            //login.Show();
            //insert into values blabla

            Regex ex = new Regex("^[0-9]{11}");
            bool isValid = ex.IsMatch(phoneNum.Text);
            if (!isValid)
            {
                MessageBox.Show("Please Enter a Valid Phone Number");
                phoneNum.Text = "";
            }


            if (password.Text != confirmPass.Text)
                {

            
               
                 MessageBox.Show( " Password is not matching \n Please Enter The Password Again ");

                 password.Text = "";
                confirmPass.Text = "";
                
            }
            else
            {
         
            x:
             
                if (AuthenticationID.Text == "" || Email.Text == "" || password.Text == "" || confirmPass.Text == "" || phoneNum.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    if (EmailValidation(Email.Text))
                    {

                    }
                    else
                    {

                        Email.Text = "";
                        goto x;
                    }
                

                    Con.Open();



                    // SqlCommand command = new SqlCommand("Insert into StaffInfo values (" + staffid.Text+ ",'"+ firstName.Text+ "','" + LastName.Text+ "','" + isadmin.SelectedItem+ "','" + AuthenticationID.Text+ "','" + salarytxt.Text+ "','" + Email.Text + "','" + Convert.ToInt64(phoneNum.Text)+ "')", Con);



                    //command.ExecuteNonQuery();
                    LibraryStaff staff = new LibraryStaff();

                   // staff.addStaff(Convert.ToInt32(staffid.Text),firstName.Text,LastName.Text,isadmin.Text,Convert.ToInt32(AuthenticationID.Text),Convert.ToInt32(salarytxt.Text),Email.Text);
                   
                    SqlCommand cmd = new SqlCommand("Insert into Authentication values (" + AuthenticationID.Text + ",'" + LibraryStaff.Hash_SHA1(password.Text) + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New User Added Successfully");
                    Con.Close();
                    //  populate();

                    
                    
                }

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

      //  public static bool IsPhoneNumber(string number)
     //   {
            //if (number.Contains(@"^(\+[0-9]{9})$"))
            //{
            //    return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Phone Number");
            //    return false;
            //}

            //return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
            //Convert.ToChar(number);
            //if (number < '0' || number > '9')
            //{
            //    return true;
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Phone Number");
            //    number = "";
            //   return false;

            //}


       // }


        //public static bool IsPhoneNumber(string number)
        //{
        //    if (number.Contains('@'))        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid Email");
        //        return false;
        //    }
        //}

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyLibrary.LoginForm login = new MyLibrary.LoginForm();
            login.Show();
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked == true)
            {
                password.UseSystemPasswordChar = false;

            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void cbConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConfirm.Checked == true)
            {
                confirmPass.UseSystemPasswordChar = false;

            }
            else
            {
                confirmPass.UseSystemPasswordChar = true;
            }
        }

        private void SignUp_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void UserName_MouseClick(object sender, MouseEventArgs e)
        {
            AuthenticationID.Text = "";

        }

        private void phoneNum_MouseClick(object sender, MouseEventArgs e)
        {
            phoneNum.Text = "";
        }

        private void Email_MouseClick(object sender, MouseEventArgs e)
        {
            Email.Text = "";
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            password.Text = "";
        }

        private void confirmPass_MouseClick(object sender, MouseEventArgs e)
        {
            confirmPass.Text = "";
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Leave(object sender, EventArgs e)
        {
            string email = Email.Text;
            string pattern = "^([0 - 9a - zA - Z] ([-\\\\w][0 - 9a - zA - Z]) *@([0 - 9a - zA - Z][-\\w] *[0 - 9a - zA - Z]\\.)+[a - zA - Z]{ 2,9})$";
            if (Regex.IsMatch(Email.Text, pattern) || email.Contains('@'))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.Email, "Please provide a valid email address");

                return;
            }
        }

        private void phoneNum_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNum_Leave(object sender, EventArgs e)
        {
            string phone = phoneNum.Text;
            //string pattern = @"^(\+[0-9]{11})$";
            if (Regex.IsMatch(phone, "^[0-9]{11}"))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.phoneNum, "Invalid Input of Phone Number");

                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthenticationID_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_MouseClick(object sender, MouseEventArgs e)
        {
            firstName.Text = "";
        }

        private void LastName_MouseClick(object sender, MouseEventArgs e)
        {
            LastName.Text = "";
        }

        private void salarytxt_MouseClick(object sender, MouseEventArgs e)
        {
            salarytxt.Text = "";
        }

        private void staffid_MouseClick(object sender, MouseEventArgs e)
        {
            staffid.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

