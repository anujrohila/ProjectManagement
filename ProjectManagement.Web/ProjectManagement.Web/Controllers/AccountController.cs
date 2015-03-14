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
                    System.Web.HttpContext.Current.Session["LoggedUserName"] = string.Concat(user.FirstName, " ", user.LastName);
                    System.Web.HttpContext.Current.Session["LoggedMemberType"] = user.MemberTypeString;
                    return RedirectToAction("ProjectSelection", "Account");
                }
            }
            return View(tblLoginDTO);
        }

        [HttpGet]
        public ActionResult Logout()
        {
            System.Web.HttpContext.Current.Session["LoggedUserId"] = null;
            System.Web.HttpContext.Current.Session.Abandon();
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public ActionResult ProjectSelection()
        {
            var tblProjectSelection = new tblProjectSelectionDTO();
            if (ApplicationMember.LoggedUserId != 0)
            {
                var projectIds = ApplicationMember.LoggedUserPermission.Select(p => p.ProjectId).Distinct();
                tblProjectSelection.ProjectList = MasterRepository.GetAllProject().Where(p => projectIds.Contains(p.ProjectId)).ToList();
                return View(tblProjectSelection);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        [HttpPost]
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
                    var selectedProject = MasterRepository.GetAllProject().Where(p => p.ProjectId == tblProjectSelection.ProjectId).FirstOrDefault();
                    System.Web.HttpContext.Current.Session["LoggedSelectedProject"] = selectedProject;
                    var strConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ProjectManagementEntities1"].ConnectionString;
                    strConnectionString = strConnectionString.Replace("##CatalogName##", selectedProject.Catalog);
                    strConnectionString = strConnectionString.Replace("##UserName##", selectedProject.UserName);
                    strConnectionString = strConnectionString.Replace("##Password##", selectedProject.Password);
                    System.Web.HttpContext.Current.Session["LoggedProjectConnectionString"] = strConnectionString;
                    return RedirectToAction("Detail", "Profile");
                }
            }
            var projectIds = ApplicationMember.LoggedUserPermission.Select(p => p.ProjectId).Distinct();
            tblProjectSelection.ProjectList = MasterRepository.GetAllProject().Where(p => projectIds.Contains(p.ProjectId)).ToList();
            return View(tblProjectSelection);
        }

    }
}
