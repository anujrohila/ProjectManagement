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
    public class BankBookController : Controller
    {
        [HttpGet]
        public ActionResult ListAll()
        {
            var reportModel = new tblReportModelDTO();
            reportModel.SupplierList = SupplierRepository.GetAllSupplier().Where(s => s.GroupId == 2).ToList();
            reportModel.YearList = CommonFunctions.GetYearList();
            return View(reportModel);
        }

        /// <summary>
        /// _Partial Report Data
        /// </summary>
        /// <returns></returns>
        public PartialViewResult _PartialReportData(string accountId, string selectedDate)
        {
            ViewBag.ReportType = "Bank";
            DateTime startDate = DateTime.ParseExact(selectedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var cashBookResult = ReportRepository.CashBankBookReport(accountId, startDate, "BANK");
            double CrTotalAmount = 0;
            double DrTotalAmount = 0;
            if (cashBookResult != null && cashBookResult.Count > 0)
            {
                foreach (var data in cashBookResult)
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
                    cashBookResult[0].CrOpeningBalance = Math.Abs(openingBalance);
                }
                cashBookResult[0].CrTotalAmount = CrTotalAmount;
                if (openingBalance > 0)
                {
                    DrTotalAmount = DrTotalAmount + Math.Abs(openingBalance);
                    cashBookResult[0].DrOpeningBalance = Math.Abs(openingBalance);
                }
                cashBookResult[0].DrTotalAmount = DrTotalAmount;

                if ((DrTotalAmount - CrTotalAmount) > 0)
                {
                    cashBookResult[0].CrClosingBalance = Math.Abs(DrTotalAmount - CrTotalAmount);
                }
                if ((DrTotalAmount - CrTotalAmount) < 0)
                {
                    cashBookResult[0].DrClosingBalance = Math.Abs(DrTotalAmount - CrTotalAmount);
                }
            }

            return PartialView(cashBookResult);
        }

    }
}
