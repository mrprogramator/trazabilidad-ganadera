using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Sanidad.Dominio
{
    public class Vacuna : Sanidad
    {
        public String Nombre { get; set; }

        public Decimal Dosis { get; set; }
    }
}
