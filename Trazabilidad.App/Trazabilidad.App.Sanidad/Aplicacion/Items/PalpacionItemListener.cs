using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trazabilidad.App.Sanidad.Aplicacion
{
    public class PalpacionItemListener : SanidadItemListener
    {
        public Int32 Bovino { get; set; }

        public Int32 Numero { get; set; }

        public Int32 MesGestacion { get; set; }

        public Boolean Preñada { get; set; }
    }
}
