
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.Web.DLL;

namespace ProjectManagement.BLL
{
    public static class AdministratorBusinessLogic
    {
        #region [Declaration]

        #endregion

        #region [Methods]


        /// <summary>
        /// Get Member Login 
        /// </summary>
        /// <returns></returns>
        public static tblMemberDTO GetMembershipDetails(string emailId,string Password)
        {
            var AdministratorRepository = new AdministratorRepository();
            return AdministratorRepository.GetMembershipDetails(emailId, Password);
        }
        

        #endregion
    }
}
