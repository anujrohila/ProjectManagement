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

    [InitializeSimpleMembership]
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
                return RedirectToAction("Index", "Home");
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
            return View(tblLoginDTO);
        }

        [HttpGet]
        public ActionResult Logout()
        {
            System.Web.HttpContext.Current.Session["LoggedUserId"] = null;
            System.Web.HttpContext.Current.Session.Abandon();
            return RedirectToAction("Login", "Account");
        }

    }
}
