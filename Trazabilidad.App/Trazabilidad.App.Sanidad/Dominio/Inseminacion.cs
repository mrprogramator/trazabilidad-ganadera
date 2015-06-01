using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Sanidad.Dominio
{
    public class Inseminacion : Sanidad
    {
        public virtual Bovino Padre { get; set; }

        public String Observaciones { get; set; }
    }
}
