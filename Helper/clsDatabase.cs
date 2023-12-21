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
        //Helper and Database Functions
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
        //End here

        //User Functions
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
        //End Here

        //ClientProfile Functions

        //Insert Client Profile
        public static bool InsertUpdateClientProfile(Dictionary<string,string>ClientInfo,List<string>IntValues,bool isEnabled,bool isInsert)
        {
            bool result = false;
            try
            {
                string Fields = string.Empty;
                string Vals = string.Empty;
                string ForUpdate = string.Empty;
                string CodeID = "0";

                foreach(string Field in ClientInfo.Keys)
                {
                    if(Field.ToLower()!= "tbid")
                        Fields += Field.Replace("tb","") + ",";
                }

                foreach(var Values in ClientInfo)
                {
                    if (Values.Key.ToLower() == "tbid")
                    {
                        CodeID = Values.Value.ToString();
                        continue;
                    }
                    
                    if (IntValues.Contains(Values.Key))
                    {
                        Vals += Values.Value + ",";
                        ForUpdate += Values.Key.ToString().Replace("tb", "") + " = " + Values.Value.ToString() + ",";
                    }
                    else
                    {
                        Vals += "'" +Values.Value.Replace("'","''") + "'";
                        ForUpdate += Values.Key.ToString().Replace("tb","").Replace("POC","PointOfContact") + " = '" + Values.Value.ToString() + "',";
                    }
                    if(Vals.Substring(Vals.Length-1,1) != ",")
                        Vals += ",";


                    
                }

                ForUpdate += "isEnabled = " + (isEnabled ? "1" : "0");

                string SQLStatement = string.Empty;

                if (isInsert)
                    SQLStatement = "Insert into MASTER_CLIENT_TABLE(" + Fields.Replace("POC,", "PointOfContact,") + "isEnabled) values ('" + Vals + "" + (isEnabled ? 1 : 0) + ")";
                else
                    SQLStatement = "Update MASTER_CLIENT_TABLE SET " + ForUpdate.Trim() + " where ID=" + CodeID;

                //Finalizing Statement

                SQLStatement = SQLStatement.Replace(",)", ")").Replace("('","(");


                clsDatabase.ExecuteNonQuery(SQLStatement);


                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Error Insert Client Profile. Please check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }
        

        //Get Client records
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
        //End Here

        //Insert Company Record
        public static bool InsertUpdateCompany(Dictionary<string, string> ClientInfo, List<string> IntValues, bool isEnabled, bool isInsert)
        {
            bool result = false;
            try
            {
                string Fields = string.Empty;
                string Vals = string.Empty;
                string ForUpdate = string.Empty;
                string CodeID = "0";

                foreach (string Field in ClientInfo.Keys)
                {
                    if (Field.ToLower() != "tbid")
                        Fields += Field.Replace("tb", "") + ",";
                }

                foreach (var Values in ClientInfo)
                {
                    if (Values.Key.ToLower() == "tbid")
                    {
                        CodeID = Values.Value.ToString();
                        continue;
                    }

                    if (IntValues.Contains(Values.Key))
                    {
                        Vals += Values.Value + ",";
                        ForUpdate += Values.Key.ToString().Replace("tb", "") + " = " + Values.Value.ToString() + ",";
                    }
                    else
                    {
                        Vals += "'" + Values.Value.Replace("'", "''") + "'";
                        ForUpdate += Values.Key.ToString().Replace("tb", "").Replace("POC", "PointOfContact") + " = '" + Values.Value.ToString() + "',";
                    }
                    if (Vals.Substring(Vals.Length - 1, 1) != ",")
                        Vals += ",";



                }

                ForUpdate += "isEnabled = " + (isEnabled ? "1" : "0");

                string SQLStatement = string.Empty;

                if (isInsert)
                    SQLStatement = "Insert into MASTER_COMPANY_TABLE(" + Fields.Replace("POC,", "PointOfContact,") + "isEnabled) values ('" + Vals + "" + (isEnabled ? 1 : 0) + ")";
                else
                    SQLStatement = "Update MASTER_COMPANY_TABLE SET " + ForUpdate.Trim() + " where ID=" + CodeID;

                //Finalizing Statement

                SQLStatement = SQLStatement.Replace(",)", ")").Replace("('", "(");


                clsDatabase.ExecuteNonQuery(SQLStatement);


                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Error Insert Client Profile. Please check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        //Get Company records
        public static DataTable GetCompanyRecords(out string ErrMsg, string Criteria)
        {
            DataTable dt = new DataTable();
            ErrMsg = string.Empty;
            try
            {
                string SQLQuery = "select * from MASTER_COMPANY_TABLE " + Criteria + " order by CreatedDate desc";
                dt = dtResult(SQLQuery);
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message.ToString();
                throw;
            }
            return dt;
        }
        //End Here
    }
}
