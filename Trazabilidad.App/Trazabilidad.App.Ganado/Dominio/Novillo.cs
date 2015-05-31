using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Categorias.Dominio;

namespace Trazabilidad.App.Ganado.Dominio
{
    public class Novillo : BovinoCategorizado
	{
		public Novillo ()
		{
            Categoria = new Categoria()
            {
                Id = 3,
                Nombre = "novillo",
                Sexo = 'M',
                Descripcion = "ganado macho joven"
            };
		}

        public Novillo(BovinoCategorizado bovino_cat)
        {
            Id = bovino_cat.Id;
            Categoria = new Categoria()
            {
                Id = 3,
                Nombre = "novillo",
                Sexo = 'M',
                Descripcion = "ganado macho joven"
            };
        }
	}
}