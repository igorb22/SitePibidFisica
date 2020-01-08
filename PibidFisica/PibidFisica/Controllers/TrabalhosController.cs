
using Microsoft.AspNetCore.Mvc;
using Models;
using PibidFisica.Services;
using System.Linq;
using System.Threading.Tasks;

namespace PibidFisica.Controllers
{
    public class TrabalhosController : Controller
    {
        private readonly GerenciadorTrabalho _gerenciadorTrabalho;

        public TrabalhosController(GerenciadorTrabalho gerenciadorTrabalho)
        {
            _gerenciadorTrabalho = gerenciadorTrabalho;
        }
        
        
        // GET: Trabalhos
        public ActionResult Index(string pesquisa)
        {
            var trabalhos = _gerenciadorTrabalho.ObterTodos();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                trabalhos = trabalhos.Where(s => s.Titulo.Contains(pesquisa)).ToList();
            }

            return View(trabalhos);
        }

    }
}