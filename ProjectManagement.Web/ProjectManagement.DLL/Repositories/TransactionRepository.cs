using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{
    public class TransactionRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public TransactionRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get All Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static List<Mat_AccountTwoDTO> GetAllTransactionEntry(string transactionType, DateTime startDate, DateTime endDate)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from matAccountTwo in projectManagementEntities.Mat_AccountTwo
                        join suppliersFromAccount in projectManagementEntities.Suppliers
                                on matAccountTwo.From_Account equals suppliersFromAccount.Sup_id
                        join suppliersToAccount in projectManagementEntities.Suppliers
                                on matAccountTwo.To_Account equals suppliersToAccount.Sup_id
                        where string.Compare(matAccountTwo.Mode_Pay_Rec, transactionType, StringComparison.CurrentCultureIgnoreCase) == 0
                         && matAccountTwo.Ddate >= startDate && matAccountTwo.Ddate <= endDate
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
                            FromSupplierName = suppliersFromAccount.NameiS,
                            ToSupplierName = suppliersToAccount.NameiS
                        }).ToList();
            }
        }

        /// <summary>
        /// Get Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static Mat_AccountTwoDTO GetTransactionEntry(string entryId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from matAccountTwo in projectManagementEntities.Mat_AccountTwo
                        join suppliersFromAccount in projectManagementEntities.Suppliers
                                on matAccountTwo.From_Account equals suppliersFromAccount.Sup_id
                        join suppliersToAccount in projectManagementEntities.Suppliers
                                on matAccountTwo.To_Account equals suppliersToAccount.Sup_id
                        where string.Compare(matAccountTwo.Ent_No, entryId, StringComparison.CurrentCultureIgnoreCase) == 0
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
                            FromSupplierName = suppliersFromAccount.NameiS,
                            ToSupplierName = suppliersToAccount.NameiS
                        }).FirstOrDefault();
            }
        }


        /// <summary>
        /// Get Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static int GetVRNO()
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                int? vrNo = projectManagementEntities.Mat_AccountTwo.Max(e => (int?)e.VrNo) + 1;
                return vrNo ?? 0;
            }
        }

        /// <summary>
        /// Insert Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static string InsertTransactionEntry(Mat_AccountTwoDTO matAccountTwoDTO)
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
        /// Update Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static string UpdateTransactionEntry(Mat_AccountTwoDTO matAccountTwoDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var matAccountTwo = new Mat_AccountTwo();
                matAccountTwo = projectManagementEntities.Mat_AccountTwo.Where(matAccount => string.Compare(matAccount.Ent_No, matAccountTwoDTO.Ent_No, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                matAccountTwo.Ent_No = matAccountTwoDTO.Ent_No;
                matAccountTwo.VrNo = matAccountTwoDTO.VrNo;
                matAccountTwo.Mode_Pay_Rec = matAccountTwoDTO.Mode_Pay_Rec;
                matAccountTwo.Rec_Pay = matAccountTwoDTO.Rec_Pay;
                matAccountTwo.Ammount = matAccountTwoDTO.Ammount;
                matAccountTwo.Ddate = matAccountTwoDTO.Ddate;
                matAccountTwo.Disp = matAccountTwoDTO.Disp;
                matAccountTwo.From_Account = matAccountTwoDTO.From_Account;
                matAccountTwo.To_Account = matAccountTwoDTO.To_Account;
                matAccountTwo.Hand_Group = matAccountTwoDTO.Hand_Group;
                matAccountTwo.Kwat = matAccountTwoDTO.Kwat;
                matAccountTwo.Discount = matAccountTwoDTO.Discount;
                matAccountTwo.Hand = matAccountTwoDTO.Hand;
                matAccountTwo.SetViewOne = matAccountTwoDTO.SetViewOne;
                matAccountTwo.Freezed = matAccountTwoDTO.Freezed;
                matAccountTwo.IsEntryOnly = matAccountTwoDTO.IsEntryOnly;
                matAccountTwo.GuidAC = matAccountTwoDTO.GuidAC;
                matAccountTwo.CurDate = matAccountTwoDTO.CurDate;
                matAccountTwo.Hide = matAccountTwoDTO.Hide;
                matAccountTwo.ChqNo = matAccountTwoDTO.ChqNo;
                matAccountTwo.ChqDrawn = matAccountTwoDTO.ChqDrawn;
                matAccountTwo.Userss = matAccountTwoDTO.Userss;
                matAccountTwo.fy = matAccountTwoDTO.fy;
                projectManagementEntities.SaveChanges();
                return matAccountTwo.Ent_No;
            }
        }

        /// <summary>
        /// Delete Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static bool DeleteTransactionEntry(string entyId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var matAccountEntry = projectManagementEntities.Mat_AccountTwo.Where(matAccount => string.Compare(matAccount.Ent_No, entyId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                projectManagementEntities.Mat_AccountTwo.Remove(matAccountEntry);
                return projectManagementEntities.SaveChanges() > 0;
            }
        }

        #endregion
    }
}
