using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Ganado.Servicios.Listas
{
    public class HijoLista : List<Hijo>
    {
        public HijoLista(Hijo[] items)
            : base(items)
        {
        }
    }
}
