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
        public static List<tblImageMasterDTO> GetAllDocumentsDetails(int documentGroupId)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                return (from imageDocument in projectManagementSQLDatabaseEntities.tblImageMasters
                        join documentGroup in projectManagementSQLDatabaseEntities.tblDocumentGroups
                               on imageDocument.DocumentGroupId equals documentGroup.DocumentGroupId
                        where imageDocument.DocumentGroupId == documentGroupId
                        select new tblImageMasterDTO
                        {
                            DocumentGroupId = imageDocument.DocumentGroupId,
                            Comment = imageDocument.Comment,
                            CreateBy = imageDocument.CreateBy,
                            CreationDateTime = imageDocument.CreationDateTime,
                            ImageID = imageDocument.ImageID,
                            ImagesPath = imageDocument.ImagesPath,
                            UpdateBy = imageDocument.UpdateBy,
                            UpdationDateTime = imageDocument.UpdationDateTime,
                            DocumentGroupName = documentGroup.GroupName
                        }).ToList();
            }
        }


        /// <summary>
        /// Get Document Entry
        /// </summary>
        /// <returns></returns>
        public static tblImageMasterDTO GetDocumentsDetails(int imageId)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                return (from imageDocument in projectManagementSQLDatabaseEntities.tblImageMasters
                        join documentGroup in projectManagementSQLDatabaseEntities.tblDocumentGroups
                               on imageDocument.DocumentGroupId equals documentGroup.DocumentGroupId
                        where imageDocument.ImageID == imageId
                        select new tblImageMasterDTO
                        {
                            DocumentGroupId = imageDocument.DocumentGroupId,
                            Comment = imageDocument.Comment,
                            CreateBy = imageDocument.CreateBy,
                            CreationDateTime = imageDocument.CreationDateTime,
                            ImageID = imageDocument.ImageID,
                            ImagesPath = imageDocument.ImagesPath,
                            UpdateBy = imageDocument.UpdateBy,
                            UpdationDateTime = imageDocument.UpdationDateTime,
                            DocumentGroupName = documentGroup.GroupName
                        }).FirstOrDefault();
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
                if (projectManagementSQLDatabaseEntities.SaveChanges() > 0)
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
                if (tbldocuemnt != null)
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

        /// <summary>
        /// Get All Document Group Entry
        /// </summary>
        /// <returns></returns>
        public static List<tblDocumentGroupDTO> GetAllDocumentsGroupList()
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                return projectManagementSQLDatabaseEntities.tblDocumentGroups.ToList().ToDTOs();
            }
        }

        /// <summary>
        /// Save Document Group
        /// </summary>
        /// <returns></returns>
        public static int SaveDocumentGroup(tblDocumentGroupDTO tblDocumentGroupDTO)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                tblDocumentGroup tbldocuemntGroup = tblDocumentGroupDTO.ToEntity();
                projectManagementSQLDatabaseEntities.tblDocumentGroups.Add(tbldocuemntGroup);
                projectManagementSQLDatabaseEntities.SaveChanges();
                return tbldocuemntGroup.DocumentGroupId;
            }
        }


        /// <summary>
        /// Is Duplicate Document Group
        /// </summary>
        /// <returns></returns>
        public static bool IsDuplicateDocumentGroup(string groupName)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                var projectCount = projectManagementSQLDatabaseEntities.tblDocumentGroups.Where(documentGroup => string.Compare(documentGroup.GroupName, groupName, StringComparison.CurrentCultureIgnoreCase) == 0).Count();

                return projectCount == 0 ? false : true;
            }
        }

        #endregion

    }
}
