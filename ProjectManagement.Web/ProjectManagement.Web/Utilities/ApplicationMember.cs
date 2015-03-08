using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.Web
{
    public static class ApplicationMember
    {
        public static Int32 LoggedUserId
        {
            get
            {
                //return Convert.ToInt32(System.Web.HttpContext.Current.Session["LoggedUserId"]);
                return Convert.ToInt32("1");
            }
        }

        public static string LoggedUserName
        {
            get
            {
                //return Convert.ToString(System.Web.HttpContext.Current.Session["LoggedUserName"]);
                return Convert.ToString("anuj");
            }
        }

    }
}