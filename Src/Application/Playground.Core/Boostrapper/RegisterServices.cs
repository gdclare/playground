using Microsoft.Extensions.DependencyInjection;
using Playground.Core.Logic.Services;
using Playground.Core.Logic.Services.Abstract;

namespace Playground.Core.Boostrapper
{
    public static class DependencyInjectionManager
    {
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterScoped(services);
            RegisterTransient(services);
        }

        private static void RegisterSingleton(IServiceCollection services)
        {
        }

        private static void RegisterScoped(IServiceCollection services)
        {
        }

        public static void RegisterTransient(IServiceCollection services)
        {
            services.AddTransient<IAlbumService, AlbumService>();
        }
    }
}