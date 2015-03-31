using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using ProjectManagement.DLL;
using ProjectManagement.Domain;

namespace ProjectManagement.Web.Controllers
{
    public class LedgerReportController : Controller
    {
        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// List Supplier Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListSupplierAjax()
        {
            var supplierListGrid = SupplierRepository.GetAllSupplier();
            return View(new GridModel(supplierListGrid));
        }

    }
}
