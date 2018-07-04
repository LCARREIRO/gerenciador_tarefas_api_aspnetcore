using Microsoft.AspNetCore.Mvc;
using GerenciadorTarefas.Dominio.Entidade;
using GerenciadorTarefas.Aplicacao.Interface;

namespace GerenciadorTarefasAPI.v1.Controllers
{
    [Route("api/[controller]")]
    public class TarefasController : Controller
    {
        private readonly ITarefaAplicacaoServico _tarefaApp;

        public TarefasController(ITarefaAplicacaoServico tarefaApp)
        {
            _tarefaApp = tarefaApp;
        }

        // GET /api/tarefas       
        public JsonResult ObterTarefas()
        {
           return Json(_tarefaApp.Listar());
        }

        [HttpPost]
        [Route("/api/tarefas/adicionar")]
        public JsonResult Adicionar([FromBody] Tarefa tarefa)
        {
            _tarefaApp.Adicionar(tarefa);
            return Json(_tarefaApp.Listar());
        }

        [HttpPost]
        [Route("/api/tarefas/editar")]
        public JsonResult Editar([FromBody] Tarefa tarefa)
        {
            _tarefaApp.Atualizar(tarefa);
            return Json(_tarefaApp.Listar());
        }

        [HttpPost]
        [Route("/api/tarefas/excluir")]
        public JsonResult Excluir(int id)
        {
            _tarefaApp.Excluir(id);
            return Json(_tarefaApp.Listar());
        }
    }
}
