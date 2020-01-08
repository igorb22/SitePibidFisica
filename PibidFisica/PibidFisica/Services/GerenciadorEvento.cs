using PibidFisica.Services.Interfaces;
using PibidFisica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Persistence;

namespace PibidFisica.Services
{
    public class GerenciadorEvento : IGerenciador<EventoModel>
    {

        private readonly BD_PIBID_FISICAContext _context;
        public GerenciadorEvento(BD_PIBID_FISICAContext context)
        {
            _context = context;
        }

        public EventoModel ObterPorId(int id)
       => _context.Evento
                .Where(e => e.IdEvento == id)
                .Select(evento => new EventoModel
                {
                    IdEvento = evento.IdEvento,
                    DataInicio = evento.DataInicio,
                    DataFim = evento.DataFim,
                    Cidade = evento.Cidade,
                    Titulo = evento.Titulo,
                    Galeria = AdicionaGaleria(evento.Galeria),
                    Trabalho = AdicionaTrabalhos(evento.Trabalho)
                }).FirstOrDefault();


        public List<EventoModel> ObterTodos()
        => _context.Evento
                .Select(evento => new EventoModel
                {
                    IdEvento = evento.IdEvento,
                    DataInicio = evento.DataInicio,
                    DataFim = evento.DataFim,
                    Titulo = evento.Titulo,
                    Cidade = evento.Cidade,
                    Galeria = AdicionaGaleria(evento.Galeria),
                    Trabalho = AdicionaTrabalhos(evento.Trabalho)
                }).ToList();


        public ICollection<GaleriaModel> AdicionaGaleria(ICollection<Galeria> galeria)
        {
            ICollection<GaleriaModel> itens = new HashSet<GaleriaModel>();
            GaleriaModel g;

            foreach (Galeria item in galeria)
            {
                g = new GaleriaModel();
                g.IdGaleria = item.IdGaleria;
                g.Link = item.Link;
                g.IdEvento = item.IdEvento;

                itens.Add(g);
            }

            return itens;
        }

        public ICollection<TrabalhoModel> AdicionaTrabalhos(ICollection<Trabalho> trabalho)
        {
            ICollection<TrabalhoModel> itens = new HashSet<TrabalhoModel>();
            TrabalhoModel t;

            foreach (Trabalho item in trabalho)
            {
                t = new TrabalhoModel();

                t.IdTrabalho = item.IdTrabalho;
                t.Link = item.Link;
                t.Titulo = item.Titulo;
                t.Autores = item.Autores;
                t.IdEvento = item.IdEvento;

                itens.Add(t);
            }

            return itens;
        }
    }
}
