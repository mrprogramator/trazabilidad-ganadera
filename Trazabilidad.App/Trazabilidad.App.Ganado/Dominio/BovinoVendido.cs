using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;
using Trazabilidad.App.Categorias.Dominio;

namespace Trazabilidad.App.Ganado.Dominio
{
	public class BovinoVendido : Bovino
	{        
        public Venta Venta { get; set; }
	}
}