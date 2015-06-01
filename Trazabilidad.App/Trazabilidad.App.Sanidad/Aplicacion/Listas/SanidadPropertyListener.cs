using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Sanidad.Aplicacion
{
    public class SanidadPropertyListener<T> : List<T>
    {
        public SanidadPropertyListener(T [] items)
            : base(items)
        {
        }
    }
}
