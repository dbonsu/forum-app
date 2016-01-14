using ForumApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services.Interfaces
{
    public interface IRoleService
    {
        /// <summary>
        /// Gets a role by name
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        RoleEntity GetRoleByName(string roleName);

        /// <summary>
        /// Retrieves user's roles
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        RoleEntity GetRoleByUserID(long userID);

        /// <summary>
        /// Retrieves the user role entity
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        ICollection<UserRoleEntity> GetRoleList(long userID);

        /// <summary>
        /// Returns user roles from the userrole entity
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        ICollection<RoleEntity> GetUserRoles(long userID);
    }
}