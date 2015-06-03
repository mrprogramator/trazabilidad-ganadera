using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class NacidoItemListener : GanadoItemListener
    {
        public String Padre { get; set; }

        public String Madre { get; set; }
        
        public DateTime Entrada { get; set; }
        
        public String Observaciones { get; set; }
    }
}
