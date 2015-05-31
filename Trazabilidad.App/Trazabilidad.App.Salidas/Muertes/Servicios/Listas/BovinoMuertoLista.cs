using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Salidas.Muertes.Dominio;

namespace Trazabilidad.App.Salidas.Muertes.Servicios.Listas
{
    public class BovinoMuertoLista : List<BovinoMuerto>
    {
        public BovinoMuertoLista(BovinoMuerto[] items)
            : base(items)
        {
        }
    }
}
