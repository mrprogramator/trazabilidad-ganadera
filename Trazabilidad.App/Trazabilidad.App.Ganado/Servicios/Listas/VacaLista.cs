using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Ganado.Servicios.Listas
{
    public class VacaLista : List<Vaca>
    {
        public VacaLista(Vaca[] items)
            : base(items)
        {
        }
    }
}
