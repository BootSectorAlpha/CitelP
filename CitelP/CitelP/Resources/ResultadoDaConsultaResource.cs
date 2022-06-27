using System.Collections.Generic;

namespace CitelP.Resources
{
  public class ResultadoDaConsultaResource<L>
  {
    public int TotalItens { get; set; } = 0;
    public List<L> Itens { get; set; } = new List<L>();
  }
}
