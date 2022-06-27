using System.ComponentModel.DataAnnotations;

namespace CitelP.Resources
{
  public class SaveCategoriaResource
  {
    [Required]
    [MaxLength(30)]
    public string Nome { get; set; }
  }
}
