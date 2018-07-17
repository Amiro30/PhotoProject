using System;
using System.Data.Entity;
using DAL.Entities;

namespace DAL
{
    public class AlbumContext : DbContext
    {
        public AlbumContext() : base("AlbumContext")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Rating> Ratings { get; set; }

       
    }
}
