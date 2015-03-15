using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagement.Domain;

namespace ProjectManagement.Domain
{
    public static class ApplicationMember
    {
        public static Int32 LoggedUserId
        {
            get
            {
                return Convert.ToInt32(System.Web.HttpContext.Current.Session["LoggedUserId"]);
            }
        }

        public static string LoggedUserName
        {
            get
            {
                return Convert.ToString(System.Web.HttpContext.Current.Session["LoggedUserName"]);
            }
        }

        public static List<tblMemberPermissionDTO> LoggedUserPermission
        {
            get
            {
                return (System.Web.HttpContext.Current.Session["UserPermission"]) as List<tblMemberPermissionDTO>;
            }
        }

        public static string LoggedMemberType
        {
            get
            {
                return Convert.ToString(System.Web.HttpContext.Current.Session["LoggedMemberType"]);
            }
        }

        public static tblProjectDTO LoggedSelectedProject
        {
            get
            {
                return (System.Web.HttpContext.Current.Session["LoggedSelectedProject"]) as tblProjectDTO;
            }
        }

        public static string LoggedProjectConnectionString
        {
            get
            {
                return Convert.ToString(System.Web.HttpContext.Current.Session["LoggedProjectConnectionString"]);
            }
        }

    }
}