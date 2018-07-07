using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootstrapper
    {
        protected NativeInjectorBootstrapper() { }

        public static void RegisterServices(IServiceCollection services)
        {
            DomainDependecyResolver.Register(services);
            RepositoryDependencyResolver.Register(services);
        }
    }
}
