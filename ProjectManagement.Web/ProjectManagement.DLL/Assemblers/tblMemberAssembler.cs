//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015/03/01 - 20:26:24
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
    /// Assembler for <see cref="tblMember"/> and <see cref="tblMemberDTO"/>.
    /// </summary>
    public static partial class tblMemberAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblMemberDTO"/> converted from <see cref="tblMember"/>.</param>
        static partial void OnDTO(this tblMember entity, tblMemberDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblMember"/> converted from <see cref="tblMemberDTO"/>.</param>
        static partial void OnEntity(this tblMemberDTO dto, tblMember entity);

        /// <summary>
        /// Converts this instance of <see cref="tblMemberDTO"/> to an instance of <see cref="tblMember"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblMemberDTO"/> to convert.</param>
        public static tblMember ToEntity(this tblMemberDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblMember();

            entity.MemberId = dto.MemberId;
            entity.MemberTypeId = dto.MemberTypeId;
            entity.FirstName = dto.FirstName;
            entity.LastName = dto.LastName;
            entity.EmailAddress = dto.EmailAddress;
            entity.MobileNo = dto.MobileNo;
            entity.Password = dto.Password;
            entity.IsActive = dto.IsActive;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblMember"/> to an instance of <see cref="tblMemberDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblMember"/> to convert.</param>
        public static tblMemberDTO ToDTO(this tblMember entity)
        {
            if (entity == null) return null;

            var dto = new tblMemberDTO();

            dto.MemberId = entity.MemberId;
            dto.MemberTypeId = entity.MemberTypeId;
            dto.FirstName = entity.FirstName;
            dto.LastName = entity.LastName;
            dto.EmailAddress = entity.EmailAddress;
            dto.MobileNo = entity.MobileNo;
            dto.Password = entity.Password;
            dto.IsActive = entity.IsActive;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMemberDTO"/> to an instance of <see cref="tblMember"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblMember> ToEntities(this IEnumerable<tblMemberDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMember"/> to an instance of <see cref="tblMemberDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblMemberDTO> ToDTOs(this IEnumerable<tblMember> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
