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
using ProjectManagement.BLL;


namespace ProjectManagement.Web.Controllers
{
  
    [InitializeSimpleMembership]
    public class AccountController : Controller
    {
        //
        // GET: /Account/Login

        public static string HashPassword(String Password)
        {
            var sha256 = new SHA384Managed();
            return Convert.ToBase64String(sha256.ComputeHash(UTF8Encoding.UTF8.GetBytes(String.Concat(Password, System.Web.HttpContext.Current.Application["PasswordSalt"]))));
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }


        [HttpPost]
        public ActionResult Login(tblMemberDTO tblMemberDTO)
        {
            if (ModelState.IsValid)
            {
                var user = AdministratorBusinessLogic.GetMembershipDetails(tblMemberDTO.EmailAddress,HashPassword(tblMemberDTO.Password));
                if( user == null)
                {
                    tblMemberDTO.ErrorMessage = "Invalid Username & Password !!!";
                    tblMemberDTO.StatuID = 1;
                }
                else if(user.IsActive == false)
                {
                    tblMemberDTO.ErrorMessage = "Account Templary Block !!!";
                    tblMemberDTO.StatuID = 1;
                }
                else
                {
                    System.Web.HttpContext.Current.Session["LoggedUserId"] = tblMemberDTO.MemberId.ToString();
                    var returnURL = Convert.ToString(Request.QueryString["ReturnUrl"]);
                    if (string.IsNullOrWhiteSpace(returnURL))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectPermanent(returnURL);
                    }
                }
            }
            return View(tblMemberDTO);
        }

        public ActionResult Logout()
        {
            System.Web.HttpContext.Current.Session.Abandon();
            return RedirectToAction("Login", "Account");
        }


        public ActionResult Register()
        {
            return View();
        }
    }
}
