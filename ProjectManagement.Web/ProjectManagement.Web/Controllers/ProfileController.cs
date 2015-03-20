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
using Telerik.Web.Mvc;
using ProjectManagement.DLL;

namespace ProjectManagement.Web.Controllers
{
     [CustomActionAutentication]
    public class ProfileController : Controller
    {
        /// <summary>
        /// Dashboard
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Dashboard()
        {
            return View();
        }

        /// <summary>
        /// Unauthorized
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Unauthorized()
        {
            return View();
        }

        /// <summary>
        /// Update Member
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Detail()
        {
            var tblMemberDTOObect = new tblMemberDTO();
            tblMemberDTOObect = MemberRepository.GetMember(ApplicationMember.LoggedUserId);
            return View(tblMemberDTOObect);
        }

        /// <summary>
        /// Save Member
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Update()
        {
            var tblMemberDTOObect = new tblMemberDTO();
            tblMemberDTOObect = MemberRepository.GetMember(ApplicationMember.LoggedUserId);
            return View(tblMemberDTOObect);
        }

        /// <summary>
        /// Save Member
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Update([Bind(Exclude = "MemberId")]tblMemberDTO tblMemberDTO)
        {
            if (ModelState.IsValid)
            {
                var memberDetails = MemberRepository.GetMember(ApplicationMember.LoggedUserId);
                memberDetails.FirstName = tblMemberDTO.FirstName;
                memberDetails.LastName = tblMemberDTO.LastName;
                memberDetails.Address = tblMemberDTO.FirstName;
                memberDetails.MobileNo = tblMemberDTO.FirstName;
                var memberId = MemberRepository.UpdateMember(memberDetails);
                return RedirectToAction("Detail");
            }
            return View(tblMemberDTO);
        }

        /// <summary>
        /// Change Password
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ChangePassword()
        {
            var tblChangePassword = new tblChangePassword();
            return View(tblChangePassword);
        }

        /// <summary>
        /// Change Password
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ChangePassword(tblChangePassword tblChangePassword)
        {
            if (ModelState.IsValid)
            {
                if (string.Compare(tblChangePassword.NewPassword, tblChangePassword.ReTypePassword, StringComparison.CurrentCultureIgnoreCase) != 0)
                {
                    ModelState.AddModelError("NewPassword", "New password and re-type password doesn't match.");
                }
                if (ModelState.IsValid)
                {
                    var memberDetails = MemberRepository.GetMember(ApplicationMember.LoggedUserId);
                    if (string.Compare(memberDetails.Password, CommonFunctions.HashPassword(tblChangePassword.OldPassword), StringComparison.CurrentCultureIgnoreCase) == 0)
                    {
                        var memberId = MemberRepository.UpdatePassword(ApplicationMember.LoggedUserId, CommonFunctions.HashPassword(tblChangePassword.NewPassword));
                        return RedirectToAction("Detail");
                    }
                    else
                    {
                        ModelState.AddModelError("OldPassword", "Old password doesn't match.");
                    }
                }
            }
            return View(tblChangePassword);
        }

    }
}
