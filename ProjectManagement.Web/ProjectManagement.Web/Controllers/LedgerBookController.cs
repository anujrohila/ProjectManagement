using ProjectManagement.DLL;
using ProjectManagement.Domain;
using System;
using System.Globalization;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace ProjectManagement.Web.Controllers
{
    [CustomActionAutentication]
    public class LedgerBookController : Controller
    {
        [HttpGet]
        public ActionResult ListAll()
        {
            var reportModel = new tblReportModelDTO();
            reportModel.SupplierList = SupplierRepository.GetAllSupplier();
            reportModel.YearList = CommonFunctions.GetYearList();
            return View(reportModel);
        }

        /// <summary>
        /// _Partial Report Data
        /// </summary>
        /// <returns></returns>
        public PartialViewResult _PartialReportData(string accountId, string selectedDate)
        {
            DateTime startDate = DateTime.ParseExact(selectedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact("31-03-" + startDate.AddYears(1).Year, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var ledgerBookResult = ReportRepository.LedgerBookReport(accountId, startDate, endDate);
            double CrTotalAmount = 0;
            double DrTotalAmount = 0;
            if (ledgerBookResult != null && ledgerBookResult.Count > 0)
            {
                foreach (var data in ledgerBookResult)
                {
                    data.TransactionDateString = data.DDate.Value.ToString("MMMM-yyyy");
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
                var openingBalance = ReportRepository.GetLedgerOpeningBalance(accountId, DateTime.ParseExact(selectedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture));

                if (openingBalance < 0)
                {
                    CrTotalAmount = CrTotalAmount + openingBalance;
                    ledgerBookResult[0].CrOpeningBalance = openingBalance;
                }
                ledgerBookResult[0].CrTotalAmount = CrTotalAmount;
                if (openingBalance > 0)
                {
                    DrTotalAmount = DrTotalAmount + openingBalance;
                    ledgerBookResult[0].DrOpeningBalance = openingBalance;
                }
                ledgerBookResult[0].DrTotalAmount = DrTotalAmount;

                if ((DrTotalAmount - CrTotalAmount) > 0)
                {
                    ledgerBookResult[0].CrClosingBalance = DrTotalAmount - CrTotalAmount;
                }
                if ((DrTotalAmount - CrTotalAmount) < 0)
                {
                    ledgerBookResult[0].DrClosingBalance = DrTotalAmount - CrTotalAmount;
                }
            }
            return PartialView(ledgerBookResult);
        }

    }
}
