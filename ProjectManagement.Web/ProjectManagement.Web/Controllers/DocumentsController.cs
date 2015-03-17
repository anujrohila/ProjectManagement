using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManagement.DLL;
using ProjectManagement.Domain;
using ProjectManagement.DLL.Repositories;
using Telerik.Web.Mvc;



namespace ProjectManagement.Web.Controllers
{
    public class DocumentsController : Controller
    {
        //
        // GET: /Documents/
        [HttpGet]
        public ActionResult Save()
        {
            var supplierDTO = new tblImageMasterDTO();
            return View(supplierDTO);
        }

        /// <summary>
        /// List Document Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListDocuementAjax()
        {
            var Docuementdata = DocumentsRepository.GetAllDocumentsDetails();
            var DocData = new List<tblImageMasterDTO>();
            foreach(var item in Docuementdata)
            {
              //  item.ImagesPath = CommonFunctions.WebUrlPrefix
            }
            return View(new GridModel(Docuementdata));
        }

        [HttpPost]
        public ActionResult Save(tblImageMasterDTO tblImageMasterDTO, HttpPostedFileBase FileName)
        {
            string path = System.IO.Path.Combine(Server.MapPath("~/Documents"), System.IO.Path.GetFileName(FileName.FileName));
            FileName.SaveAs(path);
            tblImageMasterDTO.CreateBy = 1;
            tblImageMasterDTO.CreationDateTime = DateTime.Now;
            tblImageMasterDTO.ImagesPath = FileName.FileName;
            bool retunvalue = DocumentsRepository.SaveDocuement(tblImageMasterDTO);
            if (retunvalue)
                return RedirectToAction("ListAll");
            return View();
        }

        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// Delete Supplier
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(int Docuementid)
        {
            var result = DocumentsRepository.DeleteDocuement(Docuementid);
            if (result)
            {
                return Json(new { Success = true, Message = "Document deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }

    }
}
