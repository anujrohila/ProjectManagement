using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{
    public class ReportRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public ReportRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get Cash Book Report
        /// </summary>
        /// <returns></returns>
        public static List<tblReportDTO> CashBookReport(string accountId, DateTime tDate)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from matAccountTwo in projectManagementEntities.Mat_AccountTwo
                        join supplierFrom in projectManagementEntities.Suppliers
                              on matAccountTwo.From_Account equals supplierFrom.Sup_id
                        join supplierTo in projectManagementEntities.Suppliers
                              on matAccountTwo.To_Account equals supplierTo.Sup_id
                        where (string.Compare(matAccountTwo.From_Account, accountId, StringComparison.CurrentCultureIgnoreCase) == 0
                                || string.Compare(matAccountTwo.To_Account, accountId, StringComparison.CurrentCultureIgnoreCase) == 0
                              )
                              &&
                              (string.Compare(matAccountTwo.Mode_Pay_Rec, "CASH", StringComparison.CurrentCultureIgnoreCase) == 0
                                || string.Compare(matAccountTwo.Mode_Pay_Rec, "CONTRA", StringComparison.CurrentCultureIgnoreCase) == 0
                              )
                              && matAccountTwo.Ddate >= tDate
                        select new tblReportDTO
                        {
                            TransactionType = supplierFrom.NameiS,
                            Supplier1Id = supplierFrom.Sup_id,
                            Supplier1TypeName = supplierTo.NameiS,
                            Supplier2Id = supplierTo.Sup_id,
                            EntryId = matAccountTwo.Ent_No,
                            VrNo = matAccountTwo.VrNo,
                            ModePaymentReceipt = matAccountTwo.Mode_Pay_Rec,
                            RecPay = matAccountTwo.Rec_Pay,
                            Amount = matAccountTwo.Ammount,
                            DDate = matAccountTwo.Ddate,
                            Description = matAccountTwo.Disp,
                            FromAccount = matAccountTwo.From_Account,
                            ToAccount = matAccountTwo.To_Account,
                            HandGroup = matAccountTwo.Hand_Group,
                            Kwat = matAccountTwo.Kwat,
                            Discount = matAccountTwo.Discount,
                            Hand = matAccountTwo.Hand,
                            SetViewOne = matAccountTwo.SetViewOne,
                            IsEntryOnly = matAccountTwo.IsEntryOnly,
                            GuidAC = matAccountTwo.GuidAC,
                            CurDate = matAccountTwo.CurDate,
                            Hide = matAccountTwo.Hide,
                            ChequeNo = matAccountTwo.ChqNo,
                            Users = matAccountTwo.Userss,
                            FiscalYear = matAccountTwo.fy,
                        }).OrderBy(r => r.DDate).ToList();
            }
        }
        /// <summary>
        /// Get Cash Book Report
        /// </summary>
        /// <returns></returns>
        public static double GetLedgerOpeningBalance(string accountId, DateTime tDate)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                double finalAmount = 0;



                if (tDate != DateTime.Now)
                {

                    var openingBalance = (from sup in projectManagementEntities.Suppliers
                                          where (string.Compare(sup.childof, accountId, StringComparison.CurrentCultureIgnoreCase) == 0
                                                  || string.Compare(sup.Sup_id, accountId, StringComparison.CurrentCultureIgnoreCase) == 0
                                                )
                                          select sup.OpBalance
                                     ).Sum();

                    if (openingBalance == null)
                        openingBalance = 0;

                    var fromBalance = (from matAccountTwo in projectManagementEntities.Mat_AccountTwo
                                       join supplierFrom in projectManagementEntities.Suppliers
                                             on matAccountTwo.From_Account equals supplierFrom.Sup_id
                                       where (string.Compare(supplierFrom.childof, accountId, StringComparison.CurrentCultureIgnoreCase) == 0
                                                  || string.Compare(supplierFrom.Sup_id, accountId, StringComparison.CurrentCultureIgnoreCase) == 0
                                                )
                                                && matAccountTwo.Ddate < tDate
                                       select matAccountTwo.Ammount).Sum();

                    if (fromBalance == null)
                        fromBalance = 0;

                    var toBalance = (from matAccountTwo in projectManagementEntities.Mat_AccountTwo
                                     join supplierTo in projectManagementEntities.Suppliers
                                            on matAccountTwo.To_Account equals supplierTo.Sup_id
                                     where (string.Compare(supplierTo.childof, accountId, StringComparison.CurrentCultureIgnoreCase) == 0
                                                  || string.Compare(supplierTo.Sup_id, accountId, StringComparison.CurrentCultureIgnoreCase) == 0
                                                )
                                            && matAccountTwo.Ddate < tDate
                                     select matAccountTwo.Ammount).Sum();

                    if (toBalance == null)
                        toBalance = 0;

                    finalAmount = Convert.ToDouble(openingBalance + fromBalance + toBalance);
                }
                else
                {

                    var openingBalance = (from sup in projectManagementEntities.Suppliers
                                          where string.Compare(sup.childof, accountId, StringComparison.CurrentCultureIgnoreCase) == 0
                                          select sup.OpBalance
                                    ).Sum();

                    finalAmount = Convert.ToDouble(openingBalance);
                }

                return finalAmount;

            }
        }

        #endregion
    }
}
