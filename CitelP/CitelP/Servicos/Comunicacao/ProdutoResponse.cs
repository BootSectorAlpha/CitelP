using CitelP.Models;

namespace CitelP.Servicos.Comunicacao
{
  public class ProdutoResponse : BaseResponse
  {
    public Produto Produto { get; private set; }
    private ProdutoResponse(bool success, string message, Produto produto) : base(success, message)
    {
      Produto = produto;
    }

    /// <param name="produto">Categoria salva.</param>

    public ProdutoResponse(Produto produto) : this(true, string.Empty, produto)
    { }

    /// <param name="message">Mensagem de erro.</param>

    public ProdutoResponse(string message) : this(false, message, null)
    { }
  }
}

