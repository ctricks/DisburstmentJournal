using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

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
        private static int ExecuteNonQuery(string SQLCommand)
        {
            int result = 0;
            try
            {
                using(SqlConnection con = new SqlConnection(Utils.GetConnectionString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(SQLCommand, con))
                    {
                        cmd.CommandType = CommandType.Text;                        
                        cmd.ExecuteNonQuery();
                        result = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
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


        //Insert
        public static bool InsertClientProfile(Dictionary<string,string>ClientInfo,List<string>IntValues,bool isEnabled)
        {
            bool result = false;
            try
            {
                string Fields = string.Empty;
                string Vals = string.Empty;

                foreach(string Field in ClientInfo.Keys)
                {
                    if(Field.ToLower()!= "tbid")
                        Fields += Field.Replace("tb","") + ",";
                }

                foreach(var Values in ClientInfo)
                {
                    if (Values.Key.ToLower() == "tbid")
                        continue;
                    
                    if (IntValues.Contains(Values.Key))
                    {
                        Vals += Values.Value + ",";
                    }else
                    {
                        Vals += "'" +Values.Value.Replace("'","''") + "'";
                    }
                    if(Vals.Substring(Vals.Length-1,1) != ",")
                        Vals += ",";
                }

                string InsertStatement = "Insert into MASTER_CLIENT_TABLE(" + Fields.Replace("POC,","PointOfContact,") + "isEnabled) values ('" + Vals + "" + (isEnabled ? 1:0) + ")";

                //Finalizing Statement

                InsertStatement = InsertStatement.Replace(",)", ")").Replace("('","(");


                clsDatabase.ExecuteNonQuery(InsertStatement);


                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Error Insert Client Profile. Please check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        //Get Client Total records
        public static DataTable GetClientProfileRecords(out string ErrMsg, string Criteria)
        {
            DataTable dt = new DataTable();
            ErrMsg = string.Empty;
            try
            {
                string SQLQuery = "select * from MASTER_CLIENT_TABLE " + Criteria + " order by CreatedDate desc";
                dt = dtResult(SQLQuery);
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message.ToString();
                throw;
            }
            return dt;
        }
    }
}
