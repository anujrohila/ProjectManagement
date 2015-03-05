//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2015-03-05 - 14:09:27
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
    /// Assembler for <see cref="del_Mat_AccountTwo"/> and <see cref="del_Mat_AccountTwoDTO"/>.
    /// </summary>
    public static partial class del_Mat_AccountTwoAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="del_Mat_AccountTwoDTO"/> converted from <see cref="del_Mat_AccountTwo"/>.</param>
        static partial void OnDTO(this del_Mat_AccountTwo entity, del_Mat_AccountTwoDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="del_Mat_AccountTwo"/> converted from <see cref="del_Mat_AccountTwoDTO"/>.</param>
        static partial void OnEntity(this del_Mat_AccountTwoDTO dto, del_Mat_AccountTwo entity);

        /// <summary>
        /// Converts this instance of <see cref="del_Mat_AccountTwoDTO"/> to an instance of <see cref="del_Mat_AccountTwo"/>.
        /// </summary>
        /// <param name="dto"><see cref="del_Mat_AccountTwoDTO"/> to convert.</param>
        public static del_Mat_AccountTwo ToEntity(this del_Mat_AccountTwoDTO dto)
        {
            if (dto == null) return null;

            var entity = new del_Mat_AccountTwo();

            entity.Ent_No = dto.Ent_No;
            entity.VrNo = dto.VrNo;
            entity.Mode_Pay_Rec = dto.Mode_Pay_Rec;
            entity.Rec_Pay = dto.Rec_Pay;
            entity.Ammount = dto.Ammount;
            entity.Ddate = dto.Ddate;
            entity.Disp = dto.Disp;
            entity.From_Account = dto.From_Account;
            entity.To_Account = dto.To_Account;
            entity.Hand_Group = dto.Hand_Group;
            entity.Kwat = dto.Kwat;
            entity.Discount = dto.Discount;
            entity.Hand = dto.Hand;
            entity.SetViewOne = dto.SetViewOne;
            entity.Freezed = dto.Freezed;
            entity.IsEntryOnly = dto.IsEntryOnly;
            entity.GuidAC = dto.GuidAC;
            entity.CurDate = dto.CurDate;
            entity.Hide = dto.Hide;
            entity.ChqNo = dto.ChqNo;
            entity.ChqDrawn = dto.ChqDrawn;
            entity.Userss = dto.Userss;
            entity.fy = dto.fy;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="del_Mat_AccountTwo"/> to an instance of <see cref="del_Mat_AccountTwoDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="del_Mat_AccountTwo"/> to convert.</param>
        public static del_Mat_AccountTwoDTO ToDTO(this del_Mat_AccountTwo entity)
        {
            if (entity == null) return null;

            var dto = new del_Mat_AccountTwoDTO();

            dto.Ent_No = entity.Ent_No;
            dto.VrNo = entity.VrNo;
            dto.Mode_Pay_Rec = entity.Mode_Pay_Rec;
            dto.Rec_Pay = entity.Rec_Pay;
            dto.Ammount = entity.Ammount;
            dto.Ddate = entity.Ddate;
            dto.Disp = entity.Disp;
            dto.From_Account = entity.From_Account;
            dto.To_Account = entity.To_Account;
            dto.Hand_Group = entity.Hand_Group;
            dto.Kwat = entity.Kwat;
            dto.Discount = entity.Discount;
            dto.Hand = entity.Hand;
            dto.SetViewOne = entity.SetViewOne;
            dto.Freezed = entity.Freezed;
            dto.IsEntryOnly = entity.IsEntryOnly;
            dto.GuidAC = entity.GuidAC;
            dto.CurDate = entity.CurDate;
            dto.Hide = entity.Hide;
            dto.ChqNo = entity.ChqNo;
            dto.ChqDrawn = entity.ChqDrawn;
            dto.Userss = entity.Userss;
            dto.fy = entity.fy;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="del_Mat_AccountTwoDTO"/> to an instance of <see cref="del_Mat_AccountTwo"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<del_Mat_AccountTwo> ToEntities(this IEnumerable<del_Mat_AccountTwoDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="del_Mat_AccountTwo"/> to an instance of <see cref="del_Mat_AccountTwoDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<del_Mat_AccountTwoDTO> ToDTOs(this IEnumerable<del_Mat_AccountTwo> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}