using ProjectManagement.DLL.ORM;
using ProjectManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.DLL.Repositories
{
    public class DocumentsRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public DocumentsRepository()
        {

        }

        #endregion

        #region [Methods]

           /// <summary>
        /// Get All Document Entry
        /// </summary>
        /// <returns></returns>
        public static List<tblImageMasterDTO> GetAllDocumentsDetails()
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                return projectManagementSQLDatabaseEntities.tblImageMasters.ToList().ToDTOs();
            }
        }

        /// <summary>
        /// Save Docuement Entry
        /// </summary>
        /// <returns></returns>
        public static bool SaveDocuement(tblImageMasterDTO tblImageMasterDTO)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                tblImageMaster tbldocuemnt = tblImageMasterDTO.ToEntity();
                projectManagementSQLDatabaseEntities.tblImageMasters.Add(tbldocuemnt);
                if(projectManagementSQLDatabaseEntities.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Delete Docuement Entry
        /// </summary>
        /// <returns></returns>
        public static string DeleteDocuement(int id)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                var tbldocuemnt = projectManagementSQLDatabaseEntities.tblImageMasters.Where(d => d.ImageID == id).FirstOrDefault();
                string returnname = tbldocuemnt.ImagesPath;
                if(tbldocuemnt != null)
                {
                    projectManagementSQLDatabaseEntities.tblImageMasters.Remove(tbldocuemnt);
                    if (projectManagementSQLDatabaseEntities.SaveChanges() > 0)
                    {
                        return returnname;
                    }
                }
            }
            return "";
        }

        #endregion

    }
}
