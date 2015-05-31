using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Entradas.Compras.Dominio;
using Trazabilidad.App.Entradas.Compras.Servicios.Listas;

namespace Trazabilidad.App.Entradas.Compras.Servicios.Interfaces
{
    public interface IBovinoCompradoAdaptador
    {
        BovinoCompradoLista GetAll();
    }
}
