//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-12 - 18:32:08
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
    public partial class tblLoginDTO
    {

        [DataMember()]
        [Required(ErrorMessage = "Please enter email address.")]
        public String EmailAddress { get; set; }

        [DataMember()]
        [Required(ErrorMessage = "Please enter password.")]
        public String Password { get; set; }

        public string ErrorMessage { get; set; }

        public int StatuID { get; set; }

        public bool RememberMe { get; set; }
    }
}
