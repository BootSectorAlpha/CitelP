using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Resources
{
  public class ResultadoDaConsultaResource<L>
  {
    public int TotalItens { get; set; } = 0;
    public List<L> Itens { get; set; } = new List<L>();
  }
}
