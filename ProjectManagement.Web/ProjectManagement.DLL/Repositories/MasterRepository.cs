using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{
    public class MasterRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public MasterRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get All Supplier Type
        /// </summary>
        /// <returns></returns>
        public static List<GroupBySupplierDTO> GetAllSupplierType()
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from groupBySupplier in projectManagementEntities.GroupBySuppliers
                        select new GroupBySupplierDTO
                        {
                            GrpIdSupplier = groupBySupplier.GrpIdSupplier,
                            GroupSupplierName = groupBySupplier.GroupSupplierName,
                            childOf = groupBySupplier.childOf,
                            ClosingBalance = groupBySupplier.ClosingBalance,
                            Display = groupBySupplier.Display
                        }).ToList();
            }
        }

        #endregion
    }
}
