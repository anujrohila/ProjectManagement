//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-05 - 14:09:19
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
    public partial class AccountGroupDTO
    {
        [DataMember()]
        public Int32 AcId { get; set; }

        [DataMember()]
        public String AcGroup { get; set; }

        [DataMember()]
        public Nullable<Double> CloBalance { get; set; }

        public AccountGroupDTO()
        {
        }

        public AccountGroupDTO(Int32 acId, String acGroup, Nullable<Double> cloBalance)
        {
			this.AcId = acId;
			this.AcGroup = acGroup;
			this.CloBalance = cloBalance;
        }
    }
}