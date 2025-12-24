using Microsoft.EntityFrameworkCore;
namespace FilmDiziInceleme.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
