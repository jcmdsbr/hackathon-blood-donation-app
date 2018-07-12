using Microsoft.Extensions.DependencyInjection;

namespace StarCastGrupoDois.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootstrapper
    {
        protected NativeInjectorBootstrapper()
        {
        }

        public static void RegisterServices(IServiceCollection services)
        {
            DomainDependecyResolver.Register(services);
            RepositoryDependencyResolver.Register(services);
        }
    }
}