using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Entradas.Nacimientos.Dominio;

namespace Trazabilidad.App.Entradas.Nacimientos.Servicios.Listas
{
    public class BovinoNacidoLista : List<BovinoNacido>
    {
        public BovinoNacidoLista(BovinoNacido[] items)
            : base(items)
        {
        }
    }
}
