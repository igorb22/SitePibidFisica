using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class EventoModel
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

        public ICollection<GaleriaModel> Galeria { get; set; }
        public ICollection<TrabalhoModel> Trabalho { get; set; }
    }
}
