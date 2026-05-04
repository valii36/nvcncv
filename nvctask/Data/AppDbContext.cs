using Microsoft.EntityFrameworkCore;
using nvctask.Models;

namespace nvctask.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
