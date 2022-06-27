using System.Collections.Generic;

namespace CitelP.Models
{
  public class Categoria
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public IList<Produto> Produto { get; set; } = new List<Produto>();
  }
}
