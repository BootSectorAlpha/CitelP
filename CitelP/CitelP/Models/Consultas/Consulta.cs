using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Models.Consultas
{
  public class Consulta
  {
    public int Pagina { get; protected set; }
    public int ItemsPorPagina { get; protected set; }

    public Consulta(int pagina, int itensPorPagina)
    {
      Pagina = pagina;
      ItemsPorPagina = itensPorPagina;

      if (Pagina <= 0)
      {
        Pagina = 1;
      }

      if (ItemsPorPagina <= 0)
      {
        ItemsPorPagina = 10;
      }
    }
  }
}
