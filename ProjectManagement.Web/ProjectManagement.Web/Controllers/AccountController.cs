using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using ProjectManagement.Web.Filters;
using System.Security.Cryptography;
using System.Text;
using ProjectManagement.Domain;
using ProjectManagement.DLL;
using System.Web.Configuration;
using System.Configuration;


namespace ProjectManagement.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {

            var tblLoginDTO = new tblLoginDTO();
            if (ApplicationMember.LoggedUserId == 0)
            {
                return View(tblLoginDTO);
            }
            else
            {
                return RedirectToAction("Detail", "Profile");
            }
        }

        [HttpPost]
        public ActionResult Login(tblLoginDTO tblLoginDTO)
        {
            if (ModelState.IsValid)
            {
                var user = MemberRepository.GetMember(tblLoginDTO.EmailAddress, CommonFunctions.HashPassword(tblLoginDTO.Password));
                if (user == null)
                {
                    tblLoginDTO.ErrorMessage = "Invalid username & password.";
                    tblLoginDTO.StatuID = 1;
                }
                else if (user.IsActive == false)
                {
                    tblLoginDTO.ErrorMessage = "Your account is temporarily blocked.";
                    tblLoginDTO.StatuID = 1;
                }
                else
                {
                    System.Web.HttpContext.Current.Session["LoggedUserId"] = user.MemberId.ToString();
                    System.Web.HttpContext.Current.Session["UserPermission"] = user.MemberPermissionList;
                    System.Web.HttpContext.Current.Session["LoggedMemberType"] = user.MemberTypeId;
                    return RedirectToAction("ProjectSelection", "Account");
                }
            }
            return View(tblLoginDTO);
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            System.Web.HttpContext.Current.Session["LoggedUserId"] = null;
            System.Web.HttpContext.Current.Session.Abandon();
            Response.Cookies.Remove(FormsAuthentication.FormsCookieName);
            Session.Clear();
           
            var cookiesList = System.Web.HttpContext.Current.Request.Cookies.AllKeys;
            foreach (var item in cookiesList)
            {
                var cookie = System.Web.HttpContext.Current.Request.Cookies[item];
                cookie.Expires = DateTime.Now.AddHours(-1);
            }

            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        [CustomActionAutentication]
        public ActionResult ProjectSelection()
        {
            var tblProjectSelection = new tblProjectSelectionDTO();
            if (ApplicationMember.LoggedUserId != 0)
            {
                  if (ApplicationMember.LoggedMemberType == 1)
                  {
                      tblProjectSelection.ProjectList = MasterRepository.GetAllProject();
                      return View(tblProjectSelection);
                  }
                  else
                  {
                      var projectIds = ApplicationMember.LoggedUserPermission.Select(p => p.ProjectId).Distinct();
                      tblProjectSelection.ProjectList = MasterRepository.GetAllProject().Where(p => projectIds.Contains(p.ProjectId)).ToList();
                      return View(tblProjectSelection);
                  }
               
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        [HttpPost]
        [CustomActionAutentication]
        public ActionResult ProjectSelection(tblProjectSelectionDTO tblProjectSelection)
        {
            if (ModelState.IsValid)
            {
                if (tblProjectSelection.ProjectId == 0)
                {
                    tblProjectSelection.ErrorMessage = "Please select at least one project.";
                }
                else
                {
                    int memberId = ApplicationMember.LoggedUserId;
                    ApplicationMember.SelectedProjectDetails = MasterRepository.GetProject(tblProjectSelection.ProjectId);
                    string connectionString = string.Format(@"metadata=res://*/ORM.ProjectSQLDatabase.csdl|res://*/ORM.ProjectSQLDatabase.ssdl|res://*/ORM.ProjectSQLDatabase.msl;provider=System.Data.SqlClient;provider connection string=""data source={0};initial catalog={1};persist security info=True;user id={2};password={3};MultipleActiveResultSets=True;App=EntityFramework""", CommonFunctions.DatabaseServerPath, ApplicationMember.SelectedProjectDetails.Catalog, CommonFunctions.DatabaseUserName, CommonFunctions.DatabasePassword);
                    var configuration = WebConfigurationManager.OpenWebConfiguration("~");
                    var section = (ConnectionStringsSection)configuration.GetSection("connectionStrings");
                    section.ConnectionStrings["ProjectManagementEntities"].ConnectionString = connectionString;
                    configuration.Save();

                    return RedirectToAction("ReactivateMember", "Account", new { id = memberId, projectId = tblProjectSelection.ProjectId });
                }
            }
            var projectIds = ApplicationMember.LoggedUserPermission.Select(p => p.ProjectId).Distinct();
            tblProjectSelection.ProjectList = MasterRepository.GetAllProject().Where(p => projectIds.Contains(p.ProjectId)).ToList();
            return View(tblProjectSelection);
        }

        [HttpGet]
        public ActionResult ReactivateMember(int id, int projectId)
        {
            ApplicationMember.SelectedProjectDetails = MasterRepository.GetProject(projectId);
            var memberDetails = MemberRepository.GetMember(id);
            System.Web.HttpContext.Current.Session["LoggedSelectedProject"] = ApplicationMember.SelectedProjectDetails;
            System.Web.HttpContext.Current.Session["LoggedUserId"] = memberDetails.MemberId.ToString();
            System.Web.HttpContext.Current.Session["UserPermission"] = memberDetails.MemberPermissionList;
            System.Web.HttpContext.Current.Session["LoggedUserName"] = string.Concat(memberDetails.FirstName, " ", memberDetails.LastName);
            System.Web.HttpContext.Current.Session["LoggedMemberType"] = memberDetails.MemberTypeId;
            return RedirectToAction("Dashboard", "Profile");
        }
    }
}
