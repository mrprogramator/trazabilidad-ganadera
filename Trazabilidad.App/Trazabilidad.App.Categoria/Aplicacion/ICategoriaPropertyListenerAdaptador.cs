using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Categorias.Aplicacion
{
    public interface ICategoriaPropertyListenerAdaptador
    {
        CategoriaPropertyListener GetAll();
        void SetAll();
    }
}
