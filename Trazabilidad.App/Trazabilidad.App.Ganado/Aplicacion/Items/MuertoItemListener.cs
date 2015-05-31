using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class MuertoItemListener : GanadoItemListener
    {
        public DateTime Salida { get; set; }
        public String Causa { get; set; }
    }
}
