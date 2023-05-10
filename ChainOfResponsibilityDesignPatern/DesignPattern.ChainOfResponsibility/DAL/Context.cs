using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ApiDb;User Id=SA;Password=S1611n2301T");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
 