//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-05 - 14:09:25
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace ProjectManagement.Domain
{
    [DataContract()]
    public partial class SupplierDTO
    {
        [DataMember()]
        public String Sup_id { get; set; }

        [DataMember()]
        [Required(ErrorMessage = "Please enter supplier name.")]
        public String NameiS { get; set; }

        [DataMember()]
        public String AddiS { get; set; }

        [DataMember()]
        public String City { get; set; }

        [DataMember()]
        public Nullable<Double> OpBalance { get; set; }

        [DataMember()]
        public String Sup_Ph { get; set; }

        [DataMember()]
        public Nullable<Int32> creditday { get; set; }

        [DataMember()]
        public Nullable<Double> creditammount { get; set; }

        [DataMember()]
        public Nullable<Int32> GroupId { get; set; }

        [DataMember()]
        public String GuIdSup { get; set; }

        [DataMember()]
        public Nullable<Int16> share { get; set; }

        [DataMember()]
        public Nullable<DateTime> CutDate { get; set; }

        [DataMember()]
        public String Adding { get; set; }

        [DataMember()]
        public Nullable<Double> IntRates { get; set; }

        [DataMember()]
        public Nullable<Boolean> AutoUpdate { get; set; }

        [DataMember()]
        public String alias { get; set; }

        [DataMember()]
        public String userss { get; set; }

        [DataMember()]
        public String childof { get; set; }

        [DataMember()]
        public Double Balance { get; set; }

        [DataMember()]
        public Double CashBankBalance { get; set; }

        public string SupplierGroupName { get; set; }

        public List<GroupBySupplierDTO> SupplierGroupList { get; set; }
    }
}
