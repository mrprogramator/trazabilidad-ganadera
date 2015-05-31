using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Categorias.Dominio;

namespace Trazabilidad.App.Ganado.Dominio
{
    public class Toro : BovinoCategorizado
	{
		public Toro ()
		{
            Categoria = new Categoria()
            {
                Id = 2,
                Nombre = "toro",
                Sexo = 'M',
                Descripcion = "ganado macho"
            };
		}

        public Toro(BovinoCategorizado bovino_cat)
        {
            Id = bovino_cat.Id;
            Categoria = new Categoria()
            {
                Id = 2,
                Nombre = "toro",
                Sexo = 'M',
                Descripcion = "ganado macho"
            };
        }
	}
}