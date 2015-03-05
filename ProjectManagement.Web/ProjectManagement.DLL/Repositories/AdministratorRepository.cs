
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.DLL.ORM;
using ProjectManagement.Domain;
using ProjectManagement.DLL;


namespace ProjectManagement.Web.DLL
{
    public class AdministratorRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public AdministratorRepository()
        {

        }

        #endregion

        #region [Methods]

        public static tblMemberDTO GetMembershipDetails(string emailId, string Password)
        {
            using (var ProjectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                return (ProjectManagementSQLDatabaseEntities.tblMembers.Where(user => user.EmailAddress == emailId && user.Password == Password).FirstOrDefault()).ToDTO();
            }
        }

        #endregion

      
    }
}
