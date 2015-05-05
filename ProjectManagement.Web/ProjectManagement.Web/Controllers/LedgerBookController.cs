using ProjectManagement.DLL;
using ProjectManagement.Domain;
using System;
using System.Globalization;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using System.Linq;

namespace ProjectManagement.Web.Controllers
{
    [CustomActionAutentication]
    public class LedgerBookController : BaseController
    {
        [HttpGet]
        public ActionResult ListAll()
        {
            var reportModel = new tblReportModelDTO();
            reportModel.SupplierList = SupplierRepository.GetAllSupplier().Where(s => s.GroupId != 6
                                                                                        && s.GroupId != 45
                                                                                        && s.GroupId != 2
                                                                                        && s.GroupId != 21
                                                                                        && s.GroupId != 23
                                                                                        && s.GroupId != 44
                                                                                        && s.GroupId != 43).ToList();
            reportModel.YearList = CommonFunctions.GetYearList();
            return View(reportModel);
        }

        /// <summary>
        /// _Partial Report Data
        /// </summary>
        /// <returns></returns>
        public PartialViewResult _PartialReportData(string accountId, string selectedDate)
        {
            ViewBag.ReportType = "Ledger";
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
                    if (string.Compare(data.ToAccount, accountId, StringComparison.CurrentCultureIgnoreCase) != 0)
                    {
                        data.DrAmount = data.Amount;
                        DrTotalAmount = DrTotalAmount + data.Amount ?? 0;
                        data.Description = data.Supplier1TypeName;
                    }
                    else
                    {
                        data.CrAmount = data.Amount;
                        CrTotalAmount = CrTotalAmount + data.Amount ?? 0;
                        data.Description = data.TransactionType;
                    }
                }
                var openingBalance = ReportRepository.GetLedgerOpeningBalance(accountId, DateTime.ParseExact(selectedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture));

                if (openingBalance < 0)
                {
                    CrTotalAmount = CrTotalAmount + Math.Abs(openingBalance);
                    ledgerBookResult[0].CrOpeningBalance = Math.Abs(openingBalance);
                }
                ledgerBookResult[0].CrTotalAmount = CrTotalAmount;
                if (openingBalance > 0)
                {
                    DrTotalAmount = DrTotalAmount + Math.Abs(openingBalance);
                    ledgerBookResult[0].DrOpeningBalance = Math.Abs(openingBalance);
                }
                ledgerBookResult[0].DrTotalAmount = DrTotalAmount;

                if ((DrTotalAmount - CrTotalAmount) > 0)
                {
                    ledgerBookResult[0].CrClosingBalance = Math.Abs(DrTotalAmount - CrTotalAmount);
                }
                if ((DrTotalAmount - CrTotalAmount) < 0)
                {
                    ledgerBookResult[0].DrClosingBalance = Math.Abs(DrTotalAmount - CrTotalAmount);
                }
            }
            return PartialView(ledgerBookResult);
        }

    }
}
