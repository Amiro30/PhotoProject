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
    public class PhotoRepository : IPhotoRepo
    {
        private AlbumContext db;
        public PhotoRepository()
        {
            db = new AlbumContext();
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
            db.SaveChanges();
        }

        public void Update(Photo photo)
        {
            db.Entry(photo).State = EntityState.Modified;
        }


        public void Delete(Photo photo)
        {
            Photo photo_toDelete = db.Photos.First(p => p.Id == photo.Id);

            if (photo_toDelete != null)
            {
                db.Photos.Remove(photo_toDelete);
            }
        }
    }
}
