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

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
    }
}
