//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-05 - 14:09:28
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
    /// Assembler for <see cref="Material"/> and <see cref="MaterialDTO"/>.
    /// </summary>
    public static partial class MaterialAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="MaterialDTO"/> converted from <see cref="Material"/>.</param>
        static partial void OnDTO(this Material entity, MaterialDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Material"/> converted from <see cref="MaterialDTO"/>.</param>
        static partial void OnEntity(this MaterialDTO dto, Material entity);

        /// <summary>
        /// Converts this instance of <see cref="MaterialDTO"/> to an instance of <see cref="Material"/>.
        /// </summary>
        /// <param name="dto"><see cref="MaterialDTO"/> to convert.</param>
        public static Material ToEntity(this MaterialDTO dto)
        {
            if (dto == null) return null;

            var entity = new Material();

            entity.Mat_id = dto.Mat_id;
            entity.Mat_Name = dto.Mat_Name;
            entity.Mat_Unit = dto.Mat_Unit;
            entity.Basic_Rate = dto.Basic_Rate;
            entity.GroupId = dto.GroupId;
            entity.GuIdMaterial = dto.GuIdMaterial;
            entity.userss = dto.userss;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="Material"/> to an instance of <see cref="MaterialDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Material"/> to convert.</param>
        public static MaterialDTO ToDTO(this Material entity)
        {
            if (entity == null) return null;

            var dto = new MaterialDTO();

            dto.Mat_id = entity.Mat_id;
            dto.Mat_Name = entity.Mat_Name;
            dto.Mat_Unit = entity.Mat_Unit;
            dto.Basic_Rate = entity.Basic_Rate;
            dto.GroupId = entity.GroupId;
            dto.GuIdMaterial = entity.GuIdMaterial;
            dto.userss = entity.userss;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="MaterialDTO"/> to an instance of <see cref="Material"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<Material> ToEntities(this IEnumerable<MaterialDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="Material"/> to an instance of <see cref="MaterialDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<MaterialDTO> ToDTOs(this IEnumerable<Material> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
