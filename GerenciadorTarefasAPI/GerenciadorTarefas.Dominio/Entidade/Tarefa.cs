using GerenciadorTarefas.Helper;
using System;

namespace GerenciadorTarefas.Dominio.Entidade
{
    public class Tarefa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataSolicitacao { get; private set; }
        public DateTime DataConclusao { get; private set; }
        public DateTime DataAtual { get; private set; }
        public bool Concluida { get; private set; }

        protected Tarefa()
        {

        }
        public Tarefa(string nome, DateTime dataSolicitacao, DateTime dataConclusao, DateTime dataAtual, bool concluida)
        {
            SetNome(nome);
            SetDataSolicitacao(dataSolicitacao);
            SetDataConclusao(dataConclusao);
            SetDataAtual(dataAtual);
            SetConcluida(concluida);

        }

        public string SetNome(string _nome)
        {
            Guard.ForNullOrEmpty(_nome, "Informe o nome da tarefa!");
            Guard.StringLength(_nome, 100, "Digite no máximo 100 caracteres!");
            return this.Nome = _nome;
        }

        public DateTime SetDataSolicitacao(DateTime _dataSolicitacao)
        {
            Guard.ForNullOrEmpty(_dataSolicitacao.ToString(), "Informe a data da solicitação!");
            return this.DataSolicitacao = _dataSolicitacao;
        }

        public DateTime SetDataConclusao(DateTime _dataConclusao)
        {
            Guard.ForNullOrEmpty(_dataConclusao.ToString(), "Informe a data da conclusão!");
            return this.DataConclusao = _dataConclusao;
        }

        public DateTime SetDataAtual(DateTime _dataAtual)
        {            
            return this.DataAtual = _dataAtual;
        }

        public bool SetConcluida(bool _concluida)
        {
            return this.Concluida = _concluida;
        }
    }
}
