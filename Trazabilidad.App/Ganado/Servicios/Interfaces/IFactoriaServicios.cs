using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Servicios.Interfaces
{
    public interface IFactoriaServicios
    {
        IBovinoAdaptador GetServicioGanado();
        INacimientoAdaptador GetServicioNacimiento();
    }
}
