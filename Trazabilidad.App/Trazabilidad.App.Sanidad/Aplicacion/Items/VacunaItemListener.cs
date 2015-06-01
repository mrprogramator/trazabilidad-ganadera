using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trazabilidad.App.Sanidad.Aplicacion
{
    public class VacunaItemListener : SanidadItemListener
    {
        public String Nombre { get; set; }

        public Int32 Bovino { get; set; }

        public Decimal Dosis { get; set; }
    }
}
