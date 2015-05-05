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
    public class MemberController : BaseController
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
            var tblMemberDTOObect = new tblMemberDTO();
            if (id > 0)
            {
                tblMemberDTOObect = MemberRepository.GetMember(id);
                tblMemberDTOObect.SelectedProject = tblMemberDTOObect.MemberPermissionList.Select(pro => pro.ProjectId).Distinct().ToList();
            }
            tblMemberDTOObect = FillMemberComboBox(tblMemberDTOObect);
            return View(tblMemberDTOObect);
        }


        private tblMemberDTO FillMemberComboBox(tblMemberDTO tblMemberDTO)
        {
            tblMemberDTO.ProjectList = MasterRepository.GetAllProject();
            tblMemberDTO.EntityList = MasterRepository.GetAllEntity();
            return tblMemberDTO;
        }

        /// <summary>
        /// Save Member
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(tblMemberDTO tblMemberDTO)
        {
            if (ModelState.IsValid)
            {
                var isDuplicateMember = MemberRepository.IsDuplicateMember(tblMemberDTO.EmailAddress, tblMemberDTO.MemberId);
                tblMemberDTO.MemberPermissionList = GetMemberPermissionList(tblMemberDTO.ProjectSelectionString, tblMemberDTO.EntityPermissionSelectionString);
                tblMemberDTO.SelectedProject = tblMemberDTO.MemberPermissionList.Select(pro => pro.ProjectId).Distinct().ToList();

                if (isDuplicateMember)
                {
                    ModelState.AddModelError("EmailAddress", "Email address already exists.");
                }
                if (ModelState.IsValid)
                {
                    tblMemberDTO.IsActive = true;
                    tblMemberDTO.MemberTypeId = 2;
                    tblMemberDTO.Password = tblMemberDTO.Password;
                    var memberId = MemberRepository.SaveMember(tblMemberDTO);
                    return RedirectToAction("ListAll");
                }
            }
            tblMemberDTO = FillMemberComboBox(tblMemberDTO);
            return View(tblMemberDTO);
        }

        /// <summary>
        /// Get Member Permission List
        /// </summary>
        /// <param name="selectedProject"></param>
        /// <param name="selectedEntity"></param>
        /// <returns></returns>
        private List<tblMemberPermissionDTO> GetMemberPermissionList(string selectedProject, string selectedEntity)
        {
            var permissionList = new List<tblMemberPermissionDTO>();
            var projectArray = selectedProject.Split(',');
            for (int i = 0; i < projectArray.Length; i++)
            {
                var entity = selectedEntity.Split('#');
                for (int j = 0; j < entity.Length; j++)
                {
                    var permission = new tblMemberPermissionDTO();
                    permission.MemberId = ApplicationMember.LoggedUserId;
                    permission.ProjectId = Convert.ToInt32(projectArray[i]);
                    if ((entity[j].IndexOf('-') + 1) < entity[j].Length)
                    {
                        var entityString = entity[j].Substring(entity[j].IndexOf('-') + 2, entity[j].Length - entity[j].IndexOf('-') - 2);
                        var entityArray = entityString.Split(',');
                        for (int k = 0; k < entityArray.Length; k++)
                        {
                            permission.EnitytId = Convert.ToInt32(entity[j].Substring(0, entity[j].IndexOf('-')));
                            if (entityArray[k] == "L")
                            {
                                permission.CanListAll = true;
                            }
                            if (entityArray[k] == "I")
                            {
                                permission.CanInsert = true;
                            }
                            if (entityArray[k] == "E")
                            {
                                permission.CanEdit = true;
                            }
                            if (entityArray[k] == "D")
                            {
                                permission.CanDelete = true;
                            }
                        }
                        permissionList.Add(permission);
                    }
                }
            }
            return permissionList;
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
