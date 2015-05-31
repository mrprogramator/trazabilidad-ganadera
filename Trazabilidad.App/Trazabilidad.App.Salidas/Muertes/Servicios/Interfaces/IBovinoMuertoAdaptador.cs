using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Salidas.Muertes.Dominio;
using Trazabilidad.App.Salidas.Muertes.Servicios.Listas;

namespace Trazabilidad.App.Salidas.Muertes.Servicios.Interfaces
{
    public interface IBovinoMuertoAdaptador
    {
        BovinoMuerto GetById(Int32 id);
        BovinoMuertoLista GetAll();
    }
}
