using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ProjectManagement.Web
{
    public static class CommonFunctions
    {

        #region [Variable]

        /// <summary>
        /// Get ContentUrlPrefix
        /// </summary>
        public static string WebUrlPrefix
        {
            get
            {
                return Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WebUrlPrefix"]);
            }
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get Hash Value
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string HashPassword(string password)
        {
            var sha256 = new SHA384Managed();
            return Convert.ToBase64String(sha256.ComputeHash(UTF8Encoding.UTF8.GetBytes(String.Concat(password, System.Web.HttpContext.Current.Application["PasswordSalt"]))));
        }

        public static string GetNewGUID()
        {
            string newId = string.Empty;
            string kkString = Guid.NewGuid().ToString();
            kkString = kkString.Substring(0, 8);
            newId = string.Concat(kkString.Substring(0, 4), "-", kkString.Substring(4, 4));
            return newId.ToUpper();
        }

        public static List<string> GetAllUnitList()
        {
            var unitList = new List<string>();
            unitList = new List<string> 
            { 
                "CFT",
                "SFT",
                "RFT",
                "BRASS",
                "BOX",
                "NOS",
                "LIT",
                "MT",
                "KG",
                "GM",
                "BUNDLE",
                "BAG",
                "CUM",
                "SQM",
                "RMT",
                "TONNE",
                "FT",
            };
            return unitList;
        }

        #endregion

    }
}