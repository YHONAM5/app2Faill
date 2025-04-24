using Microsoft.EntityFrameworkCore;
using repocru2.Models;

namespace repocru2.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Cliente> Clientes { get; set;}
    }
}