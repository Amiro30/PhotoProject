using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
using BLL.Interfaces;
using BLL.Mappers;
using DAL.Interfaces;

namespace BLL.Services
{
    class PhotoService: IPhotoService
    {
        private readonly IUnitOfWork uow;
        private readonly IPhotoRepo repository;

        public PhotoService(IUnitOfWork uow, IPhotoRepo repository)
        {
            this.uow = uow;
            this.repository = repository;
        }

        public void CreateEntity(PhotoDTO photo)
        {
            repository.Create(photo.ToDalPhoto());
            uow.Save();
        }

        public void DeleteEntity(PhotoDTO photo)
        {
            repository.Delete(photo.ToDalPhoto());
            uow.Save();
           
        }

        public PhotoDTO GetEntity(int id)
        {
            return repository.GetById(id).ToBllPhoto();
        }

        public void UpdateEntity(PhotoDTO photo)
        {
            repository.Update(photo.ToDalPhoto());
            uow.Save();
        }
    }
}

