using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trazabilidad.App.Categorias.Dominio
{
	public class Categoria
	{
		public Int32 Id { get; set; }
		public String Nombre { get; set; }
        public String Sexo { get; set; }
		public String Descripcion { get; set; }
	}
}