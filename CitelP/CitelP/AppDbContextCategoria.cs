using CitelP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP
{
  public class AppDbContextCategoria : DbContext
  {
    

    public DbSet<Categoria> Categoria { get; set; }

    public AppDbContextCategoria(DbContextOptions<AppDbContextCategoria> options) : base(options)
    {

    }
  }
}
