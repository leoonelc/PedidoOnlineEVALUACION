using Microsoft.EntityFrameworkCore;
using PedidoOnline.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=127.0.0.1;Database=tienda_pedidos;Uid=root;Pwd=;",
            new MySqlServerVersion(new Version(10, 4, 32))); // Versión de MariaDB
    }
}
