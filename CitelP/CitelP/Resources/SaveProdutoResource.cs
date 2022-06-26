using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Resources
{
  public class SaveProdutoResource
  {
    [Required]
    [MaxLength(50)]
    public string Nome { get; set; }

    [Required]
    public DateTime Fabricacao { get; set; }

    [Required]
    public DateTime Validade { get; set; }

    [Required]
    public float Preco { get; set; }


    public int CategoriaId { get; set; }
  }
}
