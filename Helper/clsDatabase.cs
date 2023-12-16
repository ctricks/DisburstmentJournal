using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Runtime.CompilerServices;

namespace DisburstmentJournal.Helper
{
    public class clsDatabase
    {   
        private static DataTable dtResult(string SQLQuery)
        {
            DataTable dtResult = new DataTable();
            SqlConnection sqcon = new SqlConnection(Utils.GetConnectionString());

            try
            {
                sqcon.Open();

                SqlDataAdapter da = new SqlDataAdapter(SQLQuery, sqcon);
                da.Fill(dtResult);

                sqcon.Close();
            }
            catch (Exception)
            {

                throw;
            }
            sqcon.Dispose();            
            return dtResult;
        }
        public static bool CheckDBConnection(string ConnectionString,out string Message)
        {
            bool result = false;
            SqlConnection sqConnection = new SqlConnection(ConnectionString);

            try
            {
                sqConnection.Open();
                
                Message = sqConnection.State == System.Data.ConnectionState.Open ? "Connected":"Disconnected";
                
                result = true;
            }
            catch (Exception ex)
            {
                Message = ex.Message.ToString();
                throw;
            }

            sqConnection.Dispose();

            return result;
        }
        public static bool CheckUserLogin(string Username,string Password,out string Message)
        {
            bool result = false;
            Message = String.Empty;
            try
            {
                string SQL_Query = "Select * from MASTER_USERS_TABLE where Username = '" + Username + "' and Password = '" + Utils.HashMyWord(Password) +"'";

                result = dtResult(SQL_Query).Rows.Count > 0 ? true : false;

                if(!result)
                    Message = "Error: No User Found. Please Check your entry";
            }
            catch (Exception ex)
            {
                Message = ex.Message.ToString();
                throw;
            }
            return result;
        }
    }
}
