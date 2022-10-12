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
    public partial class StoredProcedures : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");

        LibraryBooks books = new LibraryBooks();

        public StoredProcedures()
        {
            InitializeComponent();
        }

        

        public void populate()
        {
            Con.Open();
            string query = "select * from BookInfo";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            storedGrid.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void StoredProcedures_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ReadersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //LibraryBooks books = new LibraryBooks();
            DataTable dt = books.showComedyBooks2();
            if (dt.Rows.Count>0)
            {
                storedGrid.DataSource = dt;
                
            }
            else
            {
                storedGrid.DataSource = null;
            }
            
            
            
            
            
            
            // LibraryBooks librarybooks = new LibraryBooks();

           // MyLibrary.DataAccessLayer Con = new MyLibrary.DataAccessLayer();

           // Con.Open();
           // //string query = "select * from BookInfo";
           // SqlDataAdapter da = new SqlDataAdapter("showComedyBooks", Con);
           // SqlCommandBuilder builder = new SqlCommandBuilder(da);
           // var ds = new DataSet();
           // da.Fill(ds);
           // storedGrid.DataSource = ds.Tables[0];


           // librarybooks.showComedyBooks();
           // // test.Text =Convert.ToInt32(librarybooks.showComedyBooks());
           // test.Text = librarybooks.showComedyBooks().ToString();
           // Con.Close();
           //// populate();


           
            //  librarybooks.showComedyBooks();



            //   MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            //storedGrid.ClearSelection();



            // Con.Open();


            // test.Text=  MyLibrary.LibraryBooks.showComedyBooks().ToString();
            // string query = "select * from BookInfo";

            //SqlDataAdapter da = new SqlDataAdapter(librarybooks.showComedyBooks().ToString(), Con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(da);
            //var ds = new DataSet();
            //da.Fill(ds);
            //storedGrid.DataSource = ds.Tables[0];
            ////  test.Text = MyLibrary.LibraryBooks.showComedyBooks().ToString();
            //test.Text = da.Fill(ds).ToString();

            //try
            //{
           

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid Operation ");
            //    MessageBox.Show(ex.Message);
            //}



            //Con.Close();
           // populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = books.showMysteryBooks2();
            if (dt.Rows.Count > 0)
            {
                storedGrid.DataSource = dt;

            }
            else
            {
                storedGrid.DataSource = null;
            }


            //MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            //Con.Open();
            //MyLibrary.LibraryBooks.showMysteryBooks();

            //try
            //{
            //    MyLibrary.DataAccessLayer Con = new MyLibrary.DataAccessLayer();
            //    sqlCon.Open();
            //    MyLibrary.LibraryBooks.showMysteryBooks();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid Operation ");
            //    MessageBox.Show(ex.Message);
            //}
            //Con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {


            DataTable dt = books.showHorrorBooks2();
            if (dt.Rows.Count > 0)
            {
                storedGrid.DataSource = dt;

            }
            else
            {
                storedGrid.DataSource = null;
            }




            //   MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            // //  int loginID = int.Parse(loginid.Text);
            //  // string newPassword;
            //   sqlCon.Open();
            // //  string Query = $"execute sp_changePassword {loginID},{newPassword}";
            ////   SqlDataAdapter da = new SqlDataAdapter(Query,Con);
            //  // storedGrid.DataSource = da.Tables[0].Rows[0];
            //   SqlCommandBuilder builder = new SqlCommandBuilder(da);
            //   var ds = new DataSet();
            //   da.Fill(ds);
            //   storedGrid.DataSource = ds.Tables[0].Rows[0];

            //   // MyLibrary.LibraryBooks.showHorrorBooks();
            //   sqlCon.Close();
            // populate();

            //Con.Open();
            //try
            //{
            //    MyLibrary.DataAccessLayer Con = new MyLibrary.DataAccessLayer();
            //    Con.Open();
            //    MyLibrary.LibraryBooks.showHorrorBooks();
            //    Con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid Operation ");
            //    MessageBox.Show(ex.Message);
            //}
            //Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = books.showThrillerBooks2();
            if (dt.Rows.Count > 0)
            {
                storedGrid.DataSource = dt;

            }
            else
            {
                storedGrid.DataSource = null;
            }


            //MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            //sqlCon.Open();
            //MyLibrary.LibraryBooks.showThrillerBooks();
            //sqlCon.Close();


            //try
            //{
            //    MyLibrary.DataAccessLayer Con = new MyLibrary.DataAccessLayer();
            //    Con.Open();
            //    MyLibrary.LibraryBooks.showThrillerBooks();
            //    Con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid Operation ");
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = books.showPrice2();
            if (dt.Rows.Count > 0)
            {
                storedGrid.DataSource = dt;

            }
            else
            {
                storedGrid.DataSource = null;
            }



            //MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            //sqlCon.Open();
            //MyLibrary.LibraryBooks.highestLowestPrice();
            //sqlCon.Close();


            //try
            //{
            //    MyLibrary.DataAccessLayer sqlCon2 = new MyLibrary.DataAccessLayer();
            //    sqlCon2.Open();
            //    MyLibrary.LibraryBooks.highestLowestPrice();
            //    sqlCon2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid Operation ");
            //    MessageBox.Show(ex.Message);
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = books.showQuantity2();
            if (dt.Rows.Count > 0)
            {
                storedGrid.DataSource = dt;

            }
            else
            {
                storedGrid.DataSource = null;
            }


            //    MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
            //    sqlCon.Open();
            //    MyLibrary.LibraryBooks.showQuantity();
            //    sqlCon.Close();
            //}

            //private void button7_Click(object sender, EventArgs e)
            //{
            //    this.Hide();
            //    MainForm main = new MainForm();
            //    main.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string x= LibraryBooks.showComedyBooks().ToString();
            //comedyBooks.Text = x;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void test_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
