using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Salidas.Muertes.Servicios.Interfaces;
using Trazabilidad.App.Salidas.Ventas.Servicios.Interfaces;

namespace Trazabilidad.App.Salidas.Servicios
{
    public interface IFactoriaServicios
    {
        IBovinoMuertoAdaptador GetServicioBovinoMuerto();
        IBovinoVendidoAdaptador GetServicioBovinoVendido();
    }
}
