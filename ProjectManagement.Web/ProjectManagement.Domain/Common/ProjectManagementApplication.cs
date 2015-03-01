using System;
using System.Resources;

namespace ProjectManagement.Domain
{
    /// <summary>
    /// This is a main class (static) it will store application specific settings to access from whole application
    /// This class is used in web.ui only
    /// </summary>
    public static class ProjectManagementApplicationWebUI
    {
        static ProjectManagementApplicationWebUI()
        {

        }
        public static string WebUrlPrefix
        {
            get
            {
                return Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WebUrlPrefix"]);
            }
        }

        public static ResourceManager ResourceScript
        {
            get
            {
                return ProjectManagement.Domain.Resources.ProjectManagementResource.ResourceManager;
            }
        }
    }
}
