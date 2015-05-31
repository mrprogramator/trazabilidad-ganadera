using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Entradas.Compras.Dominio;

namespace Trazabilidad.App.Entradas.Compras.Servicios.Listas
{
    public class BovinoCompradoLista : List<BovinoComprado>
    {
        public BovinoCompradoLista(BovinoComprado[] items)
            : base(items)
        {
        }
    }
}
