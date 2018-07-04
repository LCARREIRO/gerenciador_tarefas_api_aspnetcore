using GerenciadorTarefas.Aplicacao;
using GerenciadorTarefas.Aplicacao.Interface;
using GerenciadorTarefas.Dominio.Entidade;
using GerenciadorTarefas.Dominio.Interfaces.Repositorio;
using GerenciadorTarefas.Dominio.Interfaces.Servico;
using GerenciadorTarefas.Dominio.Servico;
using GerenciadorTarefas.Infra.Repositorio;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorTarefas.Infra.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IRepositorioBase<Tarefa>, RepositorioBase<Tarefa>>();
            services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();
            

            services.AddScoped<IServicoBase<Tarefa>, ServicoBase<Tarefa>>();
            services.AddScoped<ITarefaServico, TarefaServico>();
            
            services.AddScoped<IAplicacaoServicoBase<Tarefa>, AplicacaoServicoBase<Tarefa>>();
            services.AddScoped<ITarefaAplicacaoServico, TarefaAplicacaoServico>();
            
        }
    }
}
