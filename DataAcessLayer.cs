using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyLibrary
{
    public class DataAccessLayer
    {
        SqlConnection sqlConnection; // creating an object that connects VS and SQL
        static string ConnectionString = @"Data Source=.\;Initial Catalog=LibraryMS;Integrated Security=True";

        //define constructor
        public DataAccessLayer()
        {
            sqlConnection = new SqlConnection("server=DESKTOP-QSG3N0B;database=LibraryMS;Integrated Security=true");

        }

        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        public void Close()
        {
            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        //read datatable from database using select command

        //select data from database(select)---> return data --- dataType = DataTable

        //array of parameters for sql
        public DataTable SelectData(string Stored_procedure, params SqlParameter[] sqlParameters)
        {
            SqlCommand sqlCommands = new SqlCommand();

            sqlCommands.CommandType = CommandType.StoredProcedure;
            sqlCommands.CommandText = Stored_procedure;
            //this command will execute here as sqlConnection has the database name
            sqlCommands.Connection = sqlConnection;

            //or you can write query without using stored procedure using this code below
            /*
              sqlCommands.CommandType = CommandType.Text;
            sqlCommands.CommandText = "select BookID,Author from BookInfo where BookID=1";
            sqlCommands.Connection = sqlConnection;
            */

            if (sqlParameters != null)
            {
                // AddRange is a built method that takes all parameters from user and store it in sqlCommands
                sqlCommands.Parameters.AddRange(sqlParameters);
            }

            //sqlDataAdapter is a class that gets the data

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommands);
            //the attributes that returned are DataTable dataType
            DataTable dt = new DataTable();
            // return table
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        //insert--update--delete --> performing commands = no data return
        public static void ExecuteNonQuery(string Stored_procedure, params SqlParameter[] sqlParameters)
        {
            SqlCommand sqlCommands = new SqlCommand();

            sqlCommands.CommandType = CommandType.StoredProcedure;
            sqlCommands.CommandText = Stored_procedure;

            if (sqlParameters != null)
            {
                sqlCommands.Parameters.AddRange(sqlParameters);
            }

            sqlCommands.ExecuteNonQuery(); // execute the command 
        }

        public static SqlParameter CreateParameters(string Parameters_Name, SqlDbType Parameters_Type, object Parameters_Value)
        {
            SqlParameter sqlParam = new SqlParameter(Parameters_Name, Parameters_Type);
            sqlParam.Value = Parameters_Value;
            return sqlParam;
        }

        public static SqlParameter CreateParameters(string Parameters_Name, SqlDbType Parameters_Type, ParameterDirection Parameters_Direction)
        {
            SqlParameter sqlParam = new SqlParameter(Parameters_Name, Parameters_Type);
            sqlParam.Direction = Parameters_Direction;
            return sqlParam;
        }



        public static DataSet GetDataSet(string Stored_Name, string Tabel_Name, params SqlParameter[] parameters)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(Stored_Name, sqlConnection);
            foreach (SqlParameter param in parameters)
            {
                sqlCommand.Parameters.Add(param);
            }
            sqlCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(ds, Tabel_Name);

            return ds;
        }

    }

}