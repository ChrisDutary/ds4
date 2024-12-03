using DulceriaWeb.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace ProyectoFinal.Models
{
    public class DulceriaContext : DbContext
    {
    public DulceriaContext() : base("name=DulceriaContext")  // Cambiar esto
    {
    }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallesPedidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuraciones adicionales de la base de datos si son necesarias
            base.OnModelCreating(modelBuilder);
        }
    }
}