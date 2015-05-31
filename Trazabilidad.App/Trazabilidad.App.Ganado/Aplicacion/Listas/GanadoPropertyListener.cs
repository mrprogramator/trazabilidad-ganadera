using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class GanadoPropertyListener<T> : List<T>
    {
        public GanadoPropertyListener(T [] items)
            : base(items)
        {
        }
    }
}
