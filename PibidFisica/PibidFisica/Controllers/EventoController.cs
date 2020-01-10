using Microsoft.AspNetCore.Mvc;
using PibidFisica.Services;

namespace PibidFisica.Controllers
{
    public class EventoController : Controller
    {
        private const string PIBID = "PIBID",
                            GAEF = "GAEF",
                            FISICASHOW = "FISICA SHOW";
        private readonly GerenciadorEvento _gerenciadorEvento;

        public EventoController(GerenciadorEvento gerenciadorEvento)
        {
            _gerenciadorEvento = gerenciadorEvento;
        }

        public ActionResult EventosGaef()
        {
            return View(_gerenciadorEvento.ObterTodos(GAEF));
        }

        public ActionResult EventosPibid()
        {
            return View(_gerenciadorEvento.ObterTodos(PIBID));
        }

        public ActionResult EventosFisicaShow()
        {
            return View(_gerenciadorEvento.ObterTodos(FISICASHOW));
        }



        // Colocar um pra cada ou só um mesmo ?  
        public ActionResult Details(int id)
        {
            return View(_gerenciadorEvento.ObterPorId(id));
        }
    }
}