using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PibidFisica.Services;
using System.Linq;

namespace PibidFisica.Controllers
{
    public class TrabalhosController : Controller
    {
        private const string PIBID = "PIBID",
                             GAEF = "GAEF",
                             FISICASHOW = "FISICA SHOW";

        private readonly GerenciadorTrabalho _gerenciadorTrabalho;

        public TrabalhosController(GerenciadorTrabalho gerenciadorTrabalho)
        {
            _gerenciadorTrabalho = gerenciadorTrabalho;
        }


        public ActionResult TrabalhosGaef(string pesquisa)
        {
            var trabalhos = _gerenciadorTrabalho.ObterTodos(GAEF);

            if (!string.IsNullOrEmpty(pesquisa))
            {
                trabalhos = trabalhos.Where(s => s.Titulo.Contains(pesquisa)).ToList();
            }

            return View(trabalhos);
        }

        public ActionResult TrabalhosPibid(string pesquisa)
        {
            var trabalhos = _gerenciadorTrabalho.ObterTodos(PIBID);

            if (!string.IsNullOrEmpty(pesquisa))
            {
                trabalhos = trabalhos.Where(s => s.Titulo.Contains(pesquisa)).ToList();
            }

            return View(trabalhos);
        }

        public ActionResult TrabalhosFisicaShow(string pesquisa)
        {
            var trabalhos = _gerenciadorTrabalho.ObterTodos(FISICASHOW);

            if (!string.IsNullOrEmpty(pesquisa))
            {
                trabalhos = trabalhos.Where(s => s.Titulo.Contains(pesquisa)).ToList();
            }

            return View(trabalhos);
        }

    }
}