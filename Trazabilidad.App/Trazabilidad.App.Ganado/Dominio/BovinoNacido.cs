using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Ganado.Dominio
{
	public class BovinoNacido : Bovino
	{
        public Nacimiento Nacimiento { get; set; }
                       
	}
}