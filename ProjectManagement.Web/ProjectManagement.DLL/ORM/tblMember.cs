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
    
    public partial class tblMember
    {
        public tblMember()
        {
            this.tblMemberPermissions = new HashSet<tblMemberPermission>();
        }
    
        public int MemberId { get; set; }
        public int MemberTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    
        public virtual tblMemberType tblMemberType { get; set; }
        public virtual ICollection<tblMemberPermission> tblMemberPermissions { get; set; }
    }
}
