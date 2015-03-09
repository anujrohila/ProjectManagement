using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{
    public class MasterAccountRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public MasterAccountRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get All Master Account Entry
        /// </summary>
        /// <returns></returns>
        public static List<Mat_AccountTwoDTO> GetAllMasterAccountEntry()
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from matAccountTwo in projectManagementEntities.Mat_AccountTwo
                        join supplierFrom in projectManagementEntities.Suppliers
                              on matAccountTwo.From_Account equals supplierFrom.Sup_id
                        join supplierTo in projectManagementEntities.Suppliers
                              on matAccountTwo.To_Account equals supplierTo.Sup_id
                        select new Mat_AccountTwoDTO
                        {
                            Ent_No = matAccountTwo.Ent_No,
                            VrNo = matAccountTwo.VrNo,
                            Mode_Pay_Rec = matAccountTwo.Mode_Pay_Rec,
                            Rec_Pay = matAccountTwo.Rec_Pay,
                            Ammount = matAccountTwo.Ammount,
                            Ddate = matAccountTwo.Ddate,
                            Disp = matAccountTwo.Disp,
                            From_Account = matAccountTwo.From_Account,
                            To_Account = matAccountTwo.To_Account,
                            Hand_Group = matAccountTwo.Hand_Group,
                            Kwat = matAccountTwo.Kwat,
                            Discount = matAccountTwo.Discount,
                            Hand = matAccountTwo.Hand,
                            SetViewOne = matAccountTwo.SetViewOne,
                            Freezed = matAccountTwo.Freezed,
                            IsEntryOnly = matAccountTwo.IsEntryOnly,
                            GuidAC = matAccountTwo.GuidAC,
                            CurDate = matAccountTwo.CurDate,
                            Hide = matAccountTwo.Hide,
                            ChqNo = matAccountTwo.ChqNo,
                            ChqDrawn = matAccountTwo.ChqDrawn,
                            Userss = matAccountTwo.Userss,
                            fy = matAccountTwo.fy,
                            FromSupplierName = supplierFrom.NameiS,
                            ToSupplierName = supplierTo.NameiS
                        }).ToList();
            }
        }

        /// <summary>
        /// Get Master Account Entry
        /// </summary>
        /// <returns></returns>
        public static Mat_AccountTwoDTO GetMasterAccountEntry(string entryId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from matAccountTwo in projectManagementEntities.Mat_AccountTwo
                        join supplierFrom in projectManagementEntities.Suppliers
                              on matAccountTwo.From_Account equals supplierFrom.Sup_id
                        join supplierTo in projectManagementEntities.Suppliers
                              on matAccountTwo.To_Account equals supplierTo.Sup_id
                        select new Mat_AccountTwoDTO
                        {
                            Ent_No = matAccountTwo.Ent_No,
                            VrNo = matAccountTwo.VrNo,
                            Mode_Pay_Rec = matAccountTwo.Mode_Pay_Rec,
                            Rec_Pay = matAccountTwo.Rec_Pay,
                            Ammount = matAccountTwo.Ammount,
                            Ddate = matAccountTwo.Ddate,
                            Disp = matAccountTwo.Disp,
                            From_Account = matAccountTwo.From_Account,
                            To_Account = matAccountTwo.To_Account,
                            Hand_Group = matAccountTwo.Hand_Group,
                            Kwat = matAccountTwo.Kwat,
                            Discount = matAccountTwo.Discount,
                            Hand = matAccountTwo.Hand,
                            SetViewOne = matAccountTwo.SetViewOne,
                            Freezed = matAccountTwo.Freezed,
                            IsEntryOnly = matAccountTwo.IsEntryOnly,
                            GuidAC = matAccountTwo.GuidAC,
                            CurDate = matAccountTwo.CurDate,
                            Hide = matAccountTwo.Hide,
                            ChqNo = matAccountTwo.ChqNo,
                            ChqDrawn = matAccountTwo.ChqDrawn,
                            Userss = matAccountTwo.Userss,
                            fy = matAccountTwo.fy,
                            FromSupplierName = supplierFrom.NameiS,
                            ToSupplierName = supplierTo.NameiS
                        }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Insert Master Account Entry
        /// </summary>
        /// <returns></returns>
        public static string InsertMasterAccountEntry(Mat_AccountTwoDTO matAccountTwoDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var matAccountTwo = new Mat_AccountTwo();
                matAccountTwo = matAccountTwoDTO.ToEntity();
                projectManagementEntities.Mat_AccountTwo.Add(matAccountTwo);
                projectManagementEntities.SaveChanges();
                return matAccountTwo.Ent_No;
            }
        }

        /// <summary>
        /// Update Master Account Entry
        /// </summary>
        /// <returns></returns>
        public static string UpdateMasterAccountEntry(Mat_AccountTwoDTO matAccountTwoDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var matAccountTwo = new Mat_AccountTwo();
                matAccountTwo = projectManagementEntities.Mat_AccountTwo.Where(masterEntry => string.Compare(masterEntry.Ent_No, matAccountTwoDTO.Ent_No, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                matAccountTwo.Ent_No = matAccountTwo.Ent_No;
                matAccountTwo.VrNo = matAccountTwo.VrNo;
                matAccountTwo.Mode_Pay_Rec = matAccountTwo.Mode_Pay_Rec;
                matAccountTwo.Rec_Pay = matAccountTwo.Rec_Pay;
                matAccountTwo.Ammount = matAccountTwo.Ammount;
                matAccountTwo.Ddate = matAccountTwo.Ddate;
                matAccountTwo.Disp = matAccountTwo.Disp;
                matAccountTwo.From_Account = matAccountTwo.From_Account;
                matAccountTwo.To_Account = matAccountTwo.To_Account;
                matAccountTwo.Hand_Group = matAccountTwo.Hand_Group;
                matAccountTwo.Kwat = matAccountTwo.Kwat;
                matAccountTwo.Discount = matAccountTwo.Discount;
                matAccountTwo.Hand = matAccountTwo.Hand;
                matAccountTwo.SetViewOne = matAccountTwo.SetViewOne;
                matAccountTwo.Freezed = matAccountTwo.Freezed;
                matAccountTwo.IsEntryOnly = matAccountTwo.IsEntryOnly;
                matAccountTwo.GuidAC = matAccountTwo.GuidAC;
                matAccountTwo.CurDate = matAccountTwo.CurDate;
                matAccountTwo.Hide = matAccountTwo.Hide;
                matAccountTwo.ChqNo = matAccountTwo.ChqNo;
                matAccountTwo.ChqDrawn = matAccountTwo.ChqDrawn;
                matAccountTwo.Userss = matAccountTwo.Userss;
                matAccountTwo.fy = matAccountTwo.fy;
                projectManagementEntities.SaveChanges();
                return matAccountTwo.Ent_No;
            }
        }

        /// <summary>
        /// Delete Master Account Entry
        /// </summary>
        /// <returns></returns>
        public static bool DeleteMasterAccountEntry(string entryId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var matAccountTwo = projectManagementEntities.Mat_AccountTwo.Where(masterEntry => string.Compare(masterEntry.Ent_No, entryId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                projectManagementEntities.Mat_AccountTwo.Remove(matAccountTwo);
                return projectManagementEntities.SaveChanges() > 0;
            }
        }

        #endregion
    }
}
