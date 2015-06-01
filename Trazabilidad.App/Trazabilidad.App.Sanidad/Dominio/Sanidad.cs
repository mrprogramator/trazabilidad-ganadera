using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Sanidad.Dominio
{
    public class Sanidad
    {
        public Int32 Id { get; set; }

        public DateTime Fecha { get; set; }

        public virtual Bovino Bovino { get; set; }
    }
}
