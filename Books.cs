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
    public partial class Books : Form
    {
        public Books()
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
            string query = "select * from BookInfo";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BNo.Text == "" || BTitle.Text == "" || BAutherNO.Text == "" || BGenre.Text == "" || BPrice.Text == "" || BQuantity.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Con.Open();
                //  SqlCommand cmd = new SqlCommand("Insert into BooksTbl values (" + BNo.Text + "','" + BTitle.Text + "','" + BAuthorName.Text + "','" + BGenre.SelectedItem + "','" + BPrice.Text + BQuantity.Text + "','" + "')", Con);
                SqlCommand cmd = new SqlCommand("Insert into BookInfo values (" + BNo.Text + ",'" + BEdition.Text + "','" + BGenre.SelectedItem + "','" + BTitle.Text + "','" + BStaff_id.Text + "','"+ BUser_id.Text + "','"+ BBorrower_id.Text+ "','" +BPublisher_id.Text+ "','"+BAutherNO.Text+ "','"+BPrice.Text+ "','"+BQuantity.Text+ "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully");
                Con.Close();
               populate();



            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (BNo.Text == "")
            {
                MessageBox.Show("Enter the Book Number");

            }
            else
            {
                Con.Open();
                string query = "Delete from BookInfo where BookNo= " + BNo.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Deleted");
                Con.Close();
                populate();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BNo.Text == "" || BTitle.Text == "" || BAutherNO.Text == "" || BGenre.Text == "" || BPrice.Text == "" || BQuantity.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                string query = "Update BookInfo set Title= '" + BTitle.Text + "',AuthorID='" + BAutherNO.Text + "',Genre='" + BGenre.Text + "',Edition='"+BEdition.Text+ "',StaffID='"+BStaff_id.Text+ "',UserID='"+BUser_id.Text+ "',PublisherID='"+BPublisher_id.Text+ "',BorrowerID='"+BBorrower_id.Text+ "',Price='" + BPrice.Text + "',Quantity='" + BQuantity.Text + "' where BookNo=" + BNo.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Updated");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BNo.Text = "";
            BTitle.Text = "";
            BAutherNO.Text = "";
            BGenre.Text = "";
            BPrice.Text = "";
            BQuantity.Text = "";
            BEdition.Text = "";
            BStaff_id.Text = "";
            BBorrower_id.Text = "";
            BUser_id.Text = "";
            BPublisher_id.Text = "";
            
        }

        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
         //   test1.Text = MyLibrary.LibraryBooks.addnewBook(10, "2000", "de7k", "comedy", 50, 48, 3, 1, 2, 1, 1).ToString();
        }

        private void test1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            LibraryBooks books = new LibraryBooks();
                Con.Open();
                books.addBook(Convert.ToInt32(BNo.Text), BEdition.Text, BTitle.Text, BGenre.Text, Convert.ToInt32(BAutherNO.Text), Convert.ToInt32(BPrice.Text), Convert.ToInt32(BQuantity.Text), Convert.ToInt32(BStaff_id.Text), Convert.ToInt32(BUser_id.Text), Convert.ToInt32(BBorrower_id.Text), Convert.ToInt32(BPublisher_id.Text));
            MessageBox.Show("New Book Added Successfully!!!");
                Con.Close();
            populate();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid Operation ");
            //    MessageBox.Show(ex.Message);
            //}
            // MyLibrary.LibraryBooks.addBook();

            // books.addBook(Convert.ToInt32(bookNum.Text), Edition.Text, bookTitle.Text, bookGenre.Text, Convert.ToInt32(authorNum.Text), Convert.ToInt32(bookPrice.Text), Convert.ToInt32(bookQuantity.Text), Convert.ToInt32(bookStaffID.Text), Convert.ToInt32(bookUserID.Text), Convert.ToInt32(bookBorrowerID.Text), Convert.ToInt32(bookPublisherID.Text));

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LibraryBooks books = new LibraryBooks();
            Con.Open();
            books.updateBook(Convert.ToInt32(BNo.Text), BEdition.Text, BTitle.Text, BGenre.Text, Convert.ToInt32(BAutherNO.Text), Convert.ToInt32(BPrice.Text), Convert.ToInt32(BQuantity.Text), Convert.ToInt32(BStaff_id.Text), Convert.ToInt32(BUser_id.Text), Convert.ToInt32(BBorrower_id.Text), Convert.ToInt32(BPublisher_id.Text));
            MessageBox.Show("New Book Updated Successfully!!!");
            Con.Close();
            populate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LibraryBooks books = new LibraryBooks();
            Con.Open();
           // books.deleteBook(Convert.ToInt32(BNo.Text), BEdition.Text, BTitle.Text, BGenre.Text, Convert.ToInt32(BAutherNO.Text), Convert.ToInt32(BPrice.Text), Convert.ToInt32(BQuantity.Text), Convert.ToInt32(BStaff_id.Text), Convert.ToInt32(BUser_id.Text), Convert.ToInt32(BBorrower_id.Text), Convert.ToInt32(BPublisher_id.Text));
            books.deleteBook(Convert.ToInt32(BNo.Text));
            MessageBox.Show("New Book Deleted Successfully!!!");
            Con.Close();
            populate();
        }

        private void BBorrower_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
