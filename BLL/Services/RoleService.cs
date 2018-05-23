using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
using BLL.Interfaces;
using DAL.Interfaces;

namespace BLL.Services
{
    class RoleService: IRoleService
    {
        private readonly IUnitOfWork uow;
        private readonly IRoleRepo repository;

        public RoleService(IUnitOfWork uow, IRoleRepo repository)
        {
            this.uow = uow;
            this.repository = repository;
        }

        public void CreateEntity(RoleDTO role)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(RoleDTO role)
        {
            throw new NotImplementedException();
        }

        public RoleDTO GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(RoleDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}

