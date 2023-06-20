using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Meditor.DAL
{
    public class Context: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=DesignPattern3;User Id=SA;Password=S1611n2301T");
        }

        public DbSet<Product> Products { get; set; }
    }
}
