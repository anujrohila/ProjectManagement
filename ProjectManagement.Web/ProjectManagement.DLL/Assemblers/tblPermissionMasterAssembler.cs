//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/03/01 - 17:01:52
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using ProjectManagement.DLL.ORM;
using ProjectManagement.Domain;

namespace ProjectManagement.DLL
{

    /// <summary>
    /// Assembler for <see cref="tblPermissionMaster"/> and <see cref="tblPermissionMasterDTO"/>.
    /// </summary>
    public static partial class tblPermissionMasterAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblPermissionMasterDTO"/> converted from <see cref="tblPermissionMaster"/>.</param>
        static partial void OnDTO(this tblPermissionMaster entity, tblPermissionMasterDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblPermissionMaster"/> converted from <see cref="tblPermissionMasterDTO"/>.</param>
        static partial void OnEntity(this tblPermissionMasterDTO dto, tblPermissionMaster entity);

        /// <summary>
        /// Converts this instance of <see cref="tblPermissionMasterDTO"/> to an instance of <see cref="tblPermissionMaster"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblPermissionMasterDTO"/> to convert.</param>
        public static tblPermissionMaster ToEntity(this tblPermissionMasterDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblPermissionMaster();

            entity.PermissionId = dto.PermissionId;
            entity.PermissionName = dto.PermissionName;
            entity.Description = dto.Description;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblPermissionMaster"/> to an instance of <see cref="tblPermissionMasterDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblPermissionMaster"/> to convert.</param>
        public static tblPermissionMasterDTO ToDTO(this tblPermissionMaster entity)
        {
            if (entity == null) return null;

            var dto = new tblPermissionMasterDTO();

            dto.PermissionId = entity.PermissionId;
            dto.PermissionName = entity.PermissionName;
            dto.Description = entity.Description;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblPermissionMasterDTO"/> to an instance of <see cref="tblPermissionMaster"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblPermissionMaster> ToEntities(this IEnumerable<tblPermissionMasterDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblPermissionMaster"/> to an instance of <see cref="tblPermissionMasterDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblPermissionMasterDTO> ToDTOs(this IEnumerable<tblPermissionMaster> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}