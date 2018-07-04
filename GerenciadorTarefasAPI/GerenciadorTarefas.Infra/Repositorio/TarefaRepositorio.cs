using GerenciadorTarefas.Dominio.Entidade;
using GerenciadorTarefas.Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorTarefas.Infra.Repositorio
{
    public class TarefaRepositorio : RepositorioBase <Tarefa>, ITarefaRepositorio
    {
    }
}
