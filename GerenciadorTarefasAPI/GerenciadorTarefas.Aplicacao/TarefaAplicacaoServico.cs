using GerenciadorTarefas.Aplicacao.Interface;
using GerenciadorTarefas.Dominio.Entidade;
using GerenciadorTarefas.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorTarefas.Aplicacao
{
    public class TarefaAplicacaoServico : AplicacaoServicoBase<Tarefa>, ITarefaAplicacaoServico
    {
        private readonly ITarefaServico _tarefaServico;

        public TarefaAplicacaoServico(ITarefaServico tarefaServico)
            :base(tarefaServico)
            
        {
            _tarefaServico = tarefaServico;
        }
    }
}
