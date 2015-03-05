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

namespace ProjectManagement.DLL.ORM
{

    /// <summary>
    /// Assembler for <see cref="tblMaterial"/> and <see cref="tblMaterialDTO"/>.
    /// </summary>
    public static partial class tblMaterialAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblMaterialDTO"/> converted from <see cref="tblMaterial"/>.</param>
        static partial void OnDTO(this tblMaterial entity, tblMaterialDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblMaterial"/> converted from <see cref="tblMaterialDTO"/>.</param>
        static partial void OnEntity(this tblMaterialDTO dto, tblMaterial entity);

        /// <summary>
        /// Converts this instance of <see cref="tblMaterialDTO"/> to an instance of <see cref="tblMaterial"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblMaterialDTO"/> to convert.</param>
        public static tblMaterial ToEntity(this tblMaterialDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblMaterial();

            entity.MaterialId = dto.MaterialId;
            entity.MaterialGroupId = dto.MaterialGroupId;
            entity.Name = dto.Name;
            entity.BasicRate = dto.BasicRate;
            entity.OpeningStock = dto.OpeningStock;
            entity.MemberId = dto.MemberId;
            entity.CompanyId = dto.CompanyId;
            entity.CreationDateTime = dto.CreationDateTime;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblMaterial"/> to an instance of <see cref="tblMaterialDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblMaterial"/> to convert.</param>
        public static tblMaterialDTO ToDTO(this tblMaterial entity)
        {
            if (entity == null) return null;

            var dto = new tblMaterialDTO();

            dto.MaterialId = entity.MaterialId;
            dto.MaterialGroupId = entity.MaterialGroupId;
            dto.Name = entity.Name;
            dto.BasicRate = entity.BasicRate;
            dto.OpeningStock = entity.OpeningStock;
            dto.MemberId = entity.MemberId;
            dto.CompanyId = entity.CompanyId;
            dto.CreationDateTime = entity.CreationDateTime;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMaterialDTO"/> to an instance of <see cref="tblMaterial"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblMaterial> ToEntities(this IEnumerable<tblMaterialDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMaterial"/> to an instance of <see cref="tblMaterialDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblMaterialDTO> ToDTOs(this IEnumerable<tblMaterial> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
