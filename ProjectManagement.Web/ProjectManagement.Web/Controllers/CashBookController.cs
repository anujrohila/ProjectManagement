using ProjectManagement.DLL;
using ProjectManagement.Domain;
using System;
using System.Globalization;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace ProjectManagement.Web.Controllers
{
    public class CashBookController : Controller
    {
        [HttpGet]
        public ActionResult ListAll()
        {
            var reportModel = new tblReportModelDTO();
            reportModel.SupplierList = SupplierRepository.GetAllSupplier();
            reportModel.SupplierList.Insert(0, new SupplierDTO { Sup_id = "0", NameiS = "Select" });
            return View(reportModel);
        }

        /// <summary>
        /// _Partial Report Data
        /// </summary>
        /// <returns></returns>
        public PartialViewResult _PartialReportData(string accountId, string selectedDate)
        {
            var cashBookResult = ReportRepository.CashBankBookReport(accountId, DateTime.ParseExact(selectedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture), "CASH");
            double CrTotalAmount = 0;
            double DrTotalAmount = 0;
            if (cashBookResult != null && cashBookResult.Count > 0)
            {
                foreach (var data in cashBookResult)
                {
                    if (string.Compare(data.FromAccount, data.Supplier1Id, StringComparison.CurrentCultureIgnoreCase) != 0)
                    {
                        data.CrAmount = data.Amount;
                        CrTotalAmount = CrTotalAmount + data.Amount ?? 0;
                    }
                    if (string.Compare(data.ToAccount, data.Supplier1Id, StringComparison.CurrentCultureIgnoreCase) != 0)
                    {
                        data.DrAmount = data.Amount;
                        DrTotalAmount = DrTotalAmount + data.Amount ?? 0;
                    }
                }
                cashBookResult[0].CrTotalAmount = CrTotalAmount;
                cashBookResult[0].DrTotalAmount = DrTotalAmount;
            }
            var openingBalance = ReportRepository.GetLedgerOpeningBalance(accountId, DateTime.ParseExact(selectedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture));
            ViewBag.OpeningBalance = openingBalance;
            return PartialView(cashBookResult);
        }

    }
}
