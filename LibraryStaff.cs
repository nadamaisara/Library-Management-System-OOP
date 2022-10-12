using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace MyLibrary
{
    public class LibraryStaff
    {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QSG3N0B;Initial Catalog=LibraryMS;Integrated Security=True");


        SqlCommand cmd;


        //public static void addNewStaffMember(int staffID, string staffFirstName, string staffLastName, string isAdmin,
        //    int loginID, int salary, string staffEmail)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.addnewStaff",
        //        DataAccessLayer.CreateParameters("@StaffID", SqlDbType.Int, staffID),
        //        DataAccessLayer.CreateParameters("@StFname", SqlDbType.VarChar, staffFirstName),
        //        DataAccessLayer.CreateParameters("@StLname", SqlDbType.VarChar, staffLastName),
        //        DataAccessLayer.CreateParameters("@isAdmin", SqlDbType.VarChar, isAdmin),
        //        DataAccessLayer.CreateParameters("@LoginID", SqlDbType.Int, loginID),
        //        DataAccessLayer.CreateParameters("@Salary", SqlDbType.Int, salary),
        //        DataAccessLayer.CreateParameters("@Email", SqlDbType.VarChar, staffEmail)

        //        );
        //}

        //public static void DeleteStaffMember(int staffID, string staffFirstName, string staffLastName, string isAdmin,
        //    int loginID, int salary, string staffEmail)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.deleteStaff",
        //        DataAccessLayer.CreateParameters("@StaffID", SqlDbType.Int, staffID),
        //        DataAccessLayer.CreateParameters("@StFname", SqlDbType.VarChar, staffFirstName),
        //        DataAccessLayer.CreateParameters("@StLname", SqlDbType.VarChar, staffLastName),
        //        DataAccessLayer.CreateParameters("@isAdmin", SqlDbType.VarChar, isAdmin),
        //        DataAccessLayer.CreateParameters("@LoginID", SqlDbType.Int, loginID),
        //        DataAccessLayer.CreateParameters("@Salary", SqlDbType.Int, salary),
        //        DataAccessLayer.CreateParameters("@Email", SqlDbType.VarChar, staffEmail)

        //        );
        //}

        //public static void UpdateStaffMember(int staffID, string staffFirstName, string staffLastName, string isAdmin,
        //    int loginID, int salary, string staffEmail)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.updateStaff",
        //        DataAccessLayer.CreateParameters("@StaffID", SqlDbType.Int, staffID),
        //        DataAccessLayer.CreateParameters("@StFname", SqlDbType.VarChar, staffFirstName),
        //        DataAccessLayer.CreateParameters("@StLname", SqlDbType.VarChar, staffLastName),
        //        DataAccessLayer.CreateParameters("@isAdmin", SqlDbType.VarChar, isAdmin),
        //        DataAccessLayer.CreateParameters("@LoginID", SqlDbType.Int, loginID),
        //        DataAccessLayer.CreateParameters("@Salary", SqlDbType.Int, salary),
        //        DataAccessLayer.CreateParameters("@Email", SqlDbType.VarChar, staffEmail)

        //        );
        //}

        //public static DataSet salaryOrder()
        //{
        //    return DataAccessLayer.GetDataSet("dbo.SalaryOrder", "dbo.StaffInfo");
        //}
        //public static void changePassword(int loginID, string newPass)
        //{
        //    DataAccessLayer.ExecuteNonQuery("dbo.sp_changePassword",
        //        DataAccessLayer.CreateParameters("@LoginID", SqlDbType.Int, loginID),
        //        DataAccessLayer.CreateParameters("@newPass", SqlDbType.VarChar, newPass));
           
        //}
        //public static DataSet getAllUsers()
        //{
        //    return DataAccessLayer.GetDataSet("dbo.sp_getAllUsers", "dbo.Authentication");
        //}


        public DataTable showSalary2()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            // Con.Open(); 
            cmd = new SqlCommand("SalaryOrder", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;

            //done

        }


        public void addStaff(int staffid,string stfname,string stlname,string isadmin,int loginid,int salary,string email)
        
        {
            SqlCommand cmd = new SqlCommand("addnewStaff", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("StaffID", staffid);
            cmd.Parameters.AddWithValue("StFname", stfname);
            cmd.Parameters.AddWithValue("StLname", stlname);
            cmd.Parameters.AddWithValue("isAdmin", isadmin);
            cmd.Parameters.AddWithValue("LoginID", loginid);
            cmd.Parameters.AddWithValue("Salary", salary);
            cmd.Parameters.AddWithValue("Email", email);
            
            
            
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            //done


        }

        public DataTable showUsers()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            // Con.Open(); 
            cmd = new SqlCommand("sp_getAllUsers", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;

            //done

        }




        public void updateStaff(int staffid, string stfname, string stlname, string isadmin, int loginid, int salary, string email)

        {
            SqlCommand cmd = new SqlCommand("updateStaff", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("StaffID", staffid);
            cmd.Parameters.AddWithValue("StFname", stfname);
            cmd.Parameters.AddWithValue("StLname", stlname);
            cmd.Parameters.AddWithValue("isAdmin", isadmin);
            cmd.Parameters.AddWithValue("LoginID", loginid);
            cmd.Parameters.AddWithValue("Salary", salary);
            cmd.Parameters.AddWithValue("Email", email);

            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            //done


        }
        public void deleteStaff(int staffid)

        {
            SqlCommand cmd = new SqlCommand("DeleteStaffMember", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("StaffID", staffid);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
            //done


        }

        public static string Hash_SHA1(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }




    }
}