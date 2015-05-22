using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;
using Trazabilidad.App.Ganado.Servicios.Listas;

namespace Trazabilidad.App.Ganado.Servicios.Interfaces
{
    public interface IPesoAdaptador
    {
        Peso GetById(Int32 id);
        PesoLista GetAll();
    }
}
