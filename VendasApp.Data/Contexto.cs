using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using VendasApp.Models;

namespace VendasApp.Data
{
    public class Contexto : DbContext 
    {
        public Contexto() : base()
        {
            //Comando que força a criação do banco de dados através do entity framework 
            Database.EnsureCreated();
        }

        //Mapeaia as tabelas do banco de dados através das classes
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var databasePath = Path.Combine(Directory.GetCurrentDirectory(), "Database", "VendasApp.db");
                Directory.CreateDirectory(Path.GetDirectoryName(databasePath));
                optionsBuilder.UseSqlite($"Data Source={databasePath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cliente
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Ativo).HasColumnType("BOOLEAN");
                entity.Property(e => e.Nome).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Cep).HasMaxLength(10);
                entity.Property(e => e.Tipodocumento);
                entity.Property(e => e.Documento).HasMaxLength(20);
                entity.Property(e => e.Bairro).HasMaxLength(50);
                entity.Property(e => e.Endereco).HasMaxLength(200);
                entity.Property(e => e.Cidade).HasMaxLength(50);
            });

            // Produto
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Preco).HasColumnType("decimal(10,4").HasMaxLength(4);
                entity.Property(e => e.Descricao).HasMaxLength(200).IsRequired();
                entity.Property(e => e.Ativo).HasColumnType("BOOLEAN");
                entity.Property(e => e.Quantidade);
                entity.Property(e => e.DataInclusao);
                entity.Property(e => e.DataValidade);
            });

            // Usuario
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Ativo).HasColumnType("BOOLEAN");
                entity.Property(e => e.Login).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Senha).HasMaxLength(100).IsRequired();
                entity.Property(e => e.DataUltimoLogin);
            });
        }
    }
}
