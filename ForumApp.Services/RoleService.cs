using ForumApp.BusinessEntities;
using ForumApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services
{
    /// <summary>
    /// IRoleService concrete class
    /// </summary>
    public class RoleService : IRoleService
    {
        public RoleEntity GetRoleByName(string roleName)
        {
            throw new NotImplementedException();
        }

        public RoleEntity GetRoleByUserID(long userID)
        {
            throw new NotImplementedException();
        }

        public ICollection<UserRoleEntity> GetRoleList(long userID)
        {
            throw new NotImplementedException();
        }

        public ICollection<RoleEntity> GetUserRoles(long userID)
        {
            throw new NotImplementedException();
        }
    }
}