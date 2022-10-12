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

namespace MyLibrary
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckPassword(Password.Text))
            { 
                Con.Open();
               
                    this.Hide();
                    MainForm main = new MainForm();
                    main.Show();
            }
            else
            {
                MessageBox.Show("Wrong ID or Password");
                Password.Text = "";
            }

            Con.Close();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            loginid.Text = "";
            Password.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            //sqlCon.Open();
            //MyLibrary.LibraryStaff.changePassword();
            //sqlCon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            


            //MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            //sqlCon.Open();
            //MyLibrary.LibraryStaff.getAllUsers();
            //sqlCon.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show.Checked==true)
            {
                Password.UseSystemPasswordChar = false;

            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void loginid_MouseClick(object sender, MouseEventArgs e)
        {
            loginid.Text = "";
        }

        private void Password_MouseClick(object sender, MouseEventArgs e)
        {
            Password.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        public static bool CheckPassword(string password)
        {
            string hash;
            hash = LibraryStaff.Hash_SHA1(password);
            if (hash == LibraryStaff.Hash_SHA1(password))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Incorrect Password");
                return false;
            }

        }

    }
}
