using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Salidas.Ventas.Dominio;

namespace Trazabilidad.App.Salidas.Ventas.Servicios.Listas
{
    public class BovinoVendidoLista : List<BovinoVendido>
    {
        public BovinoVendidoLista(BovinoVendido[] items)
            : base(items)
        {
        }
    }
}
