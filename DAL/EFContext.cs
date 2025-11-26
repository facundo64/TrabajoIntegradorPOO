using BE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class EFContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ExamenLUG2025DB;Integrated Security=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("Producto");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Proveedor>().ToTable("Proveedor");

            modelBuilder.Entity<Usuario>().ToTable("Usuario");

            base.OnModelCreating(modelBuilder);
        }
    }
}