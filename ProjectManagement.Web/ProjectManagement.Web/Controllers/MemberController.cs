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
using Telerik.Web.Mvc;
using ProjectManagement.DLL;

namespace ProjectManagement.Web.Controllers
{
    public class MemberController : Controller
    {
        [HttpGet]
        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// List Member Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListMemberAjax()
        {
            var getAllMemberGrid = MemberRepository.GetAllMember();
            return View(new GridModel(getAllMemberGrid));
        }

        /// <summary>
        /// Save Member
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Save(int id)
        {
            var tblMemberDTO = new tblMemberDTO();
            if (id == 0)
            {
                tblMemberDTO = MemberRepository.GetMember(id);
            }
            return View(tblMemberDTO);
        }

        /// <summary>
        /// Save Member
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save([Bind(Exclude = "MemberId")]tblMemberDTO tblMemberDTO)
        {
            if (ModelState.IsValid)
            {
                var isDuplicateMember = MemberRepository.IsDuplicateMember(tblMemberDTO.EmailAddress, tblMemberDTO.MemberId);
                if (isDuplicateMember)
                {
                    ModelState.AddModelError("EmailAddress", "Email address already exists.");
                }
                if (ModelState.IsValid)
                {
                    if (tblMemberDTO.MemberId == 0)
                    {
                        tblMemberDTO.IsActive = true;
                    }
                    tblMemberDTO.MemberTypeId = 1;
                    var memberId = MemberRepository.SaveMember(tblMemberDTO);
                    return RedirectToAction("ListAll");
                }
            }
            return View(tblMemberDTO);
        }

        /// <summary>
        /// Delete Member
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(int memberId)
        {
            var result = MemberRepository.DeleteMember(memberId);
            if (result)
            {
                return Json(new { Success = true, Message = "Member deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }
    }
}
