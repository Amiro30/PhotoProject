using System;
using System.Data.Entity;
using DAL.Entities;

namespace DAL
{
    class AlbumContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public AlbumContext(string connectionString) : base(connectionString)
        { }
    }
}
