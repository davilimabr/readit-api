using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Readit.Dominio.Opcoes;

namespace Readit.Ioc.Dependencias
{
    public static class OpcoesDependencias
    {
        public static void AddOpcoes(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<BancoDeDadosOpcoes>(options => configuration.GetSection("BancoDeDados").Bind(options));
        }
    }
}
