using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisburstmentJournal.Helper
{
    public class Utils
    {
        public static string GetConnectionString()
        {
            string result = string.Empty;
            try
            {
                if(ConfigurationManager.ConnectionStrings["DBConnection"] != null)
                {
                    result = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
                }
            }
            catch (Exception)
            {

            }
            return result;
        }
        public static string GetAppValue(string SettingName)
        {
            return ConfigurationSettings.AppSettings[SettingName].ToString();
        }
        public static DialogResult CloseApplication()
        {
            DialogResult dgResult = MessageBox.Show("Are you sure you want to exit program?", "Exit System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dgResult;
        }
        public static string HashMyWord(string Word)
        {
            string result = string.Empty;
            try
            {
                var sha1 = SHA1.Create();
                var inputBytes = Encoding.ASCII.GetBytes(Word);
                var hash = sha1.ComputeHash(inputBytes);
                var sb = new StringBuilder();
                for (var i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                result = sb.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
