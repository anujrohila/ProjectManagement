using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{
    public class MaterialEntryRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public MaterialEntryRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get All Material Entry
        /// </summary>
        /// <returns></returns>
        public static List<QtyMaterialDTO> GetAllMaterialEntry()
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from qtyMaterials in projectManagementEntities.QtyMaterials
                        join materials in projectManagementEntities.Materials
                                on qtyMaterials.Mat_id equals materials.Mat_id
                        join suppliers in projectManagementEntities.Suppliers
                                on qtyMaterials.Sup_id equals suppliers.Sup_id
                        select new QtyMaterialDTO
                        {
                            Reg_id = qtyMaterials.Reg_id,
                            Mat_id = qtyMaterials.Mat_id,
                            Sup_id = qtyMaterials.Sup_id,
                            Ddate = qtyMaterials.Ddate,
                            Challan_No = qtyMaterials.Challan_No,
                            Disp = qtyMaterials.Disp,
                            Qty = qtyMaterials.Qty,
                            Rate = qtyMaterials.Rate,
                            Ammount = qtyMaterials.Ammount,
                            Unit = qtyMaterials.Unit,
                            Proj_Name = qtyMaterials.Proj_Name,
                            Bill_No = qtyMaterials.Bill_No,
                            Bill_Rate = qtyMaterials.Bill_Rate,
                            Bil_Ent = qtyMaterials.Bil_Ent,
                            Valid = qtyMaterials.Valid,
                            Bill_Date = qtyMaterials.Bill_Date,
                            Bill_Ent_No = qtyMaterials.Bill_Ent_No,
                            GuidQty = qtyMaterials.GuidQty,
                            userss = qtyMaterials.userss,
                            MaterialName = materials.Mat_Name,
                            SupplierName = suppliers.NameiS
                        }).ToList();
            }
        }

        /// <summary>
        /// Get Material Entry
        /// </summary>
        /// <returns></returns>
        public static QtyMaterialDTO GetMaterialEntry(string entryId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                return (from qtyMaterials in projectManagementEntities.QtyMaterials
                        join materials in projectManagementEntities.Materials
                                on qtyMaterials.Mat_id equals materials.Mat_id
                        join suppliers in projectManagementEntities.Suppliers
                                on qtyMaterials.Sup_id equals suppliers.Sup_id
                        select new QtyMaterialDTO
                        {
                            Reg_id = qtyMaterials.Reg_id,
                            Mat_id = qtyMaterials.Mat_id,
                            Sup_id = qtyMaterials.Sup_id,
                            Ddate = qtyMaterials.Ddate,
                            Challan_No = qtyMaterials.Challan_No,
                            Disp = qtyMaterials.Disp,
                            Qty = qtyMaterials.Qty,
                            Rate = qtyMaterials.Rate,
                            Ammount = qtyMaterials.Ammount,
                            Unit = qtyMaterials.Unit,
                            Proj_Name = qtyMaterials.Proj_Name,
                            Bill_No = qtyMaterials.Bill_No,
                            Bill_Rate = qtyMaterials.Bill_Rate,
                            Bil_Ent = qtyMaterials.Bil_Ent,
                            Valid = qtyMaterials.Valid,
                            Bill_Date = qtyMaterials.Bill_Date,
                            Bill_Ent_No = qtyMaterials.Bill_Ent_No,
                            GuidQty = qtyMaterials.GuidQty,
                            userss = qtyMaterials.userss,
                            MaterialName = materials.Mat_Name,
                            SupplierName = suppliers.NameiS
                        }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Insert Material Entry
        /// </summary>
        /// <returns></returns>
        public static string InsertMaterialEntry(QtyMaterialDTO qtyMaterialDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var qtyMaterial = new QtyMaterial();
                qtyMaterial = qtyMaterialDTO.ToEntity();
                projectManagementEntities.QtyMaterials.Add(qtyMaterial);
                projectManagementEntities.SaveChanges();
                return qtyMaterial.Reg_id;
            }
        }

        /// <summary>
        /// Update Material Entry
        /// </summary>
        /// <returns></returns>
        public static string UpdateMaterialEntry(QtyMaterialDTO qtyMaterialDTO)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var qtyMaterial = new QtyMaterial();
                qtyMaterial = projectManagementEntities.QtyMaterials.Where(qtyM => string.Compare(qtyM.Reg_id, qtyMaterialDTO.Reg_id, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                qtyMaterial.Reg_id = qtyMaterialDTO.Reg_id;
                qtyMaterial.Mat_id = qtyMaterialDTO.Mat_id;
                qtyMaterial.Sup_id = qtyMaterialDTO.Sup_id;
                qtyMaterial.Ddate = qtyMaterialDTO.Ddate;
                qtyMaterial.Challan_No = qtyMaterialDTO.Challan_No;
                qtyMaterial.Disp = qtyMaterialDTO.Disp;
                qtyMaterial.Qty = qtyMaterialDTO.Qty;
                qtyMaterial.Rate = qtyMaterialDTO.Rate;
                qtyMaterial.Ammount = qtyMaterialDTO.Ammount;
                qtyMaterial.Unit = qtyMaterialDTO.Unit;
                qtyMaterial.Proj_Name = qtyMaterialDTO.Proj_Name;
                qtyMaterial.Bill_No = qtyMaterialDTO.Bill_No;
                qtyMaterial.Bill_Rate = qtyMaterialDTO.Bill_Rate;
                qtyMaterial.Bil_Ent = qtyMaterialDTO.Bil_Ent;
                qtyMaterial.Valid = qtyMaterialDTO.Valid;
                qtyMaterial.Bill_Date = qtyMaterialDTO.Bill_Date;
                qtyMaterial.Bill_Ent_No = qtyMaterialDTO.Bill_Ent_No;
                qtyMaterial.GuidQty = qtyMaterialDTO.GuidQty;
                qtyMaterial.userss = qtyMaterialDTO.userss;
                projectManagementEntities.SaveChanges();
                return qtyMaterial.Reg_id;
            }
        }

        /// <summary>
        /// Delete Material Entry
        /// </summary>
        /// <returns></returns>
        public static bool DeleteMaterialEntry(string entryId)
        {
            using (var projectManagementEntities = new ProjectManagementEntities())
            {
                var qtyMaterial = projectManagementEntities.QtyMaterials.Where(qtyM => string.Compare(qtyM.Reg_id, entryId, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                projectManagementEntities.QtyMaterials.Remove(qtyMaterial);
                return projectManagementEntities.SaveChanges() > 0;
            }
        }

        #endregion
    }
}
