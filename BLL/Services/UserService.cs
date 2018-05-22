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
    class UserService: IUserService
    {
        private readonly IUnitOfWork uow;
        private readonly IUserRepo repository;

        public UserService(IUnitOfWork uow, IUserRepo repository)
        {
            this.uow = uow;
            this.repository = repository;
        }

        public void CreateEntity(UserDTO user)
        {
            repository.Create(user.ToDalUser());
            uow.Save();
        }

        public void DeleteEntity(UserDTO user)
        {
            repository.Delete(user.ToDalUser());
            uow.Save();
        }

        public UserDTO GetEntity(int id)
        {
            return repository.GetById(id).ToBllUser();
        }

        public UserDTO GetUserByLogin(string login)
        {
            return repository.GetByLogin(login).ToBllUser();
        }

        public void UpdateEntity(UserDTO user)
        {
            repository.Update(user.ToDalUser());
            uow.Save();
        }


        public void ChangeUserPassword(string login, string password)
        {
            repository.ChangeUserPassword(login, password);
            uow.Save();
        }
    }
}
