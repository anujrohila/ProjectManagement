//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-05 - 14:09:23
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
    public partial class Mat_AccountTwoDTO
    {
        [DataMember()]
        public String Ent_No { get; set; }

        [DataMember()]
        public Int32 VrNo { get; set; }

        [DataMember()]
        public String Mode_Pay_Rec { get; set; }

        [DataMember()]
        public String Rec_Pay { get; set; }

        [DataMember()]
        public Nullable<Double> Ammount { get; set; }

        [DataMember()]
        public Nullable<DateTime> Ddate { get; set; }

        [DataMember()]
        public String Disp { get; set; }

        [DataMember()]
        public String From_Account { get; set; }

        [DataMember()]
        public String To_Account { get; set; }

        [DataMember()]
        public String Hand_Group { get; set; }

        [DataMember()]
        public Nullable<Double> Kwat { get; set; }

        [DataMember()]
        public Nullable<Double> Discount { get; set; }

        [DataMember()]
        public Nullable<Double> Hand { get; set; }

        [DataMember()]
        public String SetViewOne { get; set; }

        [DataMember()]
        public Nullable<Boolean> Freezed { get; set; }

        [DataMember()]
        public Nullable<Boolean> IsEntryOnly { get; set; }

        [DataMember()]
        public String GuidAC { get; set; }

        [DataMember()]
        public Nullable<DateTime> CurDate { get; set; }

        [DataMember()]
        public Nullable<Boolean> Hide { get; set; }

        [DataMember()]
        public String ChqNo { get; set; }

        [DataMember()]
        public String ChqDrawn { get; set; }

        [DataMember()]
        public String Userss { get; set; }

        [DataMember()]
        public String fy { get; set; }

        public string FromSupplierName { get; set; }

        public string ToSupplierName { get; set; }

        public List<SupplierDTO> FromSupplierList { get; set; }

        public List<SupplierDTO> ToSupplierList { get; set; }
    }
}
