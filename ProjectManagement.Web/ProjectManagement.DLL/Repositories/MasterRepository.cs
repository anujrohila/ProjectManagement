﻿using System;
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

        /// <summary>
        /// Get All Project
        /// </summary>
        /// <returns></returns>
        public static List<tblProjectDTO> GetAllProject()
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                return (from project in projectManagementSQLDatabaseEntities.tblProjects
                        select new tblProjectDTO
                        {
                            ProjectId = project.ProjectId,
                            Title = project.Title,
                            Address = project.Address,
                            Description = project.Description,
                            StratDateTime = project.StratDateTime,
                            Catalog = project.Catalog,
                            UserName = project.UserName,
                            Password = project.Password,
                            IsActive = project.IsActive,
                        }).ToList();
            }
        }

        /// <summary>
        /// Get All Entity
        /// </summary>
        /// <returns></returns>
        public static List<tblEntityMasterDTO> GetAllEntity()
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                return (from entityMaster in projectManagementSQLDatabaseEntities.tblEntityMasters
                        select new tblEntityMasterDTO
                        {
                            EntityId = entityMaster.EntityId,
                            EntityName = entityMaster.EntityName,
                            Description = entityMaster.Description
                        }).ToList();
            }
        }

        #endregion
    }
}
