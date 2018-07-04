using GerenciadorTarefas.Infra.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorTarefasAPI.v1.Extenxions
{
    public static class DependecyInjectionExtensions
    {
        public static void AddDependecyInjection(this IServiceCollection services)
        {
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
