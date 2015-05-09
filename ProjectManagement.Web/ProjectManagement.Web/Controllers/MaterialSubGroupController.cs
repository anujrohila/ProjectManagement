using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using ProjectManagement.DLL;
using ProjectManagement.Domain;

namespace ProjectManagement.Web.Controllers
{
    [CustomActionAutentication]
    public class MaterialSubGroupController : BaseController
    {

        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// List Material Sub Type Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListMaterialSubTypeAjax()
        {
            var ggetAllMaterialSubGroup = MaterialSubGroupRepository.GetAllMaterialSubGroup();
            return View(new GridModel(ggetAllMaterialSubGroup));
        }



        /// <summary>
        /// Save Partial Material Sub Type
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public PartialViewResult _PartialSave()
        {
            var materialDTO = new MaterialDTO();
            materialDTO = FillMaterialCombox(materialDTO);
            return PartialView(materialDTO);
        }

        /// <summary>
        /// Save Partial MaterialType
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult _PartialSave(MaterialDTO materialDTO)
        {
            if (ModelState.IsValid)
            {
                var isDuplicateMaterialSubGroup = MaterialSubGroupRepository.IsDuplicateMaterialSubGroup(materialDTO.Mat_Name, materialDTO.Mat_id, materialDTO.GroupId);
                if (isDuplicateMaterialSubGroup)
                {
                  //  ModelState.AddModelError("GrpIdItem", "Material sub type is duplicate.");
                    return Json(new { Success = false, Message = "Material sub type is duplicate." });
                }
                if (materialDTO.GroupId == "0")
                {
                    //ModelState.AddModelError("GroupId", "Please select material type.");
                    return Json(new { Success = false, Message = "Please select material type" });
                }
                if (materialDTO.Mat_Unit == "0")
                {
                    //ModelState.AddModelError("Mat_Unit", "Please select material unit.");
                    return Json(new { Success = false, Message = "Please select material unit" });
                }
                if (ModelState.IsValid)
                {
                    materialDTO.userss = ApplicationMember.LoggedUserName;
                    materialDTO.GuIdMaterial = string.Empty;
                    materialDTO.userss = ApplicationMember.LoggedUserName;
                    if (string.IsNullOrWhiteSpace(materialDTO.Mat_id))
                    {
                        materialDTO.Mat_id = CommonFunctions.GetNewGUID();
                        MaterialSubGroupRepository.InsertMaterialSubGroup(materialDTO);
                        return Json(new { Success = true, Mat_id = materialDTO.Mat_id, Mat_Name = materialDTO.Mat_Name });
                    }
                }
            }
            return Json(new { Success = false, Message = "Fill Up Required Field" });

        }



        /// <summary>
        /// Save Material Sub Type
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Save(string id)
        {
            var materialDTO = new MaterialDTO();
            if (!string.IsNullOrWhiteSpace(id))
            {
                materialDTO = MaterialSubGroupRepository.GetMaterialSubGroup(id);
            }
            materialDTO = FillMaterialCombox(materialDTO);
            return View(materialDTO);
        }

        /// <summary>
        /// Save MaterialType
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(MaterialDTO materialDTO)
        {
            if (ModelState.IsValid)
            {
                var isDuplicateMaterialSubGroup = MaterialSubGroupRepository.IsDuplicateMaterialSubGroup(materialDTO.Mat_Name, materialDTO.Mat_id, materialDTO.GroupId);
                if (isDuplicateMaterialSubGroup)
                {
                    ModelState.AddModelError("GrpIdItem", "Material sub type is duplicate.");
                }
                if (materialDTO.GroupId == "0")
                {
                    ModelState.AddModelError("GroupId", "Please select material type.");
                }
                if (materialDTO.Mat_Unit == "0")
                {
                    ModelState.AddModelError("Mat_Unit", "Please select material unit.");
                }
                if (ModelState.IsValid)
                {
                    materialDTO.userss = ApplicationMember.LoggedUserName;
                    materialDTO.GuIdMaterial = string.Empty;
                    if (string.IsNullOrWhiteSpace(materialDTO.Mat_id))
                    {
                        materialDTO.Mat_id = CommonFunctions.GetNewGUID();
                        MaterialSubGroupRepository.InsertMaterialSubGroup(materialDTO);
                    }
                    else
                    {
                        MaterialSubGroupRepository.UpdateMaterialSubGroup(materialDTO);
                    }
                    return RedirectToAction("ListAll");
                }
            }
            materialDTO = FillMaterialCombox(materialDTO);
            return View(materialDTO);
        }

        private MaterialDTO FillMaterialCombox(MaterialDTO materialDTO)
        {
            materialDTO.MaterialGroupList = MaterialTypeRepository.GetAllMaterialType();
            materialDTO.UnitTypeList = CommonFunctions.GetAllUnitList();

            return materialDTO;
        }

        /// <summary>
        /// Delete Material Type
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(string subTypeId)
        {
            var result = MaterialSubGroupRepository.DeleteMaterialSubGroup(subTypeId);
            if (result)
            {
                return Json(new { Success = true, Message = "Material sub type deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }
    }
}
