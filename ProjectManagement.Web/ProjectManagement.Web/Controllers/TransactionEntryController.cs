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
    public class TransactionEntryController : Controller
    {

        public ActionResult ListAll(string type)
        {
            ViewBag.TransactionType = type;
            return View();
        }

        /// <summary>
        /// List Transaction Type Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListTransactionTypeAjax(string transactionType)
        {
            var supplierListGrid = TransactionRepository.GetAllTransactionEntry(transactionType);
            return View(new GridModel(supplierListGrid));
        }

        /// <summary>
        /// Save Transaction Type
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Save(string id)
        {
            var matAccountTwoDTO = new Mat_AccountTwoDTO();
            if (!string.IsNullOrWhiteSpace(id))
            {
                matAccountTwoDTO = TransactionRepository.GetTransactionEntry(id);
            }
            matAccountTwoDTO = FillSupplierDTO(matAccountTwoDTO);
            return View(matAccountTwoDTO);
        }

        /// <summary>
        /// Save Transaction Type
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(Mat_AccountTwoDTO matAccountTwoDTO)
        {
            if (ModelState.IsValid)
            {
                int total = 0;

                if (ModelState.IsValid)
                {
                    if (string.IsNullOrWhiteSpace(matAccountTwoDTO.Ent_No))
                    {
                        matAccountTwoDTO.Ent_No = CommonFunctions.GetNewGUID();
                        TransactionRepository.InsertTransactionEntry(matAccountTwoDTO);
                    }
                    else
                    {
                        TransactionRepository.UpdateTransactionEntry(matAccountTwoDTO);
                    }
                    return RedirectToAction("ListAll");
                }
            }
            matAccountTwoDTO = FillSupplierDTO(matAccountTwoDTO);
            return View(matAccountTwoDTO);
        }

        /// <summary>
        /// Fill Supplier DTO
        /// </summary>
        /// <param name="matAccountTwoDTO"></param>
        /// <returns></returns>
        private Mat_AccountTwoDTO FillSupplierDTO(Mat_AccountTwoDTO matAccountTwoDTO)
        {
            matAccountTwoDTO.FromSupplierList = SupplierRepository.GetAllSupplier();
            matAccountTwoDTO.FromSupplierList.Insert(0, new SupplierDTO { Sup_id = "0", NameiS = "Select" });
            matAccountTwoDTO.ToSupplierList = SupplierRepository.GetAllSupplier();
            matAccountTwoDTO.ToSupplierList.Insert(0, new SupplierDTO { Sup_id = "0", NameiS = "Select" });
            return matAccountTwoDTO;
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
