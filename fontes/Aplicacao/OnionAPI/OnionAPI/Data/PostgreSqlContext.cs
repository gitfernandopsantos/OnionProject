using Microsoft.EntityFrameworkCore;
using OnionAPI.Models;

namespace OnionAPI.Data
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public  DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

    }
}
