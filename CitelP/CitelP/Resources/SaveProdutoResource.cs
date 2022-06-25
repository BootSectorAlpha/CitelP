using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Resources
{
  public class SaveProdutoResource
  {
    public string Nome { get; set; }


    public DateTime Fabricacao { get; set; }


    public DateTime Validade { get; set; }


    public float Preco { get; set; }


    public CategoriaResource Categoria { get; set; }
  }
}
