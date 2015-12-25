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
    }
}