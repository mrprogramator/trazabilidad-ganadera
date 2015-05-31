using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Categorias.Aplicacion
{
    public class CategoriaPropertyListener : List<CategoriaItemListener>
    {
        public CategoriaPropertyListener(CategoriaItemListener[] items)
            : base(items)
        {
        }
    }
}
