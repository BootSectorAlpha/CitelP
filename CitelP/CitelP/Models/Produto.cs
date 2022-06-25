using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Models
{
  public class Produto
  {
    [Required]
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    public DateTime Fabricacao { get; set; }

    [Required]
    public DateTime Validade { get; set; }

   
    public float Preco { get; set; }


    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }
  }
}
