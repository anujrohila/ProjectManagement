//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-05 - 14:09:22
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProjectManagement.Domain
{
    [DataContract()]
    public partial class GroupBySupplierDTO
    {
        [DataMember()]
        public Int32 GrpIdSupplier { get; set; }

        [DataMember()]
        public String GroupSupplierName { get; set; }

        [DataMember()]
        public Nullable<Int32> childOf { get; set; }

        [DataMember()]
        public Nullable<Boolean> Display { get; set; }

        [DataMember()]
        public Nullable<Double> ClosingBalance { get; set; }

        public GroupBySupplierDTO()
        {
        }

        public GroupBySupplierDTO(Int32 grpIdSupplier, String groupSupplierName, Nullable<Int32> childOf, Nullable<Boolean> display, Nullable<Double> closingBalance)
        {
			this.GrpIdSupplier = grpIdSupplier;
			this.GroupSupplierName = groupSupplierName;
			this.childOf = childOf;
			this.Display = display;
			this.ClosingBalance = closingBalance;
        }
    }
}
