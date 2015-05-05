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
    public class SupplierController : BaseController
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
        /// Save Partial Supplier
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public PartialViewResult _PartialSave()
        {
            var supplierDTO = new SupplierDTO();

            supplierDTO = FillSupplierDTO(supplierDTO);
            return PartialView(supplierDTO);
        }

        /// <summary>
        /// Save Partial Supplier
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult _PartialSave(SupplierDTO supplierDTO)
        {
            if (ModelState.IsValid)
            {
                int total = 0;
                if (supplierDTO.GroupId == 40)
                {
                    total = SupplierRepository.GetShareTotal(supplierDTO.Sup_id);
                    if ((supplierDTO.share + total) > 100)
                    {
                        return Json(new { Success = false, Message = "Total share must br greater than or equal to 100" });
                       // ModelState.AddModelError("share", "Total share must br greater than or equal to 100");
                    }
                }


                var isSupplierDuplicate = SupplierRepository.IsDuplicateSupplier(supplierDTO.NameiS, supplierDTO.Sup_id);
                if (isSupplierDuplicate)
                {
                    return Json(new { Success = false, Message = "Supplier Name Already Exist" });
                }
                if (ModelState.IsValid)
                {
                    supplierDTO.userss = ApplicationMember.LoggedUserName;
                    if (string.IsNullOrWhiteSpace(supplierDTO.Sup_id))
                    {
                        supplierDTO.Sup_id = CommonFunctions.GetNewGUID();
                        supplierDTO.childof = supplierDTO.Sup_id;
                        supplierDTO.Balance = 0;
                        supplierDTO.CashBankBalance = 0;
                        SupplierRepository.InsertSupplier(supplierDTO);
                        return Json(new { Success = true, Sup_id = supplierDTO.Sup_id, NameiS = supplierDTO.NameiS });
                    }
                }
            }
            return Json(new { Success = false, Message = "Fill Up Required Field" });
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
            if (supplierDTO.GroupId == 40)
            {
                if (supplierDTO.share == 0 || supplierDTO.share == null)
                {
                    ModelState.AddModelError("share", "Enter Share");
                }
            }
            if (ModelState.IsValid)
            {
                int total = 0;
                if (supplierDTO.GroupId == 40)
                {
                    total = SupplierRepository.GetShareTotal(supplierDTO.Sup_id == null ? "0" : supplierDTO.Sup_id);
                    if ((supplierDTO.share + total) > 100)
                    {
                        ModelState.AddModelError("share", "Total share must br greater than or equal to 100");
                    }
                }


                var isSupplierDuplicate = SupplierRepository.IsDuplicateSupplier(supplierDTO.NameiS, supplierDTO.Sup_id);
                if (isSupplierDuplicate)
                {
                    ModelState.AddModelError("Sup_id", "Supplier name is duplicate.");
                }
                if (ModelState.IsValid)
                {
                    supplierDTO.userss = ApplicationMember.LoggedUserName;
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
