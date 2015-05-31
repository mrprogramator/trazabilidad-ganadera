using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Categorias.Dominio;
using Trazabilidad.App.Categorias.Servicios.Listas;

namespace Trazabilidad.App.Categorias.Servicios.Interfaces
{
    public interface ICategoriaAdaptador
    {
        Categoria GetById(Int32 id);
        CategoriaLista GetAll();
        void SetAll();
    }
}
