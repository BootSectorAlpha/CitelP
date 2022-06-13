using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Models
{
  public class Categoria
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Este Campo é Obrigatório")]
    [MaxLength(60, ErrorMessage = "Este Campo Deve ter Entre 3 e 60 Caracteres")]
    [MinLength(3, ErrorMessage = "Este Campo Deve ter Entre 3 e 60 Caracteres")]
    public string Titulo { get; set; }
  }
}
