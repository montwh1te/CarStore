using Microsoft.EntityFrameworkCore;
using CarStore.Models;

namespace CarStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Carro> Carros { get; set; } = null!;
        public DbSet<Vendedor> Vendedores { get; set; } = null!;
        public DbSet<Nota> Notas { get; set; } = null!;
    }
}
