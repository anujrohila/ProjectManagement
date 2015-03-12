//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-12 - 20:08:21
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

namespace ProjectManagement.DLL.ORM
{

    /// <summary>
    /// Assembler for <see cref="tblEntityMaster"/> and <see cref="tblEntityMasterDTO"/>.
    /// </summary>
    public static partial class tblEntityMasterAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblEntityMasterDTO"/> converted from <see cref="tblEntityMaster"/>.</param>
        static partial void OnDTO(this tblEntityMaster entity, tblEntityMasterDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblEntityMaster"/> converted from <see cref="tblEntityMasterDTO"/>.</param>
        static partial void OnEntity(this tblEntityMasterDTO dto, tblEntityMaster entity);

        /// <summary>
        /// Converts this instance of <see cref="tblEntityMasterDTO"/> to an instance of <see cref="tblEntityMaster"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblEntityMasterDTO"/> to convert.</param>
        public static tblEntityMaster ToEntity(this tblEntityMasterDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblEntityMaster();

            entity.EntityId = dto.EntityId;
            entity.EntityName = dto.EntityName;
            entity.Description = dto.Description;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblEntityMaster"/> to an instance of <see cref="tblEntityMasterDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblEntityMaster"/> to convert.</param>
        public static tblEntityMasterDTO ToDTO(this tblEntityMaster entity)
        {
            if (entity == null) return null;

            var dto = new tblEntityMasterDTO();

            dto.EntityId = entity.EntityId;
            dto.EntityName = entity.EntityName;
            dto.Description = entity.Description;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblEntityMasterDTO"/> to an instance of <see cref="tblEntityMaster"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblEntityMaster> ToEntities(this IEnumerable<tblEntityMasterDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblEntityMaster"/> to an instance of <see cref="tblEntityMasterDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblEntityMasterDTO> ToDTOs(this IEnumerable<tblEntityMaster> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
