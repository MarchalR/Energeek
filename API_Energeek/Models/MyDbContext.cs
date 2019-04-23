using System;
using Microsoft.EntityFrameworkCore;

namespace API_Energeek.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersProduct> UsersProducts { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
