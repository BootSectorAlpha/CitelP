using System.Collections.Generic;

namespace CitelP.Resources
{
  public class ErrorResource
  {
    public bool Sucesso => false;
    public List<string> Mensagens { get; private set; }
    public ErrorResource(List<string> mensagens)
    {
      this.Mensagens = mensagens ?? new List<string>();
    }

    public ErrorResource(string mensagens)
    {
      this.Mensagens = new List<string>();

      if (!string.IsNullOrWhiteSpace(mensagens))
      {
        this.Mensagens.Add(mensagens);
      }
    }
  }
}
