namespace CitelP
{
  public abstract class BaseRepositorio
  {
    protected readonly AppDbContext _context;
    public BaseRepositorio(AppDbContext context)
    {
      _context = context;
    }
  }
}


