using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Entradas.Compras.Servicios.Interfaces;
using Trazabilidad.App.Entradas.Nacimientos.Servicios.Interfaces;

namespace Trazabilidad.App.Entradas.Servicios
{
    public interface IFactoriaServicios
    {
        IBovinoNacidoAdaptador GetServicioBovinoNacido();
        IBovinoCompradoAdaptador GetServicioBovinoComprado();
        IHijoAdaptador GetServicioHijo();
    }
}
