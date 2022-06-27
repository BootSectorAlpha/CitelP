using System.Collections.Generic;

namespace CitelP.Models.Consultas
{
  public class ResultadoDaConsulta<L>
  {
    public List<L> Itens { get; set; } = new List<L>();
    public int TotalItens { get; set; } = 0;
  }
}
