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
     [CustomActionAutentication]
    public class MasterAccountController : Controller
    {

        public ActionResult ListAll()
        {
            return View();
        }

        /// <summary>
        /// List Master Account Ajax
        /// </summary>
        /// <returns></returns>
        [GridAction]
        public ActionResult ListMasterAccountAjax()
        {
            var getAllMasterAccountEntry = MasterAccountRepository.GetAllMasterAccountEntry();
            return View(new GridModel(getAllMasterAccountEntry));
        }

        /// <summary>
        /// Save Master Account
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Save(string id)
        {
            var matAccountTwoDTO = new Mat_AccountTwoDTO();
            if (!string.IsNullOrWhiteSpace(id))
            {
                matAccountTwoDTO = MasterAccountRepository.GetMasterAccountEntry(id);
            }
            matAccountTwoDTO = FillMasterAccountDTO(matAccountTwoDTO);
            return View(matAccountTwoDTO);
        }

        /// <summary>
        /// Save Master Account
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(Mat_AccountTwoDTO matAccountTwoDTO)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    matAccountTwoDTO.Userss = ApplicationMember.LoggedUserName;
                    if (string.IsNullOrWhiteSpace(matAccountTwoDTO.Ent_No))
                    {
                        matAccountTwoDTO.Ent_No = CommonFunctions.GetNewGUID();
                        MasterAccountRepository.InsertMasterAccountEntry(matAccountTwoDTO);
                    }
                    else
                    {
                        MasterAccountRepository.UpdateMasterAccountEntry(matAccountTwoDTO);
                    }
                    return RedirectToAction("ListAll");
                }
            }
            matAccountTwoDTO = FillMasterAccountDTO(matAccountTwoDTO);
            return View(matAccountTwoDTO);
        }

        /// <summary>
        /// Fill Master Account DTO
        /// </summary>
        /// <param name="matAccountTwoDTO"></param>
        /// <returns></returns>
        private Mat_AccountTwoDTO FillMasterAccountDTO(Mat_AccountTwoDTO matAccountTwoDTO)
        {
            matAccountTwoDTO.FromSupplierList = SupplierRepository.GetAllSupplier();
            matAccountTwoDTO.ToSupplierList = SupplierRepository.GetAllSupplier();
            matAccountTwoDTO.FromSupplierList.Insert(0, new SupplierDTO { Sup_id = "0", NameiS = "Select" });
            matAccountTwoDTO.ToSupplierList.Insert(0, new SupplierDTO { Sup_id = "0", NameiS = "Select" });
            return matAccountTwoDTO;
        }

        /// <summary>
        /// Delete Master Account
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(string entryId)
        {
            var result = MasterAccountRepository.DeleteMasterAccountEntry(entryId);
            if (result)
            {
                return Json(new { Success = true, Message = "Master account deleted successfully." });
            }
            return Json(new { Success = false, Message = "Error in transaction please try again later." });
        }
    }
}
