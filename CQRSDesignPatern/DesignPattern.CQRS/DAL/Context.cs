using Microsoft.EntityFrameworkCore;
using System;

namespace DesignPattern.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=DesignPattern2;User Id=SA;Password=S1611n2301T");
        }

        public DbSet<Product> Products { get; set; }
    }
}
