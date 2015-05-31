using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Categorias.Dominio;

namespace Trazabilidad.App.Ganado.Dominio
{
	public class BovinoCategorizado : Bovino
	{
		public virtual Categorias.Dominio.Categoria Categoria { get; set; }        
	}
}