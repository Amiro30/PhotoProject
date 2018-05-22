using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    interface IRoleRepo 
    {
        IEnumerable<Role> GetUserRoles(int userId);
       
        void AddUserToRole(int userId, string roleName);
    }
}
