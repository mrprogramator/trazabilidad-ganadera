using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Categorias.Dominio;
using Trazabilidad.App.Categorias.Servicios.Interfaces;
using Trazabilidad.App.Categorias.Servicios.Listas;
using System.Data;

namespace Trazabilidad.App.Categorias.Servicios.Adaptadores
{
    public class CategoriaAdaptadorBaseDeDatos : ICategoriaAdaptador
    {
        private BaseDeDatos bd;
        private static CategoriaLista _CategoriaLista;

        public CategoriaAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;            
        }

        public Categoria GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "categoria",
                "id, nombre, sexo, descripcion");

            var item = DataRowCategoria(row);

            return item;
        }

        public CategoriaLista GetAll()
        {
            if (_CategoriaLista == null)
            {
                var dt = bd.GetAll("categoria",
                "id, nombre, sexo, descripcion");

                var items = new List<Categoria>();

                foreach (DataRow row in dt.Rows)
                {
                    var categoria = DataRowCategoria(row);

                    items.Add(categoria);
                }

                _CategoriaLista = new CategoriaLista(items.ToArray());
            }

            return _CategoriaLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Categoria).Name, "id, nombre, sexo, descripcion");

            var keys = new DataColumn[1];

            keys[0] = dt.Columns["id"];
            dt.PrimaryKey = keys;

            foreach (var bovino in _CategoriaLista)
            {
                var row = DataRowCategoria(dt, bovino);

                if (dt.Rows.Contains(row["id"]))
                {
                    bd.UpdateData(dt, row, "categoria");
                }
                else
                {
                    bd.SetData(dt, row, "categoria");
                }
            }
        }

        private Categoria DataRowCategoria(DataRow row)
        {
            var categoria = new Categoria()
            {
                Id = (Int32)row["id"],
                Nombre = (String)row["nombre"]                
            };

            if (!(row["descripcion"] is DBNull))
                categoria.Descripcion = (String)row["descripcion"];
            if(!(row["sexo"] is DBNull))
            {
                categoria.Sexo = row["sexo"].ToString();
            }
            return categoria;
        }

        private DataRow DataRowCategoria(DataTable dt, Categoria categoria)
        {
            var row = dt.NewRow();

            row["id"] = categoria.Id;
            row["nombre"] = categoria.Nombre;
            row["sexo"] = categoria.Sexo;
            row["descripcion"] = categoria.Descripcion;
            
            return row;
        }
    }
}
