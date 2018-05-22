using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
using DAL.Entities;

namespace BLL.Mappers
{
    static class BLLMappers
    {
        public static Photo ToDalPhoto(this PhotoDTO photoDto)
        {
            return new Photo()
            {
                Id = photoDto.Id,
                Title = photoDto.Title,
                Description = photoDto.Description,
                PhotoFile = photoDto.PhotoFile,
                TotalRate = photoDto.TotalRate,
                CreatedDate = photoDto.CreatedDate,
                UserId = photoDto.UserId
            };
        }
        public static PhotoDTO ToBllPhoto(this Photo dalPhoto)
        {
            if (dalPhoto == null) return null;

            return new PhotoDTO()
            {
                Id = dalPhoto.Id,
                Title = dalPhoto.Title,
                Description = dalPhoto.Description,
                PhotoFile = dalPhoto.PhotoFile,
                TotalRate = dalPhoto.TotalRate,
                CreatedDate = dalPhoto.CreatedDate,
                UserId = dalPhoto.UserId
            };
        }

        public static User ToDalUser(this UserDTO userDto)
        {
            return new User()
            {
                Id = userDto.Id,
                Login = userDto.Login,
                Password = userDto.Password,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                UserPhoto = userDto.UserPhoto
            };
        }

        public static UserDTO ToBllUser(this User dalUser)
        {
            if (dalUser == null) return null;

            return new UserDTO()
            {
                Id = dalUser.Id,
                Login = dalUser.Login,
                Password = dalUser.Password,
                FirstName = dalUser.FirstName,
                LastName = dalUser.LastName,
                UserPhoto = dalUser.UserPhoto
            };
        }

        public static Role ToDalRole(this RoleDTO roleDto)
        {
            if (roleDto == null) return null;

            return new Role()
            {
                Id = roleDto.Id,
                RoleName = roleDto.RoleName
            };
        }
        public static RoleDTO ToBllRole(this Role dalRole)
        {
            if (dalRole == null) return null;

            return new RoleDTO()
            {
                Id = dalRole.Id,
                RoleName = dalRole.RoleName
            };
        }
    }
}
