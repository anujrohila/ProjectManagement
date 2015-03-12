//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-12 - 20:08:20
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
    public partial class tblProjectDTO
    {
        [DataMember()]
        public Int32 ProjectId { get; set; }

        [DataMember()]
        public String Title { get; set; }

        [DataMember()]
        public String Address { get; set; }

        [DataMember()]
        public String Description { get; set; }

        [DataMember()]
        public DateTime StratDateTime { get; set; }

        [DataMember()]
        public String Catalog { get; set; }

        [DataMember()]
        public String UserName { get; set; }

        [DataMember()]
        public String Password { get; set; }

        [DataMember()]
        public Boolean IsActive { get; set; }

        public tblProjectDTO()
        {
        }

        public tblProjectDTO(Int32 projectId, String title, String address, String description, DateTime stratDateTime, String catalog, String userName, String password, Boolean isActive)
        {
			this.ProjectId = projectId;
			this.Title = title;
			this.Address = address;
			this.Description = description;
			this.StratDateTime = stratDateTime;
			this.Catalog = catalog;
			this.UserName = userName;
			this.Password = password;
			this.IsActive = isActive;
        }
    }
}
