using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Entradas.Compras.Dominio;
using Trazabilidad.App.Entradas.Nacimientos.Servicios.Listas;

namespace Trazabilidad.App.Entradas.Nacimientos.Servicios.Interfaces
{
    public interface IHijoAdaptador
    {
        HijoLista GetAll();
    }
}
