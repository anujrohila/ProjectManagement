using ProjectManagement.DLL;
using ProjectManagement.Domain;
using System;
using System.Globalization;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace ProjectManagement.Web.Controllers
{
    public class TrialBookController : Controller
    {
        [HttpGet]
        public ActionResult ListAll()
        {
            var trialReportModel = new TrialReportModel();
            trialReportModel.TrailReportData = ReportRepository.TrailBalanceSheetReport();
            return View(trialReportModel);
        }
    }
}
