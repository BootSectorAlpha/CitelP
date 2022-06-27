namespace CitelP.Models.Consultas
{
  public class ConsultaProdutos : Consulta
  {
    public int? CategoriaId { get; set; }

    public ConsultaProdutos(int? categoriaId, int pagina, int itensPorPagina) : base(pagina, itensPorPagina)
    {
      CategoriaId = categoriaId;
    }
  }
}
