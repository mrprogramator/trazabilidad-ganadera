using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;
using Trazabilidad.App.Entradas.Dominio;

namespace Trazabilidad.App.Entradas.Nacimientos.Dominio
{
	public class Hijo : BovinoNacido
	{
		public virtual Toro Padre { get; set; }
		public virtual Vaca Madre { get; set; }
                
        public Hijo (BovinoNacido bovino_nacido, Toro padre, Vaca madre)
        {
            Id = bovino_nacido.Id;
            Categoria = bovino_nacido.Categoria;
            Nacimiento = bovino_nacido.Nacimiento;
            Padre = padre;
            Madre = madre;
        }
	}
}