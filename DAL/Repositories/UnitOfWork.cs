using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;


namespace DAL.Repositories
{
    public class UnitOfWork
    {
        private AlbumContext db = new AlbumContext();
        private PhotoRepository photoRepository;
        private UserRepository userRepository;
        private RoleRepository roleRepository;

     
        public IRepository<Photo> Photos
        {
            get
            {
                if (photoRepository == null)
                    photoRepository = new PhotoRepository();
                return photoRepository;
            }
        }

        public UserRepository Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

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

