using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Dominio
{
	public class BovinoComprado : Bovino
	{
        public  Compra Compra { get; set; }
	}
}