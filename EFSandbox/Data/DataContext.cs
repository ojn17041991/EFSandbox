using EFSandbox.Models;
using Microsoft.EntityFrameworkCore;

namespace EFSandbox.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Container> Containers { get; set; }

        public DbSet<Unit> Units { get; set; }
    }
}
