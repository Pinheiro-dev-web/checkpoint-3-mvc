using Microsoft.AspNetCore.Mvc;

namespace MeuProjetoMvc.Controllers
{
    public class AlunoController : Controller
    {
        // Responde ao acessar /Aluno ou /Aluno/Index
        public IActionResult Index()
        {
            // Passando dados para a tela usando ViewBag
            ViewBag.Nome = "Seu Nome Completo";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "1º Semestre - 2026";
            
            return View();
        }

        // Responde ao acessar /Aluno/Detalhes/1
        public IActionResult Detalhes(int id)
        {
            ViewBag.Mensagem = "Visualizando detalhes do aluno ID: " + id;
            return View();
        }
    }
}
