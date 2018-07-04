using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GerenciadorTarefas.Aplicacao.Interface;
using GerenciadorTarefas.Dominio.Entidade;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciadorTarefas.API.Controllers
{
    [Route("api/[controller]")]
    public class TarefasController : Controller
    {

        private readonly ITarefaAplicacaoServico _tarefaApp;

        public TarefasController(ITarefaAplicacaoServico tarefaApp)
        {
            _tarefaApp = tarefaApp;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        public JsonResult ObterTarefas()
        {
            return Json(_tarefaApp.Listar());
        }

        [HttpPost]
        [Route("api/Tarefas/Adicionar")]
        public JsonResult Adicionar([FromBody] Tarefa tarefa)
        {
            _tarefaApp.Adicionar(tarefa);
            return Json(_tarefaApp.Listar());
        }

        [HttpPost]
        [Route("api/Tarefas/Editar")]
        public JsonResult Editar([FromBody] Tarefa tarefa)
        {
            _tarefaApp.Atualizar(tarefa);
            return Json(_tarefaApp.Listar());
        }


        [HttpPost]
        [Route("api/Tarefas/Excluir")]
        public JsonResult Excluir([FromBody] int id)
        {
            _tarefaApp.Excluir(id);
            return Json(_tarefaApp.Listar());
        }
    }
}
