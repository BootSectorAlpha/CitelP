using CitelP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitelP.Servicos.Comunicacao
{
    public class SaveCategoriaResponse : BaseResponse
    {
      public Categoria Categoria { get; private set; }

      private SaveCategoriaResponse(bool success, string message, Categoria categoria) : base(success, message)
      {
        Categoria = categoria;
      }

      /// <summary>
      /// Creates a success response.
      /// </summary>
      /// <param name="categoria">Saved category.</param>
      /// <returns>Response.</returns>
      public SaveCategoriaResponse(Categoria categoria) : this(true, string.Empty, categoria)
      { }

      /// <summary>
      /// Creates am error response.
      /// </summary>
      /// <param name="message">Error message.</param>
      /// <returns>Response.</returns>
      public SaveCategoriaResponse(string message) : this(false, message, null)
      { }
    }
  
}
