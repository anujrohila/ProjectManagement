//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/03/01 - 17:01:51
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{

    /// <summary>
    /// Assembler for <see cref="tblMemberPermission"/> and <see cref="tblMemberPermissionDTO"/>.
    /// </summary>
    public static partial class tblMemberPermissionAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblMemberPermissionDTO"/> converted from <see cref="tblMemberPermission"/>.</param>
        static partial void OnDTO(this tblMemberPermission entity, tblMemberPermissionDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblMemberPermission"/> converted from <see cref="tblMemberPermissionDTO"/>.</param>
        static partial void OnEntity(this tblMemberPermissionDTO dto, tblMemberPermission entity);

        /// <summary>
        /// Converts this instance of <see cref="tblMemberPermissionDTO"/> to an instance of <see cref="tblMemberPermission"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblMemberPermissionDTO"/> to convert.</param>
        public static tblMemberPermission ToEntity(this tblMemberPermissionDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblMemberPermission();

            entity.MemberPermissionId = dto.MemberPermissionId;
            entity.PermisisonId = dto.PermisisonId;
            entity.MemberId = dto.MemberId;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblMemberPermission"/> to an instance of <see cref="tblMemberPermissionDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblMemberPermission"/> to convert.</param>
        public static tblMemberPermissionDTO ToDTO(this tblMemberPermission entity)
        {
            if (entity == null) return null;

            var dto = new tblMemberPermissionDTO();

            dto.MemberPermissionId = entity.MemberPermissionId;
            dto.PermisisonId = entity.PermisisonId;
            dto.MemberId = entity.MemberId;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMemberPermissionDTO"/> to an instance of <see cref="tblMemberPermission"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblMemberPermission> ToEntities(this IEnumerable<tblMemberPermissionDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMemberPermission"/> to an instance of <see cref="tblMemberPermissionDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblMemberPermissionDTO> ToDTOs(this IEnumerable<tblMemberPermission> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}