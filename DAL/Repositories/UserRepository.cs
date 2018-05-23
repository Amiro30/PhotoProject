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
    class UserRepository : IUserRepo
    {
        private AlbumContext db;

        public UserRepository(AlbumContext context)
        {
            this.db = context;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Set<User>().AsEnumerable().Select(user => new User());
        }

        public User GetById(int id)
        {
            return db.Users.Find(id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }
        
        public void Delete(User user)
        {
            User user_toDelete = db.Users.First(p => p.Id == user.Id);
            db.Users.Remove(user_toDelete);
            //db.Users.Remove(user);
        }

        public User GetByLogin(string login)
        {
            return db.Users.Find(login);
        }

        public void ChangeUserPassword(string login, string password)
        {
            User user = db.Set<User>().FirstOrDefault(u => u.Login == login);

            if (user != null)
            {
                user.Password = password;
            }
        }
    }
}


