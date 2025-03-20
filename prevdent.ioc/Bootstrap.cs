using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrevDent.Appllication.Services;
using prevdent.application.Services.Interfaces;
using PrevDent.Domain.Interfaces;
using PrevDent.Infrastructure.Data.AppData;
using PrevDent.Infrastructure.Data.Repository;
using prevdent.application.Mappings;
using prevdent.infraestructure.Data.Repository.Interfaces;
using prevdent.infraestructure.Data.Repository;
using prevdent.application.Services;

namespace prevdent.ioc;

public class Bootstrap
{
    public static void Start(IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<ApplicationContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("Oracle");
            options.UseOracle(connectionString);
        });

        service.AddTransient<IPacienteRepository, PacienteRepository>();
        service.AddTransient<IPacienteApplicationService, PacienteApplicationService>();

        service.AddTransient<IDentistaRepository, DentistaRepository>();
        service.AddTransient<IDentistaApplicationService, DentistaApplicationService>();

        service.AddAutoMapper(typeof(MapperProfile));
    }
}
