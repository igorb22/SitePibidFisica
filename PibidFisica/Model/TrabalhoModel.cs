using System;
using System.Collections.Generic;

namespace Persistence
{
    public class TrabalhoModel
    {
        public int IdTrabalho { get; set; }
        public string Titulo { get; set; }
        public string Link { get; set; }
        public int IdEvento { get; set; }

        public EventoModel IdEventoNavigation { get; set; }
    }
}
