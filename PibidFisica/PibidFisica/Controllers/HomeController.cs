using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PibidFisica.Models;
using PibidFisica.Services;

namespace PibidFisica.Controllers
{
    public class HomeController : Controller
    {
        private const string PIBID = "PIBID", 
                             GAEF = "GAEF", 
                             FISICASHOW = "FISICA SHOW";

        private readonly GerenciadorGaleria _gerenciadorGaleria;

        public HomeController(GerenciadorGaleria gerenciadorGaleria)
        {
            _gerenciadorGaleria = gerenciadorGaleria;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Gaef()
        {
            return View(_gerenciadorGaleria.ObterTodos(GAEF));
        }

        public ActionResult Pibid()
        {
            return View(_gerenciadorGaleria.ObterTodos(PIBID));
        }

        public ActionResult FisicaShow()
        {
            return View(_gerenciadorGaleria.ObterTodos(FISICASHOW));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
