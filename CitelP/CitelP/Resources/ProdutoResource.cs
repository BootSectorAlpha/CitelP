using System;

namespace CitelP.Resources
{
  public class ProdutoResource
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime Fabricacao { get; set; }
    public DateTime Validade { get; set; }
    public float Preco { get; set; }
    public CategoriaResource Categoria { get; set; }
  }
}
