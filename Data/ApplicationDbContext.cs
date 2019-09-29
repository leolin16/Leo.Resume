using Leo.Resume.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leo.Resume.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Screen> Screens { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            Database.Migrate(); // Migrate method needs Microsoft.EntityFrameworkCore.Design
        }
    }
}