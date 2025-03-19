using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using prevdent.application.Services.Interfaces;
using PrevDent.Appllication.Services;
using PrevDent.Domain.Interfaces;
using PrevDent.Infrastructure.Data.AppData;
using PrevDent.Infrastructure.Data.Repository;

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
    }
}