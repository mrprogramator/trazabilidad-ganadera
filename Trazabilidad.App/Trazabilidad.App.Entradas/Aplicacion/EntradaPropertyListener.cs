using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Entradas.Aplicacion
{
    public class EntradaPropertyListener : List<EntradaItemListener>
    {
        public EntradaPropertyListener(EntradaItemListener[] items)
            : base(items)
        {
        }
    }
}
