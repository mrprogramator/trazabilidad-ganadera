using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Ganado.Servicios.Listas
{
    public class MuerteLista : List<Muerte>
    {
        public MuerteLista(Muerte[] items)
            : base(items)
        {
        }
    }
}
