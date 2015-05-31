using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class VendidoItemListener : GanadoItemListener
    {        
        public DateTime Salida { get; set; }
        public String Destino { get; set; }
        public Decimal Precio { get; set; }
        public String Observaciones { get; set; }

    }
}
