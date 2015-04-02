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
            var result = ReportRepository.CashBookReport(accountId, DateTime.ParseExact(selectedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture));
            var openingBalance = ReportRepository.GetLedgerOpeningBalance(accountId, DateTime.ParseExact(selectedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture));
            ViewBag.OpeningBalance = openingBalance;
            return PartialView(result);
        }

    }
}
