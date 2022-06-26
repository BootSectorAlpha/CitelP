using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Models
{
  public class Categoria
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public IList<Produto> Produto { get; set; } = new List<Produto>();
  }
}
