using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{
    public class MaterialTypeRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public MaterialTypeRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get All Material Type
        /// </summary>
        /// <returns></returns>
        public static List<GroupByItemDTO> GetAllMaterialType()
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from groupByItems in projectManagementEntities.GroupByItems
                        select new GroupByItemDTO
                        {
                            GrpIdItem = groupByItems.GrpIdItem,
                            GroupItemName = groupByItems.GroupItemName,
                            GuIdGroup = groupByItems.GuIdGroup,
                            ChildOF = groupByItems.ChildOF
                        }).ToList();
            }
        }

        /// <summary>
        /// Get Material Type
        /// </summary>
        /// <returns></returns>
        public static GroupByItemDTO GetMaterialType(string typeId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from groupByItems in projectManagementEntities.GroupByItems
                        where string.Compare(groupByItems.GrpIdItem, typeId, StringComparison.CurrentCultureIgnoreCase) == 0
                        select new GroupByItemDTO
                        {
                            GrpIdItem = groupByItems.GrpIdItem,
                            GroupItemName = groupByItems.GroupItemName,
                            GuIdGroup = groupByItems.GuIdGroup,
                            ChildOF = groupByItems.ChildOF
                        }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Insert Material Type
        /// </summary>
        /// <returns></returns>
        public static string InsertMaterialType(GroupByItemDTO groupByItemDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var groupByItem = new GroupByItem();
                groupByItem = groupByItemDTO.ToEntity();
                projectManagementEntities.GroupByItems.Add(groupByItem);
                projectManagementEntities.SaveChanges();
                return groupByItem.GrpIdItem;
            }
        }

        /// <summary>
        /// Update Material Type
        /// </summary>
        /// <returns></returns>
        public static string UpdateMaterialType(GroupByItemDTO groupByItemDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var groupByItem = new GroupByItem();
                groupByItem = projectManagementEntities.GroupByItems.Where(type => string.Compare(type.GrpIdItem, groupByItemDTO.GrpIdItem, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                groupByItem.GrpIdItem = groupByItemDTO.GrpIdItem;
                groupByItem.GroupItemName = groupByItemDTO.GroupItemName;
                groupByItem.GuIdGroup = groupByItemDTO.GuIdGroup;
                groupByItem.ChildOF = groupByItemDTO.ChildOF;
                projectManagementEntities.SaveChanges();
                return groupByItem.GrpIdItem;
            }
        }

        /// <summary>
        /// Is Duplicate Material Type
        /// </summary>
        /// <returns></returns>
        public static bool IsDuplicateMaterialType(string typeName, string typedId)
        {
            if (typedId == null)
                typedId = string.Empty;
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var GroupByItemCount = projectManagementEntities.GroupByItems.Where(type => string.Compare(type.GroupItemName, typeName, StringComparison.CurrentCultureIgnoreCase) == 0
                                                                            && string.Compare(type.GrpIdItem, typedId, StringComparison.CurrentCultureIgnoreCase) != 0).Count();

                return GroupByItemCount == 0 ? false : true;
            }
        }

        /// <summary>
        /// Delete Material Type
        /// </summary>
        /// <returns></returns>
        public static bool DeleteMaterialType(string typeId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var groupByItemsResult = projectManagementEntities.GroupByItems.Where(sup => string.Compare(sup.GrpIdItem, typeId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                projectManagementEntities.GroupByItems.Remove(groupByItemsResult);
                return projectManagementEntities.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Update Material Type
        /// </summary>
        /// <returns></returns>
        public static string GetGrpIdItem()
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var groupItemCount = projectManagementEntities.GroupByItems.Count();
                return (groupItemCount + 1).ToString("D4");
            }
        }

        #endregion
    }
}
