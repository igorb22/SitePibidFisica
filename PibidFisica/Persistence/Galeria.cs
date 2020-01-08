using System;
using System.Collections.Generic;

namespace Persistence
{
    public partial class Galeria
    {
        public int IdGaleria { get; set; }
        public string Link { get; set; }
        public int IdEvento { get; set; }

        public Evento IdEventoNavigation { get; set; }
    }
}
