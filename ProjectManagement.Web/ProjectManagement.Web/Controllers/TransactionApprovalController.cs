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
    public class TransactionApprovalController : BaseController
    {

        public ActionResult ListAll()
        {
            ViewBag.TransactionType = "Cash";
            ViewBag.StartDate = DateTime.Now.AddDays(-10).ToString("dd-MM-yyyy");
            ViewBag.EndDate = DateTime.Now.ToString("dd-MM-yyyy");
            return View();
        }

        /// <summary>
        /// List Transaction Type Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListTransactionEntryAjax()
        {
            var getAllTransactionPendingApprovalEntry = TransactionRepository.GetAllTransactionPendingApprovalEntry();
            foreach (var item in getAllTransactionPendingApprovalEntry)
            {
                if (item.EntryType == 1)
                {
                    item.EntryTypeString = "New Entry";
                }
                else if (item.EntryType == 2)
                {
                    item.EntryTypeString = "Updated Entry";
                }
                else
                {
                    item.EntryTypeString = "Deleted Entry";
                }
            }
            return View(new GridModel(getAllTransactionPendingApprovalEntry));
        }

        /// <summary>
        /// Save Transaction Type
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Approve(string id)
        {
            var matAccountTwoDTO = new del_Mat_AccountTwoDTO();
            if (!string.IsNullOrWhiteSpace(id))
            {
                matAccountTwoDTO = TransactionRepository.GetPendingTransactionEntry(id);
                matAccountTwoDTO.DdateString = matAccountTwoDTO.Ddate.Value.ToString("dd-MM-yyyy");
                if (matAccountTwoDTO.EntryType == 1)
                {
                    matAccountTwoDTO.EntryTypeString = "New Entry";
                }
                else if (matAccountTwoDTO.EntryType == 2)
                {
                    matAccountTwoDTO.EntryTypeString = "Updated Entry";
                }
                else
                {
                    matAccountTwoDTO.EntryTypeString = "Deleted Entry";
                }
            }
            return View(matAccountTwoDTO);
        }

        /// Approve Transaction Ajax
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ApproveTransactionAjax(string entryId)
        {
            var result = TransactionRepository.ApproveTransaction(entryId);
            if (result)
            {
                return Json(new { Success = true, Message = "Transaction approved successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }

        /// Approve Transaction Ajax
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DisapproveTransactionAjax(string entryId)
        {
            var result = TransactionRepository.DisapproveTransaction(entryId);
            if (result)
            {
                return Json(new { Success = true, Message = "Transaction disapproved successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }
    }
}
