using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class UnitOfWork: IUnitOfWork
    {
        private AlbumContext db;
        //private PhotoRepository photoRepository;
        //private UserRepository userRepository;
        //private RoleRepository roleRepository;

        public UnitOfWork(string connectionString)
        {
            db = new AlbumContext(connectionString);
        }
        //public IRepository<Photo> Photos
        //{
        //    get
        //    {
        //        if (photoRepository == null)
        //            photoRepository = new PhotoRepository(db);
        //        return photoRepository;
        //    }
        //}

        //public IRepository<User> Users
        //{
        //    get
        //    {
        //        if (userRepository == null)
        //            userRepository = new UserRepository(db);
        //        return userRepository;
        //    }
        //}
     

        public void Save()
        {
            if (db != null)
            {
                db.SaveChanges();
            }
        }

        public void Dispose()
        {
            if (db != null)
            {
                db.Dispose();
            }
        }

    }
}

