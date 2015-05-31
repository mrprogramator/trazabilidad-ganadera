using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Aplicacion;

namespace Trazabilidad.App.Entradas.Aplicacion
{
    public class EntradaItemListener
    {
        public DateTime Fecha { get; set; }
        public String Tipo { get; set; }
        public Int32 BovinoId { get; set; }
        public String Categoria { get; set; }
        public String Observaciones { get; set; }
    }
}
