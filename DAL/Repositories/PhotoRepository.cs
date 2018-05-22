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
    class PhotoRepository : IPhotoRepo
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

        public Photo GetById(int id)
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


        public void Delete(Photo photo)
        {
            db.Photos.Remove(photo);

            //Photo photo = db.Set<Photo>().FirstOrDefault(ph => ph.PhotoId == entity.Id);
            //if (photo != null)
            //{
            //    context.Set<Photo>().Remove(photo);
            //}
        }
    }
}
