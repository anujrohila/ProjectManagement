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
    
    public partial class tblImageMaster
    {
        public long ImageID { get; set; }
        public string ImagesPath { get; set; }
        public string Comment { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdationDateTime { get; set; }
        public Nullable<int> DocumentGroupId { get; set; }
    }
}
