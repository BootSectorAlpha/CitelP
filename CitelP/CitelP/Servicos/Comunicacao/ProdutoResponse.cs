using CitelP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Servicos.Comunicacao
{
  public class ProdutoResponse : BaseResponse
  {
    public Produto Produto{ get; private set; }

    private ProdutoResponse(bool success, string message, Produto produto) : base(success, message)
    {
      Produto = produto;
    }

    /// <summary>
    /// Creates a success response.
    /// </summary>
    /// <param name="produto">Saved category.</param>
    /// <returns>Response.</returns>
    public ProdutoResponse(Produto produto) : this(true, string.Empty, produto)
    { }

    /// <summary>
    /// Creates am error response.
    /// </summary>
    /// <param name="message">Error message.</param>
    /// <returns>Response.</returns>
    public ProdutoResponse(string message) : this(false, message, null)
    { }
  }
}

