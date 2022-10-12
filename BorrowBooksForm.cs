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
    public partial class BorrowBooksForm : Form
    {
        public BorrowBooksForm()
        {
            InitializeComponent();
        }
        // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mr-m-\Documents\MyLibraryDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");

        private void FillReader()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select BorrowerID from BorrowerInfo", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BorrowerID", typeof(int));
            dt.Load(rdr);

            BID.Text = "BorrowerID";
            BID.DataSource = dt;

            Con.Close();

        }

        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select Title from BookInfo where Quantity>" + 0 + "", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Load(rdr);

            BKName.ValueMember = "Title";
            BKName.DataSource = dt;

            Con.Close();

        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void populate()
        {
            Con.Open();
            string query = "select * from BorrowerInfo";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            BID.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void FetchReaderData()
        {
            
            Con.Open();
          ////  x:
            string query = "Select * from BorrowerInfo where BorrowerID= " +BID.Text.ToString()+" ";
            SqlCommand cmd = new SqlCommand(query,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BRFName.Text = dr["BrFname"].ToString();
                BRLname.Text = dr["BrLname"].ToString();

            }


         //   goto x;
            Con.Close();
            
        }
        //private void IssuedBy()
        //{
        //    Con.Open();
        //    string query = "Select * from BorrowerInfo where IssuedBy='" + cbIssuedBy.SelectedValue.ToString() + "'";
        //    SqlCommand cmd = new SqlCommand(query, Con);
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        cbIssuedBy.SelectedValue = dr["IssuedBy"].ToString();
        //       // BRLname.Text = dr["BrLname"].ToString();

        //    }

        //    Con.Close();
        //}

        private void UpdateBook()
        {
            int Qty,newQty;
            Con.Open();
            string query = "Select * from BookInfo where Title='" + BKName.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Quantity"].ToString());
                newQty = Qty - 1;
                string query1 = "Update BookInfo set Quantity=" +newQty+ " where Title='" + BKName.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1,Con);
                cmd1.ExecuteNonQuery();
                //Quantity decrement not working idk why smh
                //Quantity goes to ZERO after error anddd goes to the Price column tf
                //okay all done
                
               //  = "update BookTbl set Qty=" + newQtya" where BookName='" + Bookcb.SelectedValue.Tostring() + "'"I

            }
            Con.Close();
        }

        //private void UpdateBookCancellation()
        //{
        //    int Qty, newQty;
        //    Con.Open();
        //    string query = "Select * from BookInfo where Title='" + BKName.SelectedItem.ToString() + "'";
        //    SqlCommand cmd = new SqlCommand(query, Con);
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        Qty = Convert.ToInt32(dr["Quantity"].ToString());
        //        newQty = Qty + 1;
        //        string query1 = "Update BookInfo set Quantity=" + newQty + " where Title='" + BKName.SelectedItem.ToString() + "';";
        //        SqlCommand cmd1 = new SqlCommand(query1, Con);
        //        cmd1.ExecuteNonQuery();
        //        //Quantity decrement not working idk why smh
        //        //Quantity goes to ZERO after error anddd goes to the Price column tf
        //        //okay all done

        //        //  = "update BookTbl set Qty=" + newQtya" where BookName='" + Bookcb.SelectedValue.Tostring() + "'"I

        //    }
        //    Con.Close();
        //}


            private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BorrowBooksForm_Load(object sender, EventArgs e)
        {
            FillReader();
            FillBook();
            populate();
            //IssuedBy();
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

        private void BorrowerID_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void BorrowerID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchReaderData();
        }

        private void BorrowNo_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void BorrowDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          ////  BRNo.Text = BorrowDGV.SelectedRows[0].Cells[0].Value.ToString();
          //  BKName.SelectedItem = BID.SelectedRows[0].Cells[1].Value.ToString();
          //  BID.SelectedItem = BID.SelectedRows[0].Cells[2].Value.ToString();
          //  BRFName.Text = BID.SelectedRows[0].Cells[3].Value.ToString();
          ////  borrowFromdate.Text = BorrowDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void BRDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (BID.Text == "")
            //{
            //    MessageBox.Show("Enter the Borrower ID");

            //}
            //else
            //{
            //    Con.Open();
            //    string query = "Delete from BorrowerInfo where BorrowerID= " + BID.Text + ";";
            //    SqlCommand cmd = new SqlCommand(query, Con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Borrow Successfully Cancelled");
            //    Con.Close();
            // //   UpdateBookCancellation();
            //    populate();

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Bissued_TextChanged(object sender, EventArgs e)
        {

        }

        private void BRNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (BID.Text == "" ||Bissued.Text == "" || borrowTo.Text == "" || borrowFrom.Text == "" || actual.Text == "" || BRFName.Text == "" || BRLname.Text == "")
            //{
            //    MessageBox.Show("Missing Information");
            //}
            //else
            //{
               
            //    Con.Open();
            //    string query = "Update BorrowerInfo set IssuedBy= '" + Bissued.Text + "',BorrowToDate='" +borrowTo.Text + "',BorrowFromDate='" + borrowFrom.Text + "',ActualReturnDate='" + actual.Text + "',BrFname='" + BRFName.Text + "',BrLname='" + BRLname.Text + "' where BorrowerID=" + BID.Text + ";";
            //    SqlCommand cmd = new SqlCommand(query, Con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Borrow Successfully Updated");
            //    Con.Close();
            //    populate();

            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LibraryBorrowers borrowers = new LibraryBorrowers();
            Con.Open();
            // borrowers.addBorrower(Convert.ToInt32(BID.Text), borrowFrom.Text, borrowTo.Text, actual.Text, BRFName.Text, BRLname.Text);
            borrowers.addBorrower(Convert.ToInt32(borrowerID.Text), borrowFrom.Text, borrowTo.Text, actual.Text, BRFName.Text, BRLname.Text, Bissued.Text,BEmail.Text);
            MessageBox.Show("New Borrower Added Successfully!!!");
            Con.Close();
            populate();
            // working 
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            BRFName.Text = "";
            BRLname.Text = "";
            borrowTo.Text = "";
            borrowFrom.Text = "";
            actual.Text = "";
            Bissued.Text = "";
            borrowerID.Text = "";
            BRFName.Text = "";
            BEmail.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x:
            if (BID.Text.ToString() == "" || BRFName.Text == ""||BEmail.Text=="")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                if (EmailValidation(BEmail.Text))
                {

                }
                else
                {

                    BEmail.Text = "";
                    goto x;
                }


                //     string brTodate = borrowToDate.Value.Day.ToString() + "/" + borrowToDate.Value.Month.ToString() + "/" + borrowToDate.Value.Year.ToString();
                //     string brFromdate = borrowFromdate.Value.Day.ToString() + "/" + borrowFromdate.Value.Month.ToString() + "/" + borrowFromdate.Value.Year.ToString();
                //     string actualDate = actualRdate.Value.Day.ToString() + "/" + actualRdate.Value.Month.ToString() + "/" + actualRdate.Value.Year.ToString();
                Con.Open();

                //SqlCommand cmd = new SqlCommand("Insert into BorrowerInfo values (" + BID.Text.ToString() + ",'" + Bissued.Text.ToString() + "','" + borrowTo.ToString() + "','" + borrowFrom.ToString() + "','" + actual.ToString() + "','" + BRFName.Text.ToString() + "','" + BRLname.Text.ToString() + "')", Con); 
                // SqlCommand cmd = new SqlCommand("Insert into BorrowerInfo values (" + BID.Text + ",'" + Bissued.Text + "','" + borrowTo.Text + "','" + borrowFrom.Text + "','" + actual.Text + "','" + BRFName.Text + "','" + BRLname.Text + "','" + borrowerEmail.Text + "')", Con);

                //SqlCommand cmd = new SqlCommand("Insert into BorrowerInfo values (" + borrowerID.Text + ",'" + Bissued.Text + "','" + borrowTo.Text + "','" + borrowFrom.Text + "','"+ actual.Text + "','" + BRFName.Text + "','" + BRLname.Text + "','" + "')", Con);
                SqlCommand cmd = new SqlCommand("Insert into BorrowerInfo values (@BID,@IssuedBy,@ToDate,@FromDate,@ActualDate,@FName,@LName,@BEmail)", Con);
                cmd.Parameters.AddWithValue("@BID",int.Parse(borrowerID.Text));
                cmd.Parameters.AddWithValue("@IssuedBy",Bissued.Text);
                cmd.Parameters.AddWithValue("@ToDate", borrowTo.Text);
                cmd.Parameters.AddWithValue("@FromDate", borrowFrom.Text);
                cmd.Parameters.AddWithValue("@ActualDate", actual.Text);
                cmd.Parameters.AddWithValue("@FName", BRFName.Text);
                cmd.Parameters.AddWithValue("@LName", BRLname.Text);
                cmd.Parameters.AddWithValue("@BEmail", BEmail.Text);
                cmd.ExecuteNonQuery();
           
                MessageBox.Show("Book Borrowed Successfully");
                Con.Close();
                UpdateBook();
                populate();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x:
            if (BID.Text == "" || Bissued.Text == "" || borrowTo.Text == "" || borrowFrom.Text == "" || actual.Text == "" || BRFName.Text == "" || BRLname.Text == ""||BEmail.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (EmailValidation(BEmail.Text))
                {

                }
                else
                {

                    BEmail.Text = "";
                    goto x;
                }

                Con.Open();
               // string query = "Update BorrowerInfo set IssuedBy= '";
                SqlCommand cmd = new SqlCommand("Update BorrowerInfo set IssuedBy=@IssuedBy, BorrowToDate=@ToDate, BorrowFromDate=@FromDate, ActualReturnDate=@ActualDate, BrFname=@FName, BrLname=@LName, BorrowerEmail=@BEmail where BorrowerID=@BID", Con);
                cmd.Parameters.AddWithValue("@BID", int.Parse(borrowerID.Text));
                cmd.Parameters.AddWithValue("@IssuedBy", Bissued.Text);
                cmd.Parameters.AddWithValue("@ToDate", borrowTo.Text);
                cmd.Parameters.AddWithValue("@FromDate", borrowFrom.Text);
                cmd.Parameters.AddWithValue("@ActualDate", actual.Text);
                cmd.Parameters.AddWithValue("@FName", BRFName.Text);
                cmd.Parameters.AddWithValue("@LName", BRLname.Text);
                cmd.Parameters.AddWithValue("@BEmail", BEmail.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Borrow Successfully Updated");
                Con.Close();
                populate();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (borrowerID.Text == "")
            {
                MessageBox.Show("Enter the Borrower ID");

            }
            else
            {
                Con.Open();
                string query = "Delete from BorrowerInfo where BorrowerID= " + borrowerID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Borrow Successfully Deleted");
                Con.Close();
                populate();

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LibraryBorrowers borrowers = new LibraryBorrowers();
            Con.Open();
            // borrowers.addBorrower(Convert.ToInt32(BID.Text), borrowFrom.Text, borrowTo.Text, actual.Text, BRFName.Text, BRLname.Text);
            borrowers.deleteBorrower(Convert.ToInt32(borrowerID.Text));
            MessageBox.Show("New Borrower Deleted Successfully!!!");
            Con.Close();
            populate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LibraryBorrowers borrowers = new LibraryBorrowers();
            Con.Open();
            // borrowers.addBorrower(Convert.ToInt32(BID.Text), borrowFrom.Text, borrowTo.Text, actual.Text, BRFName.Text, BRLname.Text);
            borrowers.updateBorrower(Convert.ToInt32(borrowerID.Text),borrowFrom.Text,borrowTo.Text,actual.Text,BRFName.Text,BRLname.Text,Bissued.Text,BEmail.Text);
            MessageBox.Show("New Borrower Updated Successfully!!!");
            Con.Close();
            populate();

            //done
        }

        private void BEmail_Leave(object sender, EventArgs e)
        {
            string email = BEmail.Text;
            string pattern = "^([0 - 9a - zA - Z] ([-\\\\w][0 - 9a - zA - Z]) *@([0 - 9a - zA - Z][-\\w] *[0 - 9a - zA - Z]\\.)+[a - zA - Z]{ 2,9})$";
            if (Regex.IsMatch(BEmail.Text, pattern) || email.Contains('@'))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.BEmail, "Please provide a valid email address");

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

        private void BKName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void borrowFrom_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void borrowFrom_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(borrowFrom, "Format:YYYY-MM-DD");
        }

        private void borrowTo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(borrowTo, "Format:YYYY-MM-DD");
        }

        private void actual_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(actual, "Format:YYYY-MM-DD");
        }
    }
}
