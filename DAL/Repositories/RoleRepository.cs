using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class RoleRepository: IRoleRepo
    {
        private AlbumContext db;

        public RoleRepository(AlbumContext context)
        {
            this.db = context;
        }

        public IEnumerable<Role> GetUserRoles(int userId)
        {
            return db.Set<User>().FirstOrDefault(user => user.Id == userId)?.Roles.Select(role => new Role());
        }

        public void AddUserToRole(int userId, string roleName)
        {
            User user = db.Set<User>().FirstOrDefault(u => u.Id == userId);
            if (user == null) return;

            Role role = db.Set<Role>().FirstOrDefault(r => r.RoleName == roleName);
            if (role == null) return;

            role.Users.Add(user);
        }
    }
}
