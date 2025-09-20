using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using VendasApp.Models;

namespace VendasApp.Data
{
    public class Contexto : DbContext 
    {
        public Contexto() : base()
        {
            Database.EnsureCreated();
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var databasePath = Path.Combine(Directory.GetCurrentDirectory(), "Database", "VenadasApp.db");
                Directory.CreateDirectory(Path.GetDirectoryName(databasePath));
                optionsBuilder.UseSqlite($"Data Source={databasePath}");
            }
        }
    }
}
