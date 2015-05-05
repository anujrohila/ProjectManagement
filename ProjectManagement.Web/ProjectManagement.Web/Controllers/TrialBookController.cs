using ProjectManagement.DLL;
using ProjectManagement.Domain;
using System;
using System.Globalization;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace ProjectManagement.Web.Controllers
{
    public class TrialBookController : BaseController
    {
        [HttpGet]
        public ActionResult ListAll()
        {
            var trialReportModel = new TrialReportModel();
            trialReportModel.CreditList = ReportRepository.TrailCreditReport();
            trialReportModel.DebitList = ReportRepository.TrailDebitReport();
            return View(trialReportModel);
        }
    }
}
