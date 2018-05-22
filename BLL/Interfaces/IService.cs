using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IService<T> where T: class 
    {
        T GetEntity(int id);
        void CreateEntity(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entity);
    }
}
