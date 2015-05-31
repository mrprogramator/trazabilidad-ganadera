using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Categorias.Dominio;

namespace Trazabilidad.App.Ganado.Dominio
{
    public class Vaquilla : BovinoCategorizado
	{
		public Vaquilla ()
		{
            Categoria = new Categoria()
            {
                Id = 4,
                Nombre = "vaquilla",
                Sexo = 'H',
                Descripcion = "ganado hembra joven"
            };
		}

        public Vaquilla (BovinoCategorizado bovino_cat)
        {
            Id = bovino_cat.Id;
            Categoria = new Categoria()
            {
                Id = 4,
                Nombre = "vaquilla",
                Sexo = 'H',
                Descripcion = "ganado hembra joven"
            };
        }
	}
}