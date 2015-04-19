using ProjectManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.Web
{
    public class TrialReportModel
    {
        public List<TrialReportDTO> CreditList { get; set; }
        public List<TrialReportDTO> DebitList { get; set; }
    }
}