using CitelP.Models;

namespace CitelP.Servicos.Comunicacao
{
  public class CategoriaResponse : BaseResponse
  {
    public Categoria Categoria { get; private set; }
    private CategoriaResponse(bool success, string message, Categoria categoria) : base(success, message)
    {
      Categoria = categoria;
    }

    /// <param name="categoria">Categoria salva.</param>

    public CategoriaResponse(Categoria categoria) : this(true, string.Empty, categoria)
    { }

    /// <param name="message">Mensagem de erro.</param>

    public CategoriaResponse(string message) : this(false, message, null)
    { }
  }

}
