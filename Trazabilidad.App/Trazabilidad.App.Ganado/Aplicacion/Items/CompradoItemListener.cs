﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class CompradoItemListener : GanadoItemListener
    {
        public DateTime Entrada { get; set; }
        public String Observaciones { get; set; }
        public Decimal Precio { get; set; }
    }
}