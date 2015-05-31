using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Entradas.Aplicacion;

namespace Trazabilidad.App.Entradas.Nacimientos.Aplicacion
{
    public class NacimientoItemListener : EntradaItemListener
    {
        public Int32 Madre { get; set; }
        public Int32 Padre { get; set; }
    }
}
