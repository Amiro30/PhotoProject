using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
   public interface IUserRepo: IRepository<User>
    {
        User GetByLogin(string login);
        void ChangeUserPassword(string login, string password);
      
    }
}
