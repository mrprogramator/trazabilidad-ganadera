using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Sanidad.Aplicacion
{
    public interface ISanidadPropertyListenerAdaptador<T>
    {
        SanidadPropertyListener<T> GetAll();
        void SetAll();
    }
}
