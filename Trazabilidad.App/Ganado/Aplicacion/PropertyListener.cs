using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class PropertyListener : List<ItemListener>
    {
        public PropertyListener(ItemListener[] items)
            : base(items)
        {
        }
    }
}
