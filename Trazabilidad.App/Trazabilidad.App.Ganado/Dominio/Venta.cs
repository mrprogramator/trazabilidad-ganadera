using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Dominio
{
	public class Venta : Salida
	{
		public Decimal Precio { get; set; }
        public String Destino { get; set; }
        public String Observaciones { get; set; }
	}
}