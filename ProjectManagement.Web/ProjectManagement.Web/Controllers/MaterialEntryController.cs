using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using ProjectManagement.DLL;
using ProjectManagement.Domain;
using System.Globalization;

namespace ProjectManagement.Web.Controllers
{
    [CustomActionAutentication]
    public class MaterialEntryController : Controller
    {

        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// List Supplier Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListMaterialEntryAjax()
        {
            var getAllMaterialEntryGrid = MaterialEntryRepository.GetAllMaterialEntry();
            return View(new GridModel(getAllMaterialEntryGrid));
        }

        /// <summary>
        /// Save MaterialEntry
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Save(string id)
        {
            var qtyMaterialDTO = new QtyMaterialDTO();
            if (!string.IsNullOrWhiteSpace(id))
            {
                qtyMaterialDTO = MaterialEntryRepository.GetMaterialEntry(id);
                qtyMaterialDTO.DdateString = qtyMaterialDTO.Ddate.Value.ToString("dd-MM-yyyy");
            }
            qtyMaterialDTO = FillSupplierDTO(qtyMaterialDTO);
            return View(qtyMaterialDTO);
        }

        /// <summary>
        /// Save Material Entry
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(QtyMaterialDTO qtyMaterialDTO)
        {
            if (ModelState.IsValid)
            {
                if (qtyMaterialDTO.Mat_id == "0")
                {
                    ModelState.AddModelError("Mat_id", "Please select material name.");
                }
                if (qtyMaterialDTO.Sup_id == "0")
                {
                    ModelState.AddModelError("Sup_id", "Please select supplier name.");
                }
                if (ModelState.IsValid)
                {
                    qtyMaterialDTO.Ddate = DateTime.ParseExact(qtyMaterialDTO.DdateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    qtyMaterialDTO.Ammount = qtyMaterialDTO.Rate * qtyMaterialDTO.Qty;
                    qtyMaterialDTO.Bill_Rate = qtyMaterialDTO.Rate;
                    qtyMaterialDTO.Bil_Ent = false;
                    qtyMaterialDTO.Valid = false;
                    qtyMaterialDTO.Bill_Date = null;
                    qtyMaterialDTO.Bill_Ent_No = string.Empty;
                    qtyMaterialDTO.Disp = string.Empty;
                    qtyMaterialDTO.GuidQty = string.Empty;
                    qtyMaterialDTO.userss = ApplicationMember.LoggedUserName;

                    if (string.IsNullOrWhiteSpace(qtyMaterialDTO.Reg_id))
                    {
                        qtyMaterialDTO.Reg_id = CommonFunctions.GetNewGUID();
                        MaterialEntryRepository.InsertMaterialEntry(qtyMaterialDTO);
                    }
                    else
                    {
                        MaterialEntryRepository.UpdateMaterialEntry(qtyMaterialDTO);
                    }
                    return RedirectToAction("ListAll");
                }
            }
            qtyMaterialDTO = FillSupplierDTO(qtyMaterialDTO);
            return View(qtyMaterialDTO);
        }

        /// <summary>
        /// Fill Material Entry DTO
        /// </summary>
        /// <param name="qtyMaterialDTO"></param>
        /// <returns></returns>
        private QtyMaterialDTO FillSupplierDTO(QtyMaterialDTO qtyMaterialDTO)
        {
            qtyMaterialDTO.SupplierList = SupplierRepository.GetAllSupplier();
            qtyMaterialDTO.SupplierList.Insert(0, new SupplierDTO { Sup_id = "0", NameiS = "Select" });
            qtyMaterialDTO.MaterialList = MaterialSubGroupRepository.GetAllMaterialSubGroup();
            qtyMaterialDTO.MaterialList.Insert(0, new MaterialDTO { Mat_id = "0", Mat_Name = "Select" });
            qtyMaterialDTO.UnitTypeList = CommonFunctions.GetAllUnitList();
            qtyMaterialDTO.UnitTypeList.Insert(0, "Select");
            return qtyMaterialDTO;
        }

        /// <summary>
        /// Delete Material Entry
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(string entryId)
        {
            var result = MaterialEntryRepository.DeleteMaterialEntry(entryId);
            if (result)
            {
                return Json(new { Success = true, Message = "Material entry deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }
    }
}

