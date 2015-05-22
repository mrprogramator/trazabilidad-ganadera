using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Dominio
{
    public class Bovino
    {
        public Int32 Id { get; set; }
        public Char Sexo { get; set; }
        public Boolean Estado { get; set; }

        public virtual Bovino Madre { get; set; }
        public virtual Bovino Padre { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Entrada Entrada { get; set; }
        public virtual Salida Salida { get; set; }
    }
}
