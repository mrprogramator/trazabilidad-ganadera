using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Categorias.Dominio;

namespace Trazabilidad.App.Categorias.Servicios.Listas
{
    public class CategoriaLista : List<Categoria>
    {
        public CategoriaLista(Categoria[] items)
            : base(items)
        {
        }
    }
}
