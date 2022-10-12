using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyLibrary
{
    public class LibraryBorrowers
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");


        //public static void addNewBorrower(string firstName, string lastName, int borrowerID,
        //    string borrowFromDate, string borrowToDate, string actualReturnDate)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.addBorrower",
        //        DataAccessLayer.CreateParameters("@BrFname", SqlDbType.NVarChar, firstName),
        //        DataAccessLayer.CreateParameters("@BrLname", SqlDbType.NVarChar, lastName),
        //        DataAccessLayer.CreateParameters("@BID", SqlDbType.Int, borrowerID),
        //        DataAccessLayer.CreateParameters("@BFromDate", SqlDbType.Date, borrowFromDate),
        //        DataAccessLayer.CreateParameters("@BToDate", SqlDbType.Date, borrowToDate),
        //        DataAccessLayer.CreateParameters("@ActualRDate", SqlDbType.Date, actualReturnDate)

        //        );
        //}

        //public static void DeleteBorrower(string firstName, string lastName, int borrowerID,
        //    string borrowFromDate, string borrowToDate, string actualReturnDate)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.deleteBorrower",
        //        DataAccessLayer.CreateParameters("@BrFname", SqlDbType.NVarChar, firstName),
        //        DataAccessLayer.CreateParameters("@BrLname", SqlDbType.NVarChar, lastName),
        //        DataAccessLayer.CreateParameters("@BID", SqlDbType.Int, borrowerID),
        //        DataAccessLayer.CreateParameters("@BFromDate", SqlDbType.Date, borrowFromDate),
        //        DataAccessLayer.CreateParameters("@BToDate", SqlDbType.Date, borrowToDate),
        //        DataAccessLayer.CreateParameters("@ActualRDate", SqlDbType.Date, actualReturnDate)

        //        );
        //}

        //public static void UpdateBorrower(string firstName, string lastName, int borrowerID,
        //    string borrowFromDate, string borrowToDate, string actualReturnDate)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.updateBorrower",
        //        DataAccessLayer.CreateParameters("@BrFname", SqlDbType.NVarChar, firstName),
        //        DataAccessLayer.CreateParameters("@BrLname", SqlDbType.NVarChar, lastName),
        //        DataAccessLayer.CreateParameters("@BID", SqlDbType.Int, borrowerID),
        //        DataAccessLayer.CreateParameters("@BFromDate", SqlDbType.Date, borrowFromDate),
        //        DataAccessLayer.CreateParameters("@BToDate", SqlDbType.Date, borrowToDate),
        //        DataAccessLayer.CreateParameters("@ActualRDate", SqlDbType.Date, actualReturnDate)

        //        );
        //}


        public void addBorrower(int bid, string bfromdate, string btodate, string actualrdate, string brfname, string brlname, string issuedby,string bemail)
        {
            SqlCommand cmd = new SqlCommand("addBorrower", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("BID", bid);
            cmd.Parameters.AddWithValue("BFromDate", bfromdate);
            cmd.Parameters.AddWithValue("BToDate", btodate);
            cmd.Parameters.AddWithValue("ActualRDate", actualrdate);
            cmd.Parameters.AddWithValue("BrFname", brfname);
            cmd.Parameters.AddWithValue("BrLname", brlname);
            cmd.Parameters.AddWithValue("IssuedBy", issuedby);
            cmd.Parameters.AddWithValue("BEmail", bemail);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            //done


        }

        public void updateBorrower(int bid, string bfromdate, string btodate, string actualrdate, string brfname, string brlname,string issuedby,string bemail)
        {
            SqlCommand cmd = new SqlCommand("updateBorrower", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("BID", bid);
            cmd.Parameters.AddWithValue("BFromDate", bfromdate);
            cmd.Parameters.AddWithValue("BToDate", btodate);
            cmd.Parameters.AddWithValue("ActualRDate", actualrdate);
            cmd.Parameters.AddWithValue("BrFname", brfname);
            cmd.Parameters.AddWithValue("BrLname", brlname);
            cmd.Parameters.AddWithValue("IssuedBy", issuedby);
            cmd.Parameters.AddWithValue("BEmail", bemail);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            //done



        }
        public void deleteBorrower(int bid)
        {
            SqlCommand cmd = new SqlCommand("DeleteBorrowers", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("BorrowerID", bid);
          

            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            //done


        }



    }
}
