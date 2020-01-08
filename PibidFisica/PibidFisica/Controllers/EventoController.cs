using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PibidFisica.Services;

namespace PibidFisica.Controllers
{
    public class EventoController : Controller
    {
        private readonly GerenciadorEvento _gerenciadorEvento;

        public EventoController(GerenciadorEvento gerenciadorEvento)
        {
            _gerenciadorEvento = gerenciadorEvento;
        }
   
        public ActionResult Index()
        {
            return View(_gerenciadorEvento.ObterTodos());
        }

        
        public ActionResult Details(int id)
        {
            return View(_gerenciadorEvento.ObterPorId(id));
        }
    }
}