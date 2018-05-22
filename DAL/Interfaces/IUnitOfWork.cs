using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Photo> Photos { get; }
        IRepository<User> Users { get; }
        IRepository<Rating> Ratings { get; }
        IRepository<Role> Roles { get; }
        void Save();
    }
}
