using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Categorias.Dominio;

namespace Trazabilidad.App.Ganado.Dominio
{
    public class Vaca : BovinoCategorizado
	{
		public Vaca ()
		{
            Categoria = new Categoria() 
            {
                Id = 1,
                Nombre = "vaca",
                Sexo = 'H',
                Descripcion = "ganado hembra"
            };
		}

        public Vaca(BovinoCategorizado bovino_cat)
        {
            Id = bovino_cat.Id;
            Categoria = new Categoria()
            {
                Id = 1,
                Nombre = "vaca",
                Sexo = 'H',
                Descripcion = "ganado hembra"
            };
        }
	}
}