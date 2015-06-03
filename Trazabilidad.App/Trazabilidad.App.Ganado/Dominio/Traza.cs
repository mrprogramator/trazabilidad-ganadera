using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Dominio
{
    public class Traza
    {
        public Int32 Id { get; set; }

        public DateTime Fecha { get; set; }

        public virtual Bovino Bovino { get; set; }
    }
}
