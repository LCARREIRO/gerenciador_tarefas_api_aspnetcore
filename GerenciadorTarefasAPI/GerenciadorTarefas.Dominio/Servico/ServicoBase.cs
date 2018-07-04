using GerenciadorTarefas.Dominio.Interfaces.Repositorio;
using GerenciadorTarefas.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorTarefas.Dominio.Servico
{
    public class ServicoBase<TEntity> : IServicoBase<TEntity>, IDisposable
        where TEntity : class
    {

        private readonly IRepositorioBase<TEntity> _repository;

        public ServicoBase(IRepositorioBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Adicionar(TEntity obj)
        {
            _repository.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public IEnumerable<TEntity> Listar()
        {
            return _repository.Listar();
        }

        public TEntity ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }
    }
}
