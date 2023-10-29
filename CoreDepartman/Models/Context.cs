using Microsoft.EntityFrameworkCore;

namespace CoreDepartman.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MIKDAT; database=corepersonel; integrated security=true; TrustServerCertificate=True;");
        }

        public DbSet<Departmanlar> departmanlars { get; set; }
        public DbSet<Personel> personels { get; set; }
    }
}
