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

        #region [Approval]

        /// <summary>
        /// Get Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static del_Mat_AccountTwoDTO GetPendingTransactionEntry(string entryId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from matAccountTwo in projectManagementEntities.Del_Mat_AccountTwo
                        join suppliersFromAccount in projectManagementEntities.Suppliers
                                on matAccountTwo.From_Account equals suppliersFromAccount.Sup_id
                        join suppliersToAccount in projectManagementEntities.Suppliers
                                on matAccountTwo.To_Account equals suppliersToAccount.Sup_id
                        where string.Compare(matAccountTwo.Ent_No, entryId, StringComparison.CurrentCultureIgnoreCase) == 0
                        select new del_Mat_AccountTwoDTO
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
                            ToSupplierName = suppliersToAccount.NameiS,
                            EntryType = matAccountTwo.EntryType
                        }).FirstOrDefault();
            }
        }


        /// <summary>
        /// Get All Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static List<del_Mat_AccountTwoDTO> GetAllTransactionPendingApprovalEntry(string transactionType, DateTime startDate, DateTime endDate)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from matAccountTwo in projectManagementEntities.Del_Mat_AccountTwo
                        join suppliersFromAccount in projectManagementEntities.Suppliers
                                on matAccountTwo.From_Account equals suppliersFromAccount.Sup_id
                        join suppliersToAccount in projectManagementEntities.Suppliers
                                on matAccountTwo.To_Account equals suppliersToAccount.Sup_id
                        where string.Compare(matAccountTwo.Mode_Pay_Rec, transactionType, StringComparison.CurrentCultureIgnoreCase) == 0
                         && matAccountTwo.Ddate >= startDate && matAccountTwo.Ddate <= endDate
                        select new del_Mat_AccountTwoDTO
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
                            ToSupplierName = suppliersToAccount.NameiS,
                            EntryType = matAccountTwo.EntryType,
                        }).OrderByDescending(o => o.CurDate).ToList();
            }
        }

        #endregion


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
                        }).OrderByDescending(o => o.CurDate).ToList();
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
                int vrNoFromFinalTable = projectManagementEntities.Mat_AccountTwo.Max(e => (int)e.VrNo);
                if (vrNoFromFinalTable == null)
                {
                    vrNoFromFinalTable = 0;
                }
                int vrNoFromTempTable = projectManagementEntities.Del_Mat_AccountTwo.Max(e => (int)e.VrNo);
                if (vrNoFromTempTable == null)
                {
                    vrNoFromTempTable = 0;
                }
                if (vrNoFromFinalTable > vrNoFromTempTable)
                {
                    return vrNoFromFinalTable + 1;
                }
                else
                {
                    return vrNoFromTempTable + 1;
                }
            }
        }

        /// <summary>
        /// Insert Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static string InsertTransactionEntry(Mat_AccountTwoDTO matAccountTwoDTO, int memberTypeId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                string result = string.Empty;
                if (memberTypeId == 1)
                {
                    var matAccountTwo = new Mat_AccountTwo();
                    matAccountTwo = matAccountTwoDTO.ToEntity();
                    projectManagementEntities.Mat_AccountTwo.Add(matAccountTwo);
                    projectManagementEntities.SaveChanges();
                    result = matAccountTwo.Ent_No;
                }
                else
                {
                    var del_Mat_AccountTwo = new Del_Mat_AccountTwo();
                    del_Mat_AccountTwo.Ent_No = matAccountTwoDTO.Ent_No;
                    del_Mat_AccountTwo.VrNo = matAccountTwoDTO.VrNo;
                    del_Mat_AccountTwo.Mode_Pay_Rec = matAccountTwoDTO.Mode_Pay_Rec;
                    del_Mat_AccountTwo.Rec_Pay = matAccountTwoDTO.Rec_Pay;
                    del_Mat_AccountTwo.Ammount = matAccountTwoDTO.Ammount;
                    del_Mat_AccountTwo.Ddate = matAccountTwoDTO.Ddate;
                    del_Mat_AccountTwo.Disp = matAccountTwoDTO.Disp;
                    del_Mat_AccountTwo.From_Account = matAccountTwoDTO.From_Account;
                    del_Mat_AccountTwo.To_Account = matAccountTwoDTO.To_Account;
                    del_Mat_AccountTwo.Hand_Group = matAccountTwoDTO.Hand_Group;
                    del_Mat_AccountTwo.Kwat = matAccountTwoDTO.Kwat;
                    del_Mat_AccountTwo.Discount = matAccountTwoDTO.Discount;
                    del_Mat_AccountTwo.Hand = matAccountTwoDTO.Hand;
                    del_Mat_AccountTwo.SetViewOne = matAccountTwoDTO.SetViewOne;
                    del_Mat_AccountTwo.Freezed = matAccountTwoDTO.Freezed;
                    del_Mat_AccountTwo.IsEntryOnly = matAccountTwoDTO.IsEntryOnly;
                    del_Mat_AccountTwo.GuidAC = matAccountTwoDTO.GuidAC;
                    del_Mat_AccountTwo.CurDate = matAccountTwoDTO.CurDate;
                    del_Mat_AccountTwo.Hide = matAccountTwoDTO.Hide;
                    del_Mat_AccountTwo.ChqNo = matAccountTwoDTO.ChqNo;
                    del_Mat_AccountTwo.ChqDrawn = matAccountTwoDTO.ChqDrawn;
                    del_Mat_AccountTwo.Userss = matAccountTwoDTO.Userss;
                    del_Mat_AccountTwo.fy = matAccountTwoDTO.fy;
                    del_Mat_AccountTwo.EntryType = 1;
                    projectManagementEntities.Del_Mat_AccountTwo.Add(del_Mat_AccountTwo);
                    projectManagementEntities.SaveChanges();
                    result = del_Mat_AccountTwo.Ent_No;
                }
                return result;
            }
        }

        /// <summary>
        /// Update Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static string UpdateTransactionEntry(Mat_AccountTwoDTO matAccountTwoDTO, int memberTypeId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                string result = string.Empty;
                if (memberTypeId == 1)
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
                    result = matAccountTwo.Ent_No;
                }
                else
                {
                    var del_Mat_AccountTwo = new Del_Mat_AccountTwo();
                    del_Mat_AccountTwo.Ent_No = matAccountTwoDTO.Ent_No;
                    del_Mat_AccountTwo.VrNo = matAccountTwoDTO.VrNo;
                    del_Mat_AccountTwo.Mode_Pay_Rec = matAccountTwoDTO.Mode_Pay_Rec;
                    del_Mat_AccountTwo.Rec_Pay = matAccountTwoDTO.Rec_Pay;
                    del_Mat_AccountTwo.Ammount = matAccountTwoDTO.Ammount;
                    del_Mat_AccountTwo.Ddate = matAccountTwoDTO.Ddate;
                    del_Mat_AccountTwo.Disp = matAccountTwoDTO.Disp;
                    del_Mat_AccountTwo.From_Account = matAccountTwoDTO.From_Account;
                    del_Mat_AccountTwo.To_Account = matAccountTwoDTO.To_Account;
                    del_Mat_AccountTwo.Hand_Group = matAccountTwoDTO.Hand_Group;
                    del_Mat_AccountTwo.Kwat = matAccountTwoDTO.Kwat;
                    del_Mat_AccountTwo.Discount = matAccountTwoDTO.Discount;
                    del_Mat_AccountTwo.Hand = matAccountTwoDTO.Hand;
                    del_Mat_AccountTwo.SetViewOne = matAccountTwoDTO.SetViewOne;
                    del_Mat_AccountTwo.Freezed = matAccountTwoDTO.Freezed;
                    del_Mat_AccountTwo.IsEntryOnly = matAccountTwoDTO.IsEntryOnly;
                    del_Mat_AccountTwo.GuidAC = matAccountTwoDTO.GuidAC;
                    del_Mat_AccountTwo.CurDate = matAccountTwoDTO.CurDate;
                    del_Mat_AccountTwo.Hide = matAccountTwoDTO.Hide;
                    del_Mat_AccountTwo.ChqNo = matAccountTwoDTO.ChqNo;
                    del_Mat_AccountTwo.ChqDrawn = matAccountTwoDTO.ChqDrawn;
                    del_Mat_AccountTwo.Userss = matAccountTwoDTO.Userss;
                    del_Mat_AccountTwo.fy = matAccountTwoDTO.fy;
                    del_Mat_AccountTwo.EntryType = 2;
                    projectManagementEntities.Del_Mat_AccountTwo.Add(del_Mat_AccountTwo);
                    result = del_Mat_AccountTwo.Ent_No;
                }
                projectManagementEntities.SaveChanges();
                return result;
            }
        }

        /// <summary>
        /// Delete Transaction Entry
        /// </summary>
        /// <returns></returns>
        public static bool DeleteTransactionEntry(string entyId, int memberTypeId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                if (memberTypeId == 1)
                {
                    var matAccountEntry = projectManagementEntities.Mat_AccountTwo.Where(matAccount => string.Compare(matAccount.Ent_No, entyId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                    projectManagementEntities.Mat_AccountTwo.Remove(matAccountEntry);
                    return projectManagementEntities.SaveChanges() > 0;
                }
                else
                {
                    var matAccountEntry = projectManagementEntities.Mat_AccountTwo.Where(matAccount => string.Compare(matAccount.Ent_No, entyId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                    var del_Mat_AccountTwo = new Del_Mat_AccountTwo();
                    del_Mat_AccountTwo.Ent_No = matAccountEntry.Ent_No;
                    del_Mat_AccountTwo.VrNo = matAccountEntry.VrNo;
                    del_Mat_AccountTwo.Mode_Pay_Rec = matAccountEntry.Mode_Pay_Rec;
                    del_Mat_AccountTwo.Rec_Pay = matAccountEntry.Rec_Pay;
                    del_Mat_AccountTwo.Ammount = matAccountEntry.Ammount;
                    del_Mat_AccountTwo.Ddate = matAccountEntry.Ddate;
                    del_Mat_AccountTwo.Disp = matAccountEntry.Disp;
                    del_Mat_AccountTwo.From_Account = matAccountEntry.From_Account;
                    del_Mat_AccountTwo.To_Account = matAccountEntry.To_Account;
                    del_Mat_AccountTwo.Hand_Group = matAccountEntry.Hand_Group;
                    del_Mat_AccountTwo.Kwat = matAccountEntry.Kwat;
                    del_Mat_AccountTwo.Discount = matAccountEntry.Discount;
                    del_Mat_AccountTwo.Hand = matAccountEntry.Hand;
                    del_Mat_AccountTwo.SetViewOne = matAccountEntry.SetViewOne;
                    del_Mat_AccountTwo.Freezed = matAccountEntry.Freezed;
                    del_Mat_AccountTwo.IsEntryOnly = matAccountEntry.IsEntryOnly;
                    del_Mat_AccountTwo.GuidAC = matAccountEntry.GuidAC;
                    del_Mat_AccountTwo.CurDate = matAccountEntry.CurDate;
                    del_Mat_AccountTwo.Hide = matAccountEntry.Hide;
                    del_Mat_AccountTwo.ChqNo = matAccountEntry.ChqNo;
                    del_Mat_AccountTwo.ChqDrawn = matAccountEntry.ChqDrawn;
                    del_Mat_AccountTwo.Userss = matAccountEntry.Userss;
                    del_Mat_AccountTwo.fy = matAccountEntry.fy;
                    del_Mat_AccountTwo.EntryType = 3;
                    projectManagementEntities.Del_Mat_AccountTwo.Add(del_Mat_AccountTwo);
                    return projectManagementEntities.SaveChanges() > 0;
                }
            }
        }

        /// <summary>
        /// Approve Transaction
        /// </summary>
        /// <returns></returns>
        public static bool ApproveTransaction(string entyId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var tempEntry = projectManagementEntities.Del_Mat_AccountTwo.Where(matAccount => string.Compare(matAccount.Ent_No, entyId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();

                if (tempEntry.EntryType == 1 || tempEntry.EntryType == 2)
                {
                    var matAccountEntry = new Mat_AccountTwo();
                    if (tempEntry.EntryType == 1)
                    {
                        projectManagementEntities.Mat_AccountTwo.Add(matAccountEntry);
                    }
                    else
                    {
                        matAccountEntry = projectManagementEntities.Mat_AccountTwo.Where(matAccount => string.Compare(matAccount.Ent_No, entyId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                    }

                    matAccountEntry.Ent_No = tempEntry.Ent_No;
                    matAccountEntry.VrNo = tempEntry.VrNo;
                    matAccountEntry.Mode_Pay_Rec = tempEntry.Mode_Pay_Rec;
                    matAccountEntry.Rec_Pay = tempEntry.Rec_Pay;
                    matAccountEntry.Ammount = tempEntry.Ammount;
                    matAccountEntry.Ddate = tempEntry.Ddate;
                    matAccountEntry.Disp = tempEntry.Disp;
                    matAccountEntry.From_Account = tempEntry.From_Account;
                    matAccountEntry.To_Account = tempEntry.To_Account;
                    matAccountEntry.Hand_Group = tempEntry.Hand_Group;
                    matAccountEntry.Kwat = tempEntry.Kwat;
                    matAccountEntry.Discount = tempEntry.Discount;
                    matAccountEntry.Hand = tempEntry.Hand;
                    matAccountEntry.SetViewOne = tempEntry.SetViewOne;
                    matAccountEntry.Freezed = tempEntry.Freezed;
                    matAccountEntry.IsEntryOnly = tempEntry.IsEntryOnly;
                    matAccountEntry.GuidAC = tempEntry.GuidAC;
                    matAccountEntry.CurDate = tempEntry.CurDate;
                    matAccountEntry.Hide = tempEntry.Hide;
                    matAccountEntry.ChqNo = tempEntry.ChqNo;
                    matAccountEntry.ChqDrawn = tempEntry.ChqDrawn;
                    matAccountEntry.Userss = tempEntry.Userss;
                    matAccountEntry.fy = tempEntry.fy;

                    projectManagementEntities.Del_Mat_AccountTwo.Remove(tempEntry);
                }
                else
                {
                    var matAccountEntry = projectManagementEntities.Mat_AccountTwo.Where(matAccount => string.Compare(matAccount.Ent_No, entyId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                    projectManagementEntities.Mat_AccountTwo.Remove(matAccountEntry);
                }
                return projectManagementEntities.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Approve Transaction
        /// </summary>
        /// <returns></returns>
        public static bool DisapproveTransaction(string entyId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var tempEntry = projectManagementEntities.Del_Mat_AccountTwo.Where(matAccount => string.Compare(matAccount.Ent_No, entyId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                projectManagementEntities.Del_Mat_AccountTwo.Remove(tempEntry);
                return projectManagementEntities.SaveChanges() > 0;
            }
        }


        #endregion
    }
}
