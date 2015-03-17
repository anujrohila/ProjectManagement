using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{
    public class ProjectRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public ProjectRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get All Project
        /// </summary>
        /// <returns></returns>
        public static List<tblProjectDTO> GetAllProject()
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                return (from projectObject in projectManagementSQLDatabaseEntities.tblProjects
                        select new tblProjectDTO
                        {
                            ProjectId = projectObject.ProjectId,
                            Title = projectObject.Title,
                            Address = projectObject.Address,
                            Catalog = projectObject.Catalog,
                            Description = projectObject.Description,
                            IsActive = projectObject.IsActive,
                            Password = projectObject.Password,
                            UserName = projectObject.UserName,
                            StratDateTime = projectObject.StratDateTime
                        }).ToList();
            }
        }

        /// <summary>
        /// Get Project
        /// </summary>
        /// <returns></returns>
        public static tblProjectDTO GetProject(string projectId)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                return (from projectObject in projectManagementSQLDatabaseEntities.tblProjects
                        select new tblProjectDTO
                        {
                            ProjectId = projectObject.ProjectId,
                            Title = projectObject.Title,
                            Address = projectObject.Address,
                            Catalog = projectObject.Catalog,
                            Description = projectObject.Description,
                            IsActive = projectObject.IsActive,
                            Password = projectObject.Password,
                            UserName = projectObject.UserName,
                            StratDateTime = projectObject.StratDateTime
                        }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Save Project
        /// </summary>
        /// <returns></returns>
        public static int SaveProject(tblProjectDTO tblProjectDTO)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                var tblProject = new tblProject();
                if (tblProject.ProjectId == 0)
                {
                    tblProject = tblProjectDTO.ToEntity();
                    projectManagementSQLDatabaseEntities.tblProjects.Add(tblProject);
                }
                else
                {
                    tblProject = projectManagementSQLDatabaseEntities.tblProjects.Where(project => project.ProjectId == tblProjectDTO.ProjectId).FirstOrDefault();
                    tblProject.ProjectId = tblProjectDTO.ProjectId;
                    tblProject.Title = tblProjectDTO.Title;
                    tblProject.Address = tblProjectDTO.Address;
                    tblProject.Catalog = tblProjectDTO.Catalog;
                    tblProject.Description = tblProjectDTO.Description;
                    tblProject.IsActive = tblProjectDTO.IsActive;
                    tblProject.Password = tblProjectDTO.Password;
                    tblProject.UserName = tblProjectDTO.UserName;
                    tblProject.StratDateTime = tblProjectDTO.StratDateTime;
                }
                projectManagementSQLDatabaseEntities.SaveChanges();
                return tblProject.ProjectId;
            }
        }

        /// <summary>
        /// Is Duplicate Project
        /// </summary>
        /// <returns></returns>
        public static bool IsDuplicateProject(string title, int projectId)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                var projectCount = projectManagementSQLDatabaseEntities.tblProjects.Where(project => string.Compare(project.Title, title, StringComparison.CurrentCultureIgnoreCase) == 0
                                                                            && project.ProjectId != projectId).Count();

                return projectCount == 0 ? false : true;
            }
        }

        /// <summary>
        /// Delete Project
        /// </summary>
        /// <returns></returns>
        public static bool DeleteProject(int projectId)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                var supplier = projectManagementSQLDatabaseEntities.tblProjects.Where(project => project.ProjectId == projectId).FirstOrDefault();
                projectManagementSQLDatabaseEntities.tblProjects.Remove(supplier);
                return projectManagementSQLDatabaseEntities.SaveChanges() > 0;
            }
        }

        #endregion
    }
}
