using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorTarefas.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Excluir(int id);
        void Atualizar(TEntity obj);
        void Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> Listar();
        void Dispose();
    }
}
