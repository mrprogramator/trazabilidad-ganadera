using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class TrazaItemListener
    {
        public Int32 Id { get; set; }

        public DateTime Fecha { get; set; }

        public Int32 Bovino { get; set; }

        public String Categoria { get; set; }
    }
}
