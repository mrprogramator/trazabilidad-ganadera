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
using Trazabilidad.App.Categorias.Servicios;

namespace Trazabilidad.App.Ganado.Servicios.Adaptadores
{
    public class BovinoAdaptadorBaseDeDatos : IAdaptador<Bovino>
    {
        private BaseDeDatos bd;
        private static Lista<Bovino> _BovinoLista;

        public BovinoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }
        public Lista<Bovino> Generate()
        {
            return _BovinoLista;
        }

        public Lista<Bovino> GetAll()
        {
            if (_BovinoLista == null)
            {
                var dt = bd.GetAll(typeof(Bovino).Name.ToString(), "id, categoria_id, padre_id, madre_id, entrada, salida");

                var items = new List<Bovino>();

                foreach (DataRow row in dt.Rows)
                {
                    var bovino = DataRowGanado(row);

                    items.Add(bovino);
                }

                _BovinoLista = new Lista<Bovino>(items.ToArray());
            }

            return _BovinoLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Bovino).Name.ToString(), "id, categoria_id, padre_id, madre_id, entrada, salida");

            foreach(var bovino in _BovinoLista )
            {
                var row = DataRowGanado(bovino,dt);
                dt.Rows.Add(row);
            }
        }

        private Bovino DataRowGanado(DataRow row)
        {
            var bovino = new Bovino()
            {
                Id = (Int32)row["id"]
            };

            if (!(row["padre_id"] is DBNull))
            {
                bovino.Padre = new Bovino()
                {
                    Id = (Int32)row["padre_id"],
                    Categoria = new Categorias.Dominio.Categoria() { Sexo = "Macho" }
                };
            }

            if (!(row["madre_id"] is DBNull))
            {
                bovino.Madre = new Bovino()
                {
                    Id = (Int32)row["madre_id"],
                    Categoria = new Categorias.Dominio.Categoria() { Sexo = "Hembra" }
                };
            }

            var servicio_cat = Categorias.Servicios.FactoriaServiciosLocales.GetInstance().GetServicioCategoria();

            var lista_cat = servicio_cat.GetAll();

            bovino.Categoria = lista_cat.Find(x => x.Id.Equals((Int32)row["categoria_id"]));

            return bovino;
        }

        private DataRow DataRowGanado(Bovino bovino, DataTable dt)
        {
            var row = dt.NewRow();
            
            row["id"] = bovino.Id;


            if (!(bovino.Padre == null))
            {
                row["padre_id"] = bovino.Padre.Id;
            }

            if (!(bovino.Madre == null))
            {
                row["madre_id"] = bovino.Madre.Id;
            }

            row["categoria_id"] = bovino.Categoria.Id;

            return row;
        }

    }
}
