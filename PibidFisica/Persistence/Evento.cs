using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Evento
    {
        public Evento()
        {
            Galeria = new HashSet<Galeria>();
            Trabalho = new HashSet<Trabalho>();
        }

        public int IdEvento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Cidade { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Programa { get; set; }

        public ICollection<Galeria> Galeria { get; set; }
        public ICollection<Trabalho> Trabalho { get; set; }
    }
}
