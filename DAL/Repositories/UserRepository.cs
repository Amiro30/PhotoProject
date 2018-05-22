using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class UserRepository : IRepository<User>
    {
        private AlbumContext db;

        public UserRepository(AlbumContext context)
        {
            this.db = context;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users.Include(o => o.Photo);
        }
    }
}

