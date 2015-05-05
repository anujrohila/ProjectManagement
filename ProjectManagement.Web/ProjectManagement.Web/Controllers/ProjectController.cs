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
    public class ProjectController : BaseController
    {
        [HttpGet]
        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// List Project Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListProjectAjax()
        {
            var getAllProject = ProjectRepository.GetAllProject();
            return View(new GridModel(getAllProject));
        }


        /// <summary>
        /// Save Partial Project
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public PartialViewResult _PartialSave()
        {
            return PartialView(new tblProjectDTO());
        }

        /// <summary>
        /// Save Partial Project
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult _PartialSave(tblProjectDTO tblProjectDTO)
        {
            if (ModelState.IsValid)
            {
                var isDuplicateMember = ProjectRepository.IsDuplicateProject(tblProjectDTO.Title, tblProjectDTO.ProjectId);
                if (isDuplicateMember)
                {
                   // ModelState.AddModelError("Title", "Project already exists in system.");
                    return Json(new { Success = false, Message = "Project already exists in system." });
                }
                if (ModelState.IsValid)
                {
                     tblProjectDTO.StratDateTime = DateTime.Now;
                     tblProjectDTO.IsActive = true;
                    var projectId = ProjectRepository.SaveProject(tblProjectDTO);
                    return Json(new { Success = true, ProjectId = projectId, Title = tblProjectDTO.Title });
                }
            }
            return Json(new { Success = false, Message = "Fill Up Required Field" });
        }

        /// <summary>
        /// Save Project
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Save(int id)
        {
            var tblProjectDTO = new tblProjectDTO();
            if (id > 0)
            {
                tblProjectDTO = ProjectRepository.GetProject(id);
            }
            return View(tblProjectDTO);
        }

        /// <summary>
        /// Save Project
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(tblProjectDTO tblProjectDTO)
        {
            if (ModelState.IsValid)
            {
                var isDuplicateMember = ProjectRepository.IsDuplicateProject(tblProjectDTO.Title, tblProjectDTO.ProjectId);
                if (isDuplicateMember)
                {
                    ModelState.AddModelError("Title", "Project already exists in system.");
                }
                if (ModelState.IsValid)
                {
                    if (tblProjectDTO.ProjectId == 0)
                    {
                        tblProjectDTO.StratDateTime = DateTime.Now;
                    }
                    var projectId = ProjectRepository.SaveProject(tblProjectDTO);
                    return RedirectToAction("ListAll");
                }
            }
            return View(tblProjectDTO);
        }

        /// <summary>
        /// Delete Project
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(int projectId)
        {
            var result = ProjectRepository.DeleteProject(projectId);
            if (result)
            {
                return Json(new { Success = true, Message = "Project deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }

    }
}
