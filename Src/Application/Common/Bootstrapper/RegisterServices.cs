using Api.Repos;
using Logic;
using Logic.DataAbstract;
using Logic.Services.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace Bootstrapper
{
    public static class DependencyInjectionManager
    {
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterScoped(services);
            RegisterTransient(services);
        }

        private static void RegisterScoped(IServiceCollection services)
        {
            services.AddScoped<IAlbumRepo, AlbumRepo>();
        }

        public static void RegisterTransient(IServiceCollection services)
        {
            services.AddTransient<IAlbumService, AlbumService>();
        }
    }
}