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
    
    public partial class tblProject
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string SiteName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public System.DateTime StratDateTime { get; set; }
        public string Catalog { get; set; }
        public bool IsActive { get; set; }
    }
}
