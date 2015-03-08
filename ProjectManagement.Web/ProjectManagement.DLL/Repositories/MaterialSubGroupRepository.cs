using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{
    public class MaterialSubGroupRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public MaterialSubGroupRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get All Material Sub Group
        /// </summary>
        /// <returns></returns>
        public static List<MaterialDTO> GetAllMaterialSubGroup()
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from materials in projectManagementEntities.Materials
                        select new MaterialDTO
                        {
                            Mat_id = materials.Mat_id,
                            Mat_Name = materials.Mat_Name,
                            Mat_Unit = materials.Mat_Unit,
                            Basic_Rate = materials.Basic_Rate,
                            GroupId = materials.GroupId,
                            GuIdMaterial = materials.GuIdMaterial,
                            userss = materials.userss,
                        }).ToList();
            }
        }

        /// <summary>
        /// Get Material Sub Group
        /// </summary>
        /// <returns></returns>
        public static MaterialDTO GetMaterialSubGroup(string subTypeId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from materials in projectManagementEntities.Materials
                        where string.Compare(materials.Mat_id, subTypeId, StringComparison.CurrentCultureIgnoreCase) == 0
                        select new MaterialDTO
                        {
                            Mat_id = materials.Mat_id,
                            Mat_Name = materials.Mat_Name,
                            Mat_Unit = materials.Mat_Unit,
                            Basic_Rate = materials.Basic_Rate,
                            GroupId = materials.GroupId,
                            GuIdMaterial = materials.GuIdMaterial,
                            userss = materials.userss,
                        }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Insert Material Sub Group
        /// </summary>
        /// <returns></returns>
        public static string InsertMaterialSubGroup(MaterialDTO materialDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var material = new Material();
                material = materialDTO.ToEntity();
                projectManagementEntities.Materials.Add(material);
                projectManagementEntities.SaveChanges();
                return material.Mat_id;
            }
        }

        /// <summary>
        /// Update Supplier
        /// </summary>
        /// <returns></returns>
        public static string UpdateMaterialSubGroup(MaterialDTO materialDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var material = new Material();
                material = projectManagementEntities.Materials.Where(materialObject => string.Compare(materialObject.Mat_id, materialDTO.Mat_id, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                material.Mat_id = materialDTO.Mat_id;
                material.Mat_Name = materialDTO.Mat_Name;
                material.Mat_Unit = materialDTO.Mat_Unit;
                material.Basic_Rate = materialDTO.Basic_Rate;
                material.GroupId = materialDTO.GroupId;
                material.GuIdMaterial = materialDTO.GuIdMaterial;
                material.userss = materialDTO.userss;
                projectManagementEntities.SaveChanges();
                return material.Mat_id;
            }
        }

        /// <summary>
        /// Is Duplicate Material Sub Group
        /// </summary>
        /// <returns></returns>
        public static bool IsDuplicateMaterialSubGroup(string subGroupName, string subGroupId, string groupId)
        {
            if (subGroupId == null)
                subGroupId = string.Empty;
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var materialsCount = projectManagementEntities.Materials.Where(materialObject => string.Compare(materialObject.Mat_Name, subGroupName, StringComparison.CurrentCultureIgnoreCase) == 0
                                                                            && string.Compare(materialObject.Mat_id, subGroupId, StringComparison.CurrentCultureIgnoreCase) != 0
                                                                            && string.Compare(materialObject.GroupId, groupId, StringComparison.CurrentCultureIgnoreCase) == 0).Count();

                return materialsCount == 0 ? false : true;
            }
        }

        /// <summary>
        /// Delete Material Sub Group
        /// </summary>
        /// <returns></returns>
        public static bool DeleteMaterialSubGroup(string subGroupId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var materialsDetail = projectManagementEntities.Materials.Where(sup => string.Compare(sup.Mat_id, subGroupId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                projectManagementEntities.Materials.Remove(materialsDetail);
                return projectManagementEntities.SaveChanges() > 0;
            }
        }

        #endregion
    }
}
