using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisburstmentJournal.Helper
{
    public class clsDatabase
    {
        public static bool CheckDBConnection(string ConnectionString,out string Message)
        {
            bool result = false;
            try
            {
                Message = "Connected";
                result = true;
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
