//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-17 - 14:19:53
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
namespace ProjectManagement.DLL.ORM
{
    /// <summary>
    /// Assembler for <see cref="tblImageMaster"/> and <see cref="tblImageMasterDTO"/>.
    /// </summary>
    public static partial class tblImageMasterAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblImageMasterDTO"/> converted from <see cref="tblImageMaster"/>.</param>
        static partial void OnDTO(this tblImageMaster entity, tblImageMasterDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblImageMaster"/> converted from <see cref="tblImageMasterDTO"/>.</param>
        static partial void OnEntity(this tblImageMasterDTO dto, tblImageMaster entity);

        /// <summary>
        /// Converts this instance of <see cref="tblImageMasterDTO"/> to an instance of <see cref="tblImageMaster"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblImageMasterDTO"/> to convert.</param>
        public static tblImageMaster ToEntity(this tblImageMasterDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblImageMaster();

            entity.ImageID = dto.ImageID;
            entity.ImagesPath = dto.ImagesPath;
            entity.Comment = dto.Comment;
            entity.CreateBy = dto.CreateBy;
            entity.CreationDateTime = dto.CreationDateTime;
            entity.UpdateBy = dto.UpdateBy;
            entity.UpdationDateTime = dto.UpdationDateTime;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblImageMaster"/> to an instance of <see cref="tblImageMasterDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblImageMaster"/> to convert.</param>
        public static tblImageMasterDTO ToDTO(this tblImageMaster entity)
        {
            if (entity == null) return null;

            var dto = new tblImageMasterDTO();

            dto.ImageID = entity.ImageID;
            dto.ImagesPath = entity.ImagesPath;
            dto.Comment = entity.Comment;
            dto.CreateBy = entity.CreateBy;
            dto.CreationDateTime = entity.CreationDateTime;
            dto.UpdateBy = entity.UpdateBy;
            dto.UpdationDateTime = entity.UpdationDateTime;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblImageMasterDTO"/> to an instance of <see cref="tblImageMaster"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblImageMaster> ToEntities(this IEnumerable<tblImageMasterDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblImageMaster"/> to an instance of <see cref="tblImageMasterDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblImageMasterDTO> ToDTOs(this IEnumerable<tblImageMaster> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
