using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Interfaces
{
    public interface IUserService: IService<UserDTO>
    {
        UserDTO GetUserByLogin(string login);
        void ChangeUserPassword(string login, string password);
    }
}
