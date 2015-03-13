using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain;
using ProjectManagement.DLL.ORM;

namespace ProjectManagement.DLL
{
    public class MemberRepository
    {
        #region [Declaration]

        #endregion

        #region [Constructor]

        public MemberRepository()
        {

        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get All Member
        /// </summary>
        /// <returns></returns>
        public static List<tblMemberDTO> GetAllMember()
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                return (from member in projectManagementSQLDatabaseEntities.tblMembers
                        select new tblMemberDTO
                        {
                            MemberId = member.MemberId,
                            MemberTypeId = member.MemberTypeId,
                            FirstName = member.FirstName,
                            LastName = member.LastName,
                            Address = member.Address,
                            EmailAddress = member.EmailAddress,
                            MobileNo = member.MobileNo,
                            Password = member.Password,
                            IsActive = member.IsActive,
                            MemberTypeString = member.tblMemberType.TypeName
                        }).ToList();
            }
        }

        /// <summary>
        /// Get Member
        /// </summary>
        /// <returns></returns>
        public static tblMemberDTO GetMember(int memberId)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                var result = (from member in projectManagementSQLDatabaseEntities.tblMembers
                              where member.MemberId == memberId
                              select new tblMemberDTO
                              {
                                  MemberId = member.MemberId,
                                  MemberTypeId = member.MemberTypeId,
                                  FirstName = member.FirstName,
                                  LastName = member.LastName,
                                  Address = member.Address,
                                  EmailAddress = member.EmailAddress,
                                  MobileNo = member.MobileNo,
                                  Password = member.Password,
                                  IsActive = member.IsActive,
                                  MemberTypeString = member.tblMemberType.TypeName,
                              }).FirstOrDefault();

                result.MemberPermissionList = (from permission in projectManagementSQLDatabaseEntities.tblMemberPermissions
                                               where permission.MemberId == memberId
                                               select new tblMemberPermissionDTO
                                               {
                                                   MemberPermissionId = permission.MemberPermissionId,
                                                   MemberId = permission.MemberId,
                                                   ProjectId = permission.ProjectId,
                                                   EnitytId = permission.EnitytId,
                                                   CanListAll = permission.CanListAll,
                                                   CanInsert = permission.CanInsert,
                                                   CanEdit = permission.CanEdit,
                                                   CanDelete = permission.CanDelete
                                               }).ToList();

                return result;
            }
        }

        /// <summary>
        /// Get Member
        /// </summary>
        /// <returns></returns>
        public static tblMemberDTO GetMember(string email, string password)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                var result = (from member in projectManagementSQLDatabaseEntities.tblMembers
                              where string.Compare(email, member.EmailAddress, StringComparison.CurrentCultureIgnoreCase) == 0
                                    && string.Compare(password, member.Password, StringComparison.CurrentCultureIgnoreCase) == 0
                              select new tblMemberDTO
                              {
                                  MemberId = member.MemberId,
                                  MemberTypeId = member.MemberTypeId,
                                  FirstName = member.FirstName,
                                  LastName = member.LastName,
                                  Address = member.Address,
                                  EmailAddress = member.EmailAddress,
                                  MobileNo = member.MobileNo,
                                  Password = member.Password,
                                  IsActive = member.IsActive,
                                  MemberTypeString = member.tblMemberType.TypeName,
                              }).FirstOrDefault();

                result.MemberPermissionList = (from permission in projectManagementSQLDatabaseEntities.tblMemberPermissions
                                               where permission.MemberId == result.MemberId
                                               select new tblMemberPermissionDTO
                                               {
                                                   MemberPermissionId = permission.MemberPermissionId,
                                                   MemberId = permission.MemberId,
                                                   ProjectId = permission.ProjectId,
                                                   EnitytId = permission.EnitytId,
                                                   CanListAll = permission.CanListAll,
                                                   CanInsert = permission.CanInsert,
                                                   CanEdit = permission.CanEdit,
                                                   CanDelete = permission.CanDelete
                                               }).ToList();

                return result;
            }
        }

        /// <summary>
        /// Insert Member
        /// </summary>
        /// <returns></returns>
        public static int SaveMember(tblMemberDTO tblMemberDTO)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                var tblMember = new tblMember();
                if (tblMember.MemberId == 0)
                {
                    tblMember = tblMemberDTO.ToEntity();
                    projectManagementSQLDatabaseEntities.tblMembers.Add(tblMember);
                    projectManagementSQLDatabaseEntities.SaveChanges();

                }
                else
                {
                    tblMember = projectManagementSQLDatabaseEntities.tblMembers.Where(member => member.MemberId == tblMemberDTO.MemberId).FirstOrDefault();
                    tblMember.MemberId = tblMemberDTO.MemberId;
                    tblMember.MemberTypeId = tblMemberDTO.MemberTypeId;
                    tblMember.FirstName = tblMemberDTO.FirstName;
                    tblMember.LastName = tblMemberDTO.LastName;
                    tblMember.Address = tblMemberDTO.Address;
                    tblMember.EmailAddress = tblMemberDTO.EmailAddress;
                    tblMember.MobileNo = tblMemberDTO.MobileNo;
                    tblMember.Password = tblMemberDTO.Password;
                    tblMember.IsActive = tblMemberDTO.IsActive;
                }

                var oldPermissionList = projectManagementSQLDatabaseEntities.tblMemberPermissions.Where(p => p.MemberId == tblMember.MemberId).ToList();
                if (oldPermissionList != null)
                {
                    foreach (var oldPer in oldPermissionList)
                    {
                        projectManagementSQLDatabaseEntities.tblMemberPermissions.Remove(oldPer);
                    }
                }

                foreach (var permission in tblMemberDTO.MemberPermissionList)
                {
                    permission.MemberId = tblMember.MemberId;
                    projectManagementSQLDatabaseEntities.tblMemberPermissions.Add(permission.ToEntity());
                }

                projectManagementSQLDatabaseEntities.SaveChanges();
                return tblMember.MemberId;
            }
        }

        /// <summary>
        /// Is Duplicate Member
        /// </summary>
        /// <returns></returns>
        public static bool IsDuplicateMember(string emailAddress, int memberId)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                var memberCount = projectManagementSQLDatabaseEntities.tblMembers.Where(member => string.Compare(member.EmailAddress, emailAddress, StringComparison.CurrentCultureIgnoreCase) == 0
                                                                            && member.MemberId != memberId).Count();

                return memberCount == 0 ? false : true;
            }
        }

        /// <summary>
        /// Delete Member
        /// </summary>
        /// <returns></returns>
        public static bool DeleteMember(int memberId)
        {
            using (var projectManagementSQLDatabaseEntities = new ProjectManagementSQLDatabaseEntities())
            {
                var memberDetail = projectManagementSQLDatabaseEntities.tblMembers.Where(member => member.MemberId == memberId).FirstOrDefault();
                projectManagementSQLDatabaseEntities.tblMembers.Remove(memberDetail);
                return projectManagementSQLDatabaseEntities.SaveChanges() > 0;
            }
        }

        #endregion
    }
}
