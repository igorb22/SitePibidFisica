using System;
using System.Collections.Generic;

namespace Persistence
{
    public class GaleriaModel
    {
        public int IdGaleria { get; set; }
        public string Link { get; set; }
        public int IdEvento { get; set; }

        public EventoModel IdEventoNavigation { get; set; }
    }
}
