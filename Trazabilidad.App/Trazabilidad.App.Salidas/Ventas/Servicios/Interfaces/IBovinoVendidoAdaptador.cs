using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Salidas.Dominio;
using Trazabilidad.App.Salidas.Ventas.Servicios.Listas;

namespace Trazabilidad.App.Salidas.Ventas.Servicios.Interfaces
{
    public interface IBovinoVendidoAdaptador
    {
        BovinoVendidoLista GetAll();
    }
}
