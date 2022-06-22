using CitelP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP
{
    public class AppDbContext: DbContext
    {
        public DbSet<Produto> Produto { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }


    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.Entity<Categoria>().ToTable("Categorias");
      builder.Entity<Categoria>().HasKey(p => p.Id);
      builder.Entity<Categoria>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
      builder.Entity<Categoria>().Property(p => p.Nome).IsRequired().HasMaxLength(30);
      builder.Entity<Categoria>().HasMany(p => p.Produtos).WithOne(p => p.Categoria).HasForeignKey(p => p.CategoriaId);

      builder.Entity<Categoria>().HasData
      (
          new Categoria { Id = 100, Nome = "Informática" }, // Id configurado manualmente devido ao in-memory provider
          new Categoria { Id = 101, Nome = "Eletrônica" },
          new Categoria { Id = 101, Nome = "Alimento" },
          new Categoria { Id = 101, Nome = "Móvel" },
          new Categoria { Id = 101, Nome = "Imóvel" },
          new Categoria { Id = 101, Nome = "Ação" }
      );

      builder.Entity<Produto>().ToTable("Produtos");
      builder.Entity<Produto>().HasKey(p => p.Id);
      builder.Entity<Produto>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
      builder.Entity<Produto>().Property(p => p.Nome).IsRequired().HasMaxLength(50);
      builder.Entity<Produto>().Property(p => p.Fabricacao).IsRequired();
      builder.Entity<Produto>().Property(p => p.Validade).IsRequired();
      builder.Entity<Produto>().Property(p => p.Preco).IsRequired();
    }


  }
}
