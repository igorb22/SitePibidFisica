using System;
using System.Collections.Generic;

namespace Models
{
    public class EventoModel
    {
        public EventoModel()
        {
            Galeria = new HashSet<GaleriaModel>();
            Trabalho = new HashSet<TrabalhoModel>();
        }

        public int IdEvento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Cidade { get; set; }
        public string Titulo { get; set; }
        public string ImagemEvento { get; set; }
        public string Categoria { get; set; }
        public string Programa { get; set; }

        public ICollection<GaleriaModel> Galeria { get; set; }
        public ICollection<TrabalhoModel> Trabalho { get; set; }
    }
}
