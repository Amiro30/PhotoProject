using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class PhotoRepository : IRepository<Photo>
    {

        private AlbumContext db;

        public PhotoRepository(AlbumContext context)
        {
            this.db = context;
        }

        public IEnumerable<Photo> GetAll()
        {
            return db.Photos;
        }

        public Photo Get(int id)
        {
            return db.Photos.Find(id);
        }

        public void Create(Photo photo)
        {
            db.Photos.Add(photo);
        }

        public void Update(Photo photo)
        {
            db.Entry(photo).State = EntityState.Modified;
        }

        public IEnumerable<Photo> Find(Func<Photo, Boolean> predicate)
        {
            return db.Photos.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Photo photo = db.Photos.Find(id);
            if (photo != null)
                db.Photos.Remove(photo);
        }
    }
}
