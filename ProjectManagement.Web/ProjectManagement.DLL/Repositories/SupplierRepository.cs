using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{
    public class SupplierRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public SupplierRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get Supplier
        /// </summary>
        /// <returns></returns>
        public static List<SupplierDTO> GetAllSupplier()
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from supplierObject in projectManagementEntities.Suppliers
                        join supplierGroup in projectManagementEntities.GroupBySuppliers
                              on supplierObject.GroupId equals supplierGroup.GrpIdSupplier
                        select new SupplierDTO
                        {
                            Sup_id = supplierObject.Sup_id,
                            NameiS = supplierObject.NameiS,
                            AddiS = supplierObject.AddiS,
                            City = supplierObject.City,
                            OpBalance = supplierObject.OpBalance,
                            Sup_Ph = supplierObject.Sup_Ph,
                            creditday = supplierObject.creditday,
                            creditammount = supplierObject.creditammount,
                            GroupId = supplierObject.GroupId,
                            GuIdSup = supplierObject.GuIdSup,
                            share = supplierObject.share,
                            CutDate = supplierObject.CutDate,
                            Adding = supplierObject.Adding,
                            IntRates = supplierObject.IntRates,
                            AutoUpdate = supplierObject.AutoUpdate,
                            alias = supplierObject.alias,
                            userss = supplierObject.userss,
                            childof = supplierObject.childof,
                            Balance = supplierObject.Balance,
                            CashBankBalance = supplierObject.CashBankBalance,
                            SupplierGroupName = supplierGroup.GroupSupplierName
                        }).ToList();
            }
        }

        /// <summary>
        /// Get Supplier
        /// </summary>
        /// <returns></returns>
        public static SupplierDTO GetSupplier(string supplierId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from supplierObject in projectManagementEntities.Suppliers
                        join supplierGroup in projectManagementEntities.GroupBySuppliers
                              on supplierObject.GroupId equals supplierGroup.GrpIdSupplier
                        where string.Compare(supplierObject.Sup_id, supplierId, StringComparison.CurrentCultureIgnoreCase) == 0
                        select new SupplierDTO
                        {
                            Sup_id = supplierObject.Sup_id,
                            NameiS = supplierObject.NameiS,
                            AddiS = supplierObject.AddiS,
                            City = supplierObject.City,
                            OpBalance = supplierObject.OpBalance,
                            Sup_Ph = supplierObject.Sup_Ph,
                            creditday = supplierObject.creditday,
                            creditammount = supplierObject.creditammount,
                            GroupId = supplierObject.GroupId,
                            GuIdSup = supplierObject.GuIdSup,
                            share = supplierObject.share,
                            CutDate = supplierObject.CutDate,
                            Adding = supplierObject.Adding,
                            IntRates = supplierObject.IntRates,
                            AutoUpdate = supplierObject.AutoUpdate,
                            alias = supplierObject.alias,
                            userss = supplierObject.userss,
                            childof = supplierObject.childof,
                            Balance = supplierObject.Balance,
                            CashBankBalance = supplierObject.CashBankBalance,
                            SupplierGroupName = supplierGroup.GroupSupplierName
                        }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Insert Supplier
        /// </summary>
        /// <returns></returns>
        public static string InsertSupplier(SupplierDTO supplierDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var supplier = new Supplier();
                supplier = supplierDTO.ToEntity();
                projectManagementEntities.Suppliers.Add(supplier);
                projectManagementEntities.SaveChanges();
                return supplier.Sup_id;
            }
        }

        /// <summary>
        /// Update Supplier
        /// </summary>
        /// <returns></returns>
        public static string UpdateSupplier(SupplierDTO supplierDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var supplier = new Supplier();
                supplier = projectManagementEntities.Suppliers.Where(sup => string.Compare(sup.Sup_id, supplierDTO.Sup_id, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                supplier.Sup_id = supplierDTO.Sup_id;
                supplier.NameiS = supplierDTO.NameiS;
                supplier.AddiS = supplierDTO.AddiS;
                supplier.City = supplierDTO.City;
                supplier.OpBalance = supplierDTO.OpBalance;
                supplier.Sup_Ph = supplierDTO.Sup_Ph;
                supplier.creditday = supplierDTO.creditday;
                supplier.creditammount = supplierDTO.creditammount;
                supplier.GroupId = supplierDTO.GroupId;
                supplier.GuIdSup = supplierDTO.GuIdSup;
                supplier.share = supplierDTO.share;
                supplier.CutDate = supplierDTO.CutDate;
                supplier.Adding = supplierDTO.Adding;
                supplier.IntRates = supplierDTO.IntRates;
                supplier.AutoUpdate = supplierDTO.AutoUpdate;
                supplier.alias = supplierDTO.alias;
                supplier.userss = supplierDTO.userss;
                supplier.childof = supplierDTO.childof;
                supplier.Balance = supplierDTO.Balance;
                supplier.CashBankBalance = supplierDTO.CashBankBalance;
                projectManagementEntities.SaveChanges();
                return supplier.Sup_id;
            }
        }

        /// <summary>
        /// Is Duplicate Supplier
        /// </summary>
        /// <returns></returns>
        public static bool IsDuplicateSupplier(string supplieName, string supplierId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var supplierCount = projectManagementEntities.Suppliers.Where(sup => string.Compare(sup.NameiS, supplieName, StringComparison.CurrentCultureIgnoreCase) == 0
                                                                            && string.Compare(sup.Sup_id, supplierId, StringComparison.CurrentCultureIgnoreCase) != 0).Count();

                return supplierCount == 0 ? false : true;
            }
        }

        /// <summary>
        /// Delete Supplier
        /// </summary>
        /// <returns></returns>
        public static bool DeleteSupplier(string supplierId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var supplier = projectManagementEntities.Suppliers.Where(sup => string.Compare(sup.Sup_id, supplierId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                projectManagementEntities.Suppliers.Remove(supplier);
                return projectManagementEntities.SaveChanges() > 0;
            }
        }

        #endregion
    }
}
