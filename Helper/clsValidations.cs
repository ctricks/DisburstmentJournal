using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisburstmentJournal.Helper
{
    public class clsValidations
    {
        public static bool isUserLoginValid(string Username,string Password)
        {
            bool result = false;
            try
            {
                if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
                    result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
        public static bool isInteger(string ValueEnter)
        {
            bool result = false;
            try
            {
                int Value = int.Parse(ValueEnter);
                result = true;
            }
            catch (Exception)
            {

            }
            return result;
        }
    }
}
