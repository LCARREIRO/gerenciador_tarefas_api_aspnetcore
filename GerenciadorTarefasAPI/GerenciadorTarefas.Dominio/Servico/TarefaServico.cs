using GerenciadorTarefas.Dominio.Entidade;
using GerenciadorTarefas.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Text;
using GerenciadorTarefas.Dominio.Interfaces.Repositorio;

namespace GerenciadorTarefas.Dominio.Servico
{
    public class TarefaServico : ServicoBase<Tarefa>, ITarefaServico
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public TarefaServico(ITarefaRepositorio tarefaRepositorio) 
            : base(tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
    }
}
