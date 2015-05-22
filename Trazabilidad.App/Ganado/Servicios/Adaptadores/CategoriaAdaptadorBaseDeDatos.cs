using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Ganado.Dominio;
using Trazabilidad.App.Ganado.Servicios.Interfaces;
using Trazabilidad.App.Ganado.Servicios.Listas;
using System.Data;

namespace Trazabilidad.App.Ganado.Servicios.Adaptadores
{
    public class CategoriaAdaptadorBaseDeDatos : ICategoriaAdaptador
    {
        private BaseDeDatos bd;

        public CategoriaAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Categoria GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "categoria",
                "id, nombre, descripcion");

            var item = DataRowCategoria(row);

            return item;
        }

        public CategoriaLista GetAll()
        {
            var dt = bd.GetAll("categoria",
                "id, nombre, descripcion");

            var items = new List<Categoria>();

            foreach (DataRow row in dt.Rows)
            {
                var categoria = DataRowCategoria(row);

                items.Add(categoria);
            }

            var lista = new CategoriaLista(items.ToArray());

            return lista;
        }

        public void setData(String[] Data)
        {
        }

        private Categoria DataRowCategoria(DataRow row)
        {
            var categoria = new Categoria()
            {
                Id = (Int32)row["id"],
                Nombre = (String)row["nombre"],    
            };

            if (!(row["descripcion"] is DBNull))
                categoria.Descripcion = (String)row["descripcion"];

            return categoria;
        }
    }
}
