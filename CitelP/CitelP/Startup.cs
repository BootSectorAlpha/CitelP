using CitelP.Controllers.Config;
using CitelP.Servicos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace CitelP
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }
    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMemoryCache();

      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

      services.AddControllers().ConfigureApiBehaviorOptions(options =>
      {
        // Adds a custom error response factory when ModelState is invalid
        options.InvalidModelStateResponseFactory = InvalidModelStateResponseFactory.ProduceErrorResponse;
      });

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "CitelP", Version = "v1" });
      });

      string mySQLConnection = Configuration.GetConnectionString("DefaultConnection");
      services.AddDbContext<AppDbContext>(options =>
      options.UseMySql(mySQLConnection, ServerVersion.AutoDetect(mySQLConnection)));

      services.AddCors(options =>
      {
        options.AddPolicy("CorsPolicy",
          builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
          );
      });

      services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
      services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
      services.AddScoped<IUnidadeDeTrabalhoRepositorio, UnidadeDeTrabalho>();

      services.AddScoped<ICategoriaServico, CategoriaServico>();
      services.AddScoped<IProdutoServico, ProdutoServico>();

      services.AddAutoMapper(typeof(Startup));
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CitelP v1"));
      }

      app.UseCors("CorsPolicy");

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
