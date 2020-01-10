using Models;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PibidFisica.Services
{
    public class GerenciadorGaleria
    {
        private readonly BD_PIBID_FISICAContext _context;
        public GerenciadorGaleria(BD_PIBID_FISICAContext context)
        {
            _context = context;
        }

        public GaleriaModel ObterPorId(int id)
       => _context.Galeria
                .Where(t => t.IdGaleria == id)
                .Select(galeria => new GaleriaModel
                {
                    IdEvento = galeria.IdEvento,
                    IdGaleria = galeria.IdGaleria,
                    Link = galeria.Link
                }).FirstOrDefault();


        public List<GaleriaModel> ObterTodos(string programa)
        => _context.Galeria
                .Where(galeriaModel => galeriaModel.IdEventoNavigation.Programa.Equals(programa))
                .Select(galeria => new GaleriaModel
                {
                    IdEvento = galeria.IdEvento,
                    IdGaleria = galeria.IdGaleria,
                    Link = galeria.Link
                }).ToList();
    }
}
