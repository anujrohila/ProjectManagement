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

        #endregion

    }
}