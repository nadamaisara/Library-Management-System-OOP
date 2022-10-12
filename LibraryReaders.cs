using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyLibrary
{
    public class LibraryReaders
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");

        //public static void addNewReader(int userID, string readerFirstName, string readerLastName, string readerEmail)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.addnewReader",
        //        DataAccessLayer.CreateParameters("@UserID", SqlDbType.Int, userID),
        //        DataAccessLayer.CreateParameters("@RdFname", SqlDbType.VarChar, readerFirstName),
        //        DataAccessLayer.CreateParameters("@RdLname", SqlDbType.VarChar, readerLastName),
        //        DataAccessLayer.CreateParameters("@Remail", SqlDbType.VarChar, readerEmail)
        //        );
        //}

        //public static void DeleteReader(int userID, string readerFirstName, string readerLastName, string readerEmail)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.deleteReader",
        //        DataAccessLayer.CreateParameters("@UserID", SqlDbType.Int, userID),
        //        DataAccessLayer.CreateParameters("@RdFname", SqlDbType.VarChar, readerFirstName),
        //        DataAccessLayer.CreateParameters("@RdLname", SqlDbType.VarChar, readerLastName),
        //        DataAccessLayer.CreateParameters("@Remail", SqlDbType.VarChar, readerEmail)
        //        );
        //}

        //public static void UpdateReader(int userID, string readerFirstName, string readerLastName, string readerEmail)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.updateReader",
        //        DataAccessLayer.CreateParameters("@UserID", SqlDbType.Int, userID),
        //        DataAccessLayer.CreateParameters("@RdFname", SqlDbType.VarChar, readerFirstName),
        //        DataAccessLayer.CreateParameters("@RdLname", SqlDbType.VarChar, readerLastName),
        //        DataAccessLayer.CreateParameters("@Remail", SqlDbType.VarChar, readerEmail)
        //        );
        //}


        public void addReader(int userID, string readerFirstName, string readerLastName, string readerEmail)
        {
            SqlCommand cmd = new SqlCommand("addnewReader", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("UserID", userID);
            cmd.Parameters.AddWithValue("RdFname", readerFirstName);
            cmd.Parameters.AddWithValue("RdLname", readerLastName);
            cmd.Parameters.AddWithValue("Remail", readerEmail);
            
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();



        }


        public void updateReader(int userID, string readerFirstName, string readerLastName, string readerEmail)
        {
            SqlCommand cmd = new SqlCommand("UpdateReaders", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("UserID", userID);
            cmd.Parameters.AddWithValue("RdFname", readerFirstName);
            cmd.Parameters.AddWithValue("RdLname", readerLastName);
            cmd.Parameters.AddWithValue("Remail", readerEmail);

            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            //not working



        }


        public void deleteReader(int userID, string readerFirstName, string readerLastName, string readerEmail)
        {
            SqlCommand cmd = new SqlCommand("deleteReader", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("UserID", userID);
            cmd.Parameters.AddWithValue("RdFname", readerFirstName);
            cmd.Parameters.AddWithValue("RdLname", readerLastName);
            cmd.Parameters.AddWithValue("Remail", readerEmail);

            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            //not working



        }


    }
}