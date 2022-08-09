using Microsoft.EntityFrameworkCore;
using VGStorePractica.Models;

namespace VGStorePractica.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //Contructor
        {

        }
        public DbSet<Categorias> Categorias { get; set; }
    }
}
