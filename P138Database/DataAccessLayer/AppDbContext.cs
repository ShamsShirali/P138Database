using Microsoft.EntityFrameworkCore;
using P138Database.Models;

namespace P138Database.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Marka> Markas { get; set; }

        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
