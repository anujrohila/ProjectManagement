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
        public ActionResult ListTransactionEntryAjax(string type)
        {
            var supplierListGrid = TransactionRepository.GetAllTransactionEntry(type);
            return View(new GridModel(supplierListGrid));
        }

        /// <summary>
        /// Save Transaction Type
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Save(string id, string type)
        {
            var matAccountTwoDTO = new Mat_AccountTwoDTO();
            matAccountTwoDTO.Mode_Pay_Rec = type.ToUpper();
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
                if (ModelState.IsValid)
                {
                    matAccountTwoDTO.Userss = ApplicationMember.LoggedUserName;
                    if (string.IsNullOrWhiteSpace(matAccountTwoDTO.Ent_No))
                    {
                        matAccountTwoDTO.Ent_No = CommonFunctions.GetNewGUID();
                        matAccountTwoDTO.VrNo = TransactionRepository.GetVRNO();
                        TransactionRepository.InsertTransactionEntry(matAccountTwoDTO);
                    }
                    else
                    {
                        TransactionRepository.UpdateTransactionEntry(matAccountTwoDTO);
                    }
                    return RedirectToAction("ListAll", new { type = matAccountTwoDTO.Mode_Pay_Rec });
                }
            }
            matAccountTwoDTO = FillSupplierDTO(matAccountTwoDTO);
            return View(matAccountTwoDTO);
        }

        /// <summary>
        /// Fill Transaction Type
        /// </summary>
        /// <param name="matAccountTwoDTO"></param>
        /// <returns></returns>
        private Mat_AccountTwoDTO FillSupplierDTO(Mat_AccountTwoDTO matAccountTwoDTO)
        {

            switch (matAccountTwoDTO.Mode_Pay_Rec)
            {
                case "CASH":
                    matAccountTwoDTO.FromSupplierList = SupplierRepository.GetAllSupplier().Where(s => s.GroupId == 6 || s.GroupId == 45).ToList();
                    matAccountTwoDTO.ToSupplierList = SupplierRepository.GetAllSupplier().Where(s => s.GroupId != 2 &&
                                                                                                       s.GroupId != 6 &&
                                                                                                       s.GroupId != 21 &&
                                                                                                       s.GroupId != 45 &&
                                                                                                       s.GroupId != 23).OrderBy(o => o.NameiS).ToList();
                    break;
                case "BANK":
                    matAccountTwoDTO.FromSupplierList = SupplierRepository.GetAllSupplier().Where(s => s.GroupId == 2).ToList();
                    matAccountTwoDTO.ToSupplierList = SupplierRepository.GetAllSupplier().Where(s => s.GroupId != 2 &&
                                                                                                       s.GroupId != 6 &&
                                                                                                       s.GroupId != 21 &&
                                                                                                       s.GroupId != 45 &&
                                                                                                       s.GroupId != 23).OrderBy(o => o.NameiS).ToList();
                    break;
                case "CONTRA":
                    matAccountTwoDTO.FromSupplierList = SupplierRepository.GetAllSupplier().Where(s => s.GroupId == 2 || s.GroupId == 6 || s.GroupId == 45).ToList();
                    matAccountTwoDTO.ToSupplierList = SupplierRepository.GetAllSupplier().Where(s => s.GroupId == 2 || s.GroupId == 6 || s.GroupId == 45).ToList();
                    break;
                case "JOURNAL":
                    matAccountTwoDTO.FromSupplierList = SupplierRepository.GetAllSupplier().Where(s => s.GroupId != 2 &&
                                                                                                       s.GroupId != 6 &&
                                                                                                       s.GroupId != 21 &&
                                                                                                       s.GroupId != 45 &&
                                                                                                       s.GroupId != 23).OrderBy(o => o.NameiS).ToList();
                    matAccountTwoDTO.ToSupplierList = SupplierRepository.GetAllSupplier().Where(s => s.GroupId != 2 &&
                                                                                                       s.GroupId != 6 &&
                                                                                                       s.GroupId != 21 &&
                                                                                                       s.GroupId != 45 &&
                                                                                                       s.GroupId != 23).OrderBy(o => o.NameiS).ToList();
                    break;
            }

            matAccountTwoDTO.FromSupplierList.Insert(0, new SupplierDTO { Sup_id = "", NameiS = "Select" });
            matAccountTwoDTO.ToSupplierList.Insert(0, new SupplierDTO { Sup_id = "", NameiS = "Select" });
            return matAccountTwoDTO;
        }

        /// <summary>
        /// Delete Transaction Type
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(string entryId)
        {
            var result = TransactionRepository.DeleteTransactionEntry(entryId);
            if (result)
            {
                return Json(new { Success = true, Message = "Transaction type deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }
    }
}
