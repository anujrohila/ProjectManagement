//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagement.DLL.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPermissionMaster
    {
        public tblPermissionMaster()
        {
            this.tblMemberPermissions = new HashSet<tblMemberPermission>();
        }
    
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<tblMemberPermission> tblMemberPermissions { get; set; }
    }
}
