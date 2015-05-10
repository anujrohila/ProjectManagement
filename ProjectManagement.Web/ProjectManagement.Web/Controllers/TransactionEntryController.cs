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
    public class TransactionEntryController : BaseController
    {

        public ActionResult ListAll(string type)
        {
            ViewBag.TransactionType = type;
            ViewBag.StartDate = DateTime.Now.AddDays(-10).ToString("dd-MM-yyyy");
            ViewBag.EndDate = DateTime.Now.ToString("dd-MM-yyyy");
            return View();
        }

        /// <summary>
        /// List Transaction Type Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListTransactionEntryAjax(string type, string startDate, string endDate)
        {
            var sDate = DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var eDate = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var supplierListGrid = TransactionRepository.GetAllTransactionEntry(type, sDate, eDate);
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
                matAccountTwoDTO.DdateString = matAccountTwoDTO.Ddate.Value.ToString("dd-MM-yyyy");
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
                    matAccountTwoDTO.Ddate = DateTime.ParseExact(matAccountTwoDTO.DdateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    matAccountTwoDTO = SetAllTransactionEntry(matAccountTwoDTO);
                    if (string.IsNullOrWhiteSpace(matAccountTwoDTO.Ent_No))
                    {
                        matAccountTwoDTO.fy = CommonFunctions.GetFiscalYear();
                        matAccountTwoDTO.Ent_No = CommonFunctions.GetNewGUID();
                        matAccountTwoDTO.VrNo = TransactionRepository.GetVRNO();
                        TransactionRepository.InsertTransactionEntry(matAccountTwoDTO, ApplicationMember.LoggedMemberType);
                    }
                    else
                    {
                        TransactionRepository.UpdateTransactionEntry(matAccountTwoDTO, ApplicationMember.LoggedMemberType);
                    }
                    return RedirectToAction("ListAll", new { type = matAccountTwoDTO.Mode_Pay_Rec });
                }
            }
            matAccountTwoDTO = FillSupplierDTO(matAccountTwoDTO);
            return View(matAccountTwoDTO);
        }

        /// <summary>
        /// Set All Transaction Entry
        /// </summary>
        /// <param name="matAccountTwoDTO"></param>
        /// <returns></returns>
        private Mat_AccountTwoDTO SetAllTransactionEntry(Mat_AccountTwoDTO matAccountTwoDTO)
        {
            matAccountTwoDTO.Userss = ApplicationMember.LoggedUserName;
            matAccountTwoDTO.Mode_Pay_Rec = matAccountTwoDTO.Mode_Pay_Rec.ToUpper();
            if (ApplicationMember.LoggedMemberType == 1)
            {
                matAccountTwoDTO.Hand_Group = "R";
            }
            else
            {
                matAccountTwoDTO.Hand_Group = "NR";
            }
            matAccountTwoDTO.Kwat = 0;
            matAccountTwoDTO.Discount = 0;
            matAccountTwoDTO.Hand = 0;
            matAccountTwoDTO.SetViewOne = "B";
            matAccountTwoDTO.Freezed = false;
            matAccountTwoDTO.IsEntryOnly = false;
            matAccountTwoDTO.GuidAC = string.Empty;
            matAccountTwoDTO.CurDate = DateTime.Now;
            matAccountTwoDTO.Hide = false;

            return matAccountTwoDTO;
        }

        /// <summary>
        /// Fill Transaction Type
        /// </summary>
        /// <param name="matAccountTwoDTO"></param>
        /// <returns></returns>
        private Mat_AccountTwoDTO FillSupplierDTO(Mat_AccountTwoDTO matAccountTwoDTO)
        {
            matAccountTwoDTO.MinEntryDateTime = CommonFunctions.GetStartOfFinancialYear(DateTime.Now);
            matAccountTwoDTO.MaxEntryDateTime = matAccountTwoDTO.MinEntryDateTime.AddYears(1).AddDays(-1);
            switch (matAccountTwoDTO.Mode_Pay_Rec.ToUpper())
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

            return matAccountTwoDTO;
        }

        /// <summary>
        /// Delete Transaction Type
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(string entryId)
        {
            var result = TransactionRepository.DeleteTransactionEntry(entryId, ApplicationMember.LoggedMemberType);
            if (result)
            {
                return Json(new { Success = true, Message = "Transaction type deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }
    }
}
