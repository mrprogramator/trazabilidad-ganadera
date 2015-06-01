using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Sanidad.Dominio
{
    public class Palpacion : Sanidad
    {
        public Int32 Numero { get; set; }
        
        public Int32 MesGestacion { get; set; }
        
        public Boolean Estado { get; set; }
    }
}
