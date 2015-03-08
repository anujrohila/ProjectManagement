﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using ProjectManagement.DLL;
using ProjectManagement.Domain;

namespace ProjectManagement.Web.Controllers
{
    public class MaterialGroupController : Controller
    {

        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// List Material Type Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListMaterialTypeAjax()
        {
            var getAllMaterialType = MaterialTypeRepository.GetAllMaterialType();
            return View(new GridModel(getAllMaterialType));
        }

        /// <summary>
        /// Save Material Type
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Save(string id)
        {
            var groupByItemDTO = new GroupByItemDTO();
            if (!string.IsNullOrWhiteSpace(id))
            {
                groupByItemDTO = MaterialTypeRepository.GetMaterialType(id);
            }
            return View(groupByItemDTO);
        }

        /// <summary>
        /// Save MaterialType
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(GroupByItemDTO groupByItemDTO)
        {
            if (ModelState.IsValid)
            {
                var isDuplicateMaterialType = MaterialTypeRepository.IsDuplicateMaterialType(groupByItemDTO.GroupItemName, groupByItemDTO.GrpIdItem);
                if (isDuplicateMaterialType)
                {
                    ModelState.AddModelError("GrpIdItem", "Material type is duplicate.");
                }
                if (ModelState.IsValid)
                {
                    if (string.IsNullOrWhiteSpace(groupByItemDTO.GrpIdItem))
                    {
                        groupByItemDTO.GrpIdItem = MaterialTypeRepository.GetGrpIdItem();
                        groupByItemDTO.GuIdGroup = string.Empty;
                        groupByItemDTO.ChildOF = string.Empty;
                        MaterialTypeRepository.InsertMaterialType(groupByItemDTO);
                    }
                    else
                    {
                        MaterialTypeRepository.UpdateMaterialType(groupByItemDTO);
                    }
                    return RedirectToAction("ListAll");
                }
            }
            return View(groupByItemDTO);
        }

        /// <summary>
        /// Delete Material Type
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(string typeId)
        {
            var result = MaterialTypeRepository.DeleteMaterialType(typeId);
            if (result)
            {
                return Json(new { Success = true, Message = "Material type deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }
    }
}