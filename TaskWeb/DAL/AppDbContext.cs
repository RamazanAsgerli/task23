using Microsoft.EntityFrameworkCore;
using TaskWeb.Models;

namespace TaskWeb.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Works> Works { get; set; }

    }
}
