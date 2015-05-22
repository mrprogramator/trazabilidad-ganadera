using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class ItemListener 
    {
        public String Id { get; set; }
        public String Sexo { get; set; }
        public Boolean Estado { get; set; }
        public String MadreId { get; set; }
        public String PadreId { get; set; }
        public String Categoria { get; set; }
        public DateTime Entrada { get; set; }
        public String TipoEntrada { get; set; }
        public DateTime Salida { get; set; }
        public String TipoSalida { get; set; }
    }
}
