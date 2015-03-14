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
    public class SupplierController : Controller
    {
        //
        // GET: /Supplier/

        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// List Supplier Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListSupplierAjax()
        {
            var supplierListGrid = SupplierRepository.GetAllSupplier();
            return View(new GridModel(supplierListGrid));
        }

        /// <summary>
        /// Save Supplier
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Save(string id)
        {
            var supplierDTO = new SupplierDTO();
            if (!string.IsNullOrWhiteSpace(id))
            {
                supplierDTO = SupplierRepository.GetSupplier(id);
            }
            supplierDTO = FillSupplierDTO(supplierDTO);
            return View(supplierDTO);
        }

        /// <summary>
        /// Save Supplier
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(SupplierDTO supplierDTO)
        {
            if (ModelState.IsValid)
            {
                var isSupplierDuplicate = SupplierRepository.IsDuplicateSupplier(supplierDTO.NameiS, supplierDTO.Sup_id);
                if (isSupplierDuplicate)
                {
                    ModelState.AddModelError("Sup_id", "Supplier name is duplicate.");
                }
                if (ModelState.IsValid)
                {
                    if (string.IsNullOrWhiteSpace(supplierDTO.Sup_id))
                    {
                        supplierDTO.Sup_id = CommonFunctions.GetNewGUID();
                        supplierDTO.childof = supplierDTO.Sup_id;
                        supplierDTO.Balance = 0;
                        supplierDTO.CashBankBalance = 0;
                        SupplierRepository.InsertSupplier(supplierDTO);
                    }
                    else
                    {
                        SupplierRepository.UpdateSupplier(supplierDTO);
                    }
                    return RedirectToAction("ListAll");
                }
            }
            supplierDTO = FillSupplierDTO(supplierDTO);
            return View(supplierDTO);
        }

        /// <summary>
        /// Fill Supplier DTO
        /// </summary>
        /// <param name="supplierDTO"></param>
        /// <returns></returns>
        private SupplierDTO FillSupplierDTO(SupplierDTO supplierDTO)
        {
            supplierDTO.SupplierGroupList = MasterRepository.GetAllSupplierType();
            supplierDTO.SupplierGroupList.Insert(0, new GroupBySupplierDTO { GrpIdSupplier = 0, GroupSupplierName = "Select" });
            return supplierDTO;
        }

        /// <summary>
        /// Delete Supplier
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(string supplierId)
        {
            var result = SupplierRepository.DeleteSupplier(supplierId);
            if (result)
            {
                return Json(new { Success = true, Message = "Supplier deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }
    }
}
