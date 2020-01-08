using Models;
using Persistence;
using PibidFisica.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PibidFisica.Services
{
    public class GerenciadorTrabalho : IGerenciador<TrabalhoModel>
    {
        private readonly BD_PIBID_FISICAContext _context;
        public GerenciadorTrabalho(BD_PIBID_FISICAContext context)
        {
            _context = context;
        }

        public TrabalhoModel ObterPorId(int id)
       => _context.Trabalho
                .Where(t => t.IdTrabalho == id)
                .Select(trabalho => new TrabalhoModel
                {
                    IdEvento = trabalho.IdEvento,
                    IdTrabalho = trabalho.IdTrabalho,
                    Titulo = trabalho.Titulo,
                    Link = trabalho.Link,
                    Autores = trabalho.Autores
                }).FirstOrDefault();


        public List<TrabalhoModel> ObterTodos()
        => _context.Trabalho
                .Select(trabalho => new TrabalhoModel
                {
                    IdEvento = trabalho.IdEvento,
                    IdTrabalho = trabalho.IdTrabalho,
                    Titulo = trabalho.Titulo,
                    Link = trabalho.Link,
                    Autores = trabalho.Autores
                }).ToList();
    }
}
