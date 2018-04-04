using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convertidor_K.Entidades
{
    class ArchivoValidacion
    {
        public ArchivoValidacion() { }
        public ArchivoValidacion(String origen, String reemplazo)
        {
            this.origen = origen;
            this.reemplazo = reemplazo;
        }
        public String origen { get; set; }
        public String reemplazo { get; set; }
    }
}
