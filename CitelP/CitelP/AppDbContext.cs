using CitelP.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CitelP
{
  public class AppDbContext : DbContext
  {
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
  }
}
