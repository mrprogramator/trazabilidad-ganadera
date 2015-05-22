using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Ganado.Servicios.Listas
{
    public class CompraLista : List<Compra>
    {
        public CompraLista(Compra[] items)
            : base(items)
        {
        }
    }
}
