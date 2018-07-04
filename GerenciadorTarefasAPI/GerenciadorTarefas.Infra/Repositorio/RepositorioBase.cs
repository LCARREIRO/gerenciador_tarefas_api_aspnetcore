using GerenciadorTarefas.Dominio.Interfaces.Repositorio;
using GerenciadorTarefas.Infra.Configuracoes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorTarefas.Infra.Repositorio
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity>, IDisposable
        where TEntity : class
    {
        protected readonly DbContextOptionsBuilder<Contexto> _OptionBuilder;

        public RepositorioBase()
        {
            _OptionBuilder = new DbContextOptionsBuilder<Contexto>();
        }

        ~RepositorioBase()
        {
            Dispose(false);
        }

        public void Atualizar(TEntity obj)
        {
            using (var banco = new Contexto(_OptionBuilder.Options))
            {
                banco.Update(obj);
                banco.SaveChanges();
            }
        }

        public void Adicionar(TEntity obj)
        {
            using (var banco = new Contexto(_OptionBuilder.Options))
            {
                banco.Add(obj);
                banco.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using (var banco = new Contexto(_OptionBuilder.Options))
            {
                var obj = banco.Set<TEntity>().Find(id);
                banco.Remove(obj);
                banco.SaveChanges();
            }
        }

        public IEnumerable<TEntity> Listar()
        {
            try
            {
                using (var banco = new Contexto(_OptionBuilder.Options))
                {
                    return banco.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool Status)
        {
            if (!Status) return;
            GC.SuppressFinalize(this);
        }

        public TEntity ObterPorId(int id)
        {
            using (var banco = new Contexto(_OptionBuilder.Options))
            {
                return banco.Set<TEntity>().Find(id);
            }
        }

    }
}
