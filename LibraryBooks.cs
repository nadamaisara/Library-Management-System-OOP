using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyLibrary
{
    public class LibraryBooks
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");


       // SqlConnection sqlConnection = new SqlConnection();

          SqlCommand cmd;



        //public static void addnewBook(int bookNum, string Edition, string Title, string Genre, int authorID, int bookPrice,
        //    int bookQuantity, int staffID, int userID, int borrowerID, int publisherID)
        //{
        //    MyLibrary.DataAccessLayer sqlCon = new MyLibrary.DataAccessLayer();
        //    sqlCon.Open();

        //    DataAccessLayer.ExecuteNonQuery("dbo.addnewBook",
        //        DataAccessLayer.CreateParameters("@BookNo", SqlDbType.Int, bookNum),
        //        DataAccessLayer.CreateParameters("@Edition", SqlDbType.VarChar, Edition),
        //        DataAccessLayer.CreateParameters("@Title", SqlDbType.VarChar, Title),
        //        DataAccessLayer.CreateParameters("@Genre", SqlDbType.VarChar, Genre),
        //        DataAccessLayer.CreateParameters("@AuthorID", SqlDbType.Int, authorID),
        //        DataAccessLayer.CreateParameters("@BPrice", SqlDbType.Int, bookPrice),
        //        DataAccessLayer.CreateParameters("@BQuantity", SqlDbType.Int, bookQuantity),
        //        DataAccessLayer.CreateParameters("@StaffID", SqlDbType.Int, staffID),
        //        DataAccessLayer.CreateParameters("@UserID", SqlDbType.Int, userID),
        //        DataAccessLayer.CreateParameters("@BorrowerID", SqlDbType.Int, borrowerID),
        //        DataAccessLayer.CreateParameters("@PublisherID", SqlDbType.Int, publisherID)

        //        );
        //    sqlCon.Close();
        //}

        public LibraryBooks()
        {
           

        }



        //public static void deleteBook(int bookNum, string Edition, string Title, string Genre, int authorID, int bookPrice,
        //        int bookQuantity, int staffID, int userID, int borrowerID, int publisherID)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.deleteBook",
        //        DataAccessLayer.CreateParameters("@BookNo", SqlDbType.Int, bookNum),
        //        DataAccessLayer.CreateParameters("@Edition", SqlDbType.VarChar, Edition),
        //        DataAccessLayer.CreateParameters("@Title", SqlDbType.VarChar, Title),
        //        DataAccessLayer.CreateParameters("@Genre", SqlDbType.VarChar, Genre),
        //        DataAccessLayer.CreateParameters("@AuthorID", SqlDbType.Int, authorID),
        //        DataAccessLayer.CreateParameters("@BPrice", SqlDbType.Int, bookPrice),
        //        DataAccessLayer.CreateParameters("@BQuantity", SqlDbType.Int, bookQuantity),
        //        DataAccessLayer.CreateParameters("@StaffID", SqlDbType.Int, staffID),
        //        DataAccessLayer.CreateParameters("@UserID", SqlDbType.Int, userID),
        //        DataAccessLayer.CreateParameters("@BorrowerID", SqlDbType.Int, borrowerID),
        //        DataAccessLayer.CreateParameters("@PublisherID", SqlDbType.Int, publisherID)

        //        );
        //}
        //public static void updateBook(int bookNum, string Edition, string Title, string Genre, int authorID, int bookPrice,
        //        int bookQuantity, int staffID, int userID, int borrowerID, int publisherID)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.updateBook",
        //        DataAccessLayer.CreateParameters("@BookNo", SqlDbType.Int, bookNum),
        //        DataAccessLayer.CreateParameters("@Edition", SqlDbType.VarChar, Edition),
        //        DataAccessLayer.CreateParameters("@Title", SqlDbType.VarChar, Title),
        //        DataAccessLayer.CreateParameters("@Genre", SqlDbType.VarChar, Genre),
        //        DataAccessLayer.CreateParameters("@AuthorID", SqlDbType.Int, authorID),
        //        DataAccessLayer.CreateParameters("@BPrice", SqlDbType.Int, bookPrice),
        //        DataAccessLayer.CreateParameters("@BQuantity", SqlDbType.Int, bookQuantity),
        //        DataAccessLayer.CreateParameters("@StaffID", SqlDbType.Int, staffID),
        //        DataAccessLayer.CreateParameters("@UserID", SqlDbType.Int, userID),
        //        DataAccessLayer.CreateParameters("@BorrowerID", SqlDbType.Int, borrowerID),
        //        DataAccessLayer.CreateParameters("@PublisherID", SqlDbType.Int, publisherID)

        //        );
        //}
        //public DataSet showComedyBooks()
        //{
        //    // MyLibrary.DataAccessLayer Con = new MyLibrary.DataAccessLayer();

        //    //Con.Open();
        //    // return DataAccessLayer.GetDataSet("showComedyBooks", "dbo.BookInfo");
        //    // Con.Close();

        //    //SqlCommand cmd = new SqlCommand("showComedyBooks", Con);
        //    //cmd.CommandType = CommandType.Text;
        //    //string query = "execute showComedyBooks";
        //    //cmd.CommandText = query;
           


        //   // Con.Open();
        //   // cmd.ExecuteNonQuery();
        //   //// return DataAccessLayer.GetDataSet("showComedyBooks", "BookInfo");
        //   // Con.Close();
        //   // return DataAccessLayer.GetDataSet("showComedyBooks", "BookInfo");

        //}




        //public static DataSet showHorrorBooks()
        //{
        //    return DataAccessLayer.GetDataSet("showHorrorBooks", "dbo.BookInfo");
        //}

        //public static DataSet showMysteryBooks()
        //{
        //    return DataAccessLayer.GetDataSet("showMysteryBooks", "dbo.BookInfo");
        //}
        //public static DataSet showThrillerBooks()
        //{
        //    return DataAccessLayer.GetDataSet("dbo.showThrillerBooks", "dbo.BookInfo");
        //}
        //public static DataSet showQuantity()
        //{
        //    return DataAccessLayer.GetDataSet("dbo.showQuantity", "dbo.BookInfo.");
        //}
        //public static DataSet highestLowestPrice()
        //{
        //    return DataAccessLayer.GetDataSet("dbo.Highest_LowestPrice", "dbo.BookInfo");
        //}

        //public static DataSet showPublishers()
        //{
        //    return DataAccessLayer.GetDataSet("dbo.showPublishers", "dbo.PublisherInfo");
        //}


        

        public void addBook(int bookNum, string Edition, string Title, string Genre, int authorID, int bookPrice,
          int bookQuantity, int staffID, int userID, int borrowerID, int publisherID)
        {
            SqlCommand cmd = new SqlCommand("addnewBook",Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("BookNo", bookNum);
            cmd.Parameters.AddWithValue("Edition", Edition);
            cmd.Parameters.AddWithValue("Title", Title);
            cmd.Parameters.AddWithValue("Genre", Genre);
            cmd.Parameters.AddWithValue("AuthorID", authorID);
            cmd.Parameters.AddWithValue("BPrice", bookPrice);
            cmd.Parameters.AddWithValue("BQuantity", bookQuantity);
            cmd.Parameters.AddWithValue("StaffID", staffID);
            cmd.Parameters.AddWithValue("UserID", userID);
            cmd.Parameters.AddWithValue("BorrowerID", borrowerID);
            cmd.Parameters.AddWithValue("PublisherID", publisherID);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();

            //done



        }

        public void updateBook(int bookNum, string Edition, string Title, string Genre, int authorID, int bookPrice,
           int bookQuantity, int staffID, int userID, int borrowerID, int publisherID)
        {
            SqlCommand cmd = new SqlCommand("updateBook", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("BookNo", bookNum);
            cmd.Parameters.AddWithValue("Edition", Edition);
            cmd.Parameters.AddWithValue("Title", Title);
            cmd.Parameters.AddWithValue("Genre", Genre);
            cmd.Parameters.AddWithValue("AuthorID", authorID);
            cmd.Parameters.AddWithValue("BPrice", bookPrice);
            cmd.Parameters.AddWithValue("BQuantity", bookQuantity);
            cmd.Parameters.AddWithValue("StaffID", staffID);
            cmd.Parameters.AddWithValue("UserID", userID);
            cmd.Parameters.AddWithValue("BorrowerID", borrowerID);
            cmd.Parameters.AddWithValue("PublisherID", publisherID);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();

            //done



        }

        public void deleteBook(int bookNum)
            //, string Edition, string Title, string Genre, int authorID, int bookPrice,
        //   int bookQuantity, int staffID, int userID, int borrowerID, int publisherID)
        {
            SqlCommand cmd = new SqlCommand("DeleteBooks", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("BookNo", bookNum);
            //cmd.Parameters.AddWithValue("Edition", Edition);
            //cmd.Parameters.AddWithValue("Title", Title);
            //cmd.Parameters.AddWithValue("Genre", Genre);
            //cmd.Parameters.AddWithValue("AuthorID", authorID);
            //cmd.Parameters.AddWithValue("BPrice", bookPrice);
            //cmd.Parameters.AddWithValue("BQuantity", bookQuantity);
            //cmd.Parameters.AddWithValue("StaffID", staffID);
            //cmd.Parameters.AddWithValue("UserID", userID);
            //cmd.Parameters.AddWithValue("BorrowerID", borrowerID);
            //cmd.Parameters.AddWithValue("PublisherID", publisherID);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            //done


        }





        public int showComedyBooks()
        {
            int x;
            SqlCommand cmd = new SqlCommand("showComedyBooks",Con);
            cmd.CommandType = CommandType.StoredProcedure;
            Con.Open();
            x= cmd.ExecuteNonQuery();
            Con.Close();
            return x;
        }


        public DataTable showComedyBooks2()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            // Con.Open(); 
            cmd = new SqlCommand("showComedyBooks",Con);
            cmd.CommandType = CommandType.StoredProcedure;
          //  cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;
            
        }


        public DataTable showHorrorBooks2()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            // Con.Open(); 
            cmd = new SqlCommand("showHorrorBooks", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;

        }


        public DataTable showThrillerBooks2()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            // Con.Open(); 
            cmd = new SqlCommand("showThrillerBooks", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;

        }



        public DataTable showMysteryBooks2()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            // Con.Open(); 
            cmd = new SqlCommand("showMysteryBooks", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;

        }


        public DataTable showPrice2()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            // Con.Open(); 
            cmd = new SqlCommand("Highest_LowestPrice", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;

        }


         public DataTable showQuantity2()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            // Con.Open(); 
            cmd = new SqlCommand("showQuantity", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;

        }


        public DataTable showPublishers()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            // Con.Open(); 
            cmd = new SqlCommand("showPublishers", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;

        }



    }
}