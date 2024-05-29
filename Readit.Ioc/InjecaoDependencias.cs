using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Readit.Ioc.Dependencias;

namespace Readit.Ioc
{
    public static class InjecaoDependencias
    {
        public static void AddTodasDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOpcoes(configuration);
        }
    }
}
