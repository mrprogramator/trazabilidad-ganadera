using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trazabilidad.App.Sanidad.Aplicacion
{
    public class InseminacionItemListener : SanidadItemListener
    {
        public Int32 Madre { get; set; }

        public Int32 Padre { get; set; }

        public String Observaciones { get; set; }
    }
}
