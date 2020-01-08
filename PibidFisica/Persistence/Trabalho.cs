using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Trabalho
    {
        public int IdTrabalho { get; set; }
        public string Titulo { get; set; }
        public string Link { get; set; }
        public string Autores { get; set; }
        public int IdEvento { get; set; }

        public Evento IdEventoNavigation { get; set; }
    }
}
