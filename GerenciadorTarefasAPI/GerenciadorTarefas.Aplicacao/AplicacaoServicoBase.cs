using GerenciadorTarefas.Aplicacao.Interface;
using GerenciadorTarefas.Dominio.Interfaces.Servico;
using GerenciadorTarefas.Infra.Configuracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorTarefas.Aplicacao
{
    public class AplicacaoServicoBase<TEntity> : IAplicacaoServicoBase<TEntity>
        where TEntity : class
    {

        private readonly IServicoBase<TEntity> _servicoBase;

        public AplicacaoServicoBase(IServicoBase<TEntity> servicoBase)
        {
            _servicoBase = servicoBase;
        }       

        public void Atualizar(TEntity obj)
        {
            _servicoBase.Adicionar(obj);
        }

        public void Adicionar(TEntity obj)
        {
            _servicoBase.Adicionar(obj);
        }

        public void Excluir(int id)
        {
            _servicoBase.Excluir(id);
        }

        public IEnumerable<TEntity> Listar()
        {
            return _servicoBase.Listar();
        }

             
        public TEntity ObterPorId(int id)
        {
            return _servicoBase.ObterPorId(id);
        }
    }
}
