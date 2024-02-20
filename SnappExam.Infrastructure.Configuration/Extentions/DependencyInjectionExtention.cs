using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SnappExam.Infrastructure.Caching.InMemory.Services;
using SnappExam.Infrastructure.Persistence.EF.Repositories;

namespace SnappExam.Infrastructure.Configuration.Extentions
{
    public static class ServiceCollectionConfig
    {
        public static IServiceCollection AddDependencyInjectionService(this IServiceCollection services, IConfiguration config)
        {
            services.Scan(current => current
                .FromAssemblies(typeof(ProductRepository).GetTypeInfo().Assembly)
                .AddClasses(cl => cl.InNamespaceOf<ProductRepository>())
                .AsSelf()
                .AsImplementedInterfaces()
                .WithScopedLifetime()


                
                .FromAssemblies(typeof(ProductCachingService).GetTypeInfo().Assembly)
                .AddClasses(c2 => c2.InNamespaceOf<ProductCachingService>())
                .AsSelf()
                .AsImplementedInterfaces()
                .WithScopedLifetime()
            );            
            return services;
        }

    }
}
