using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Ganado.Servicios.Listas;
using Trazabilidad.App.Ganado.Servicios.Interfaces;

using System.Data;

namespace Trazabilidad.App.Ganado.Servicios.Adaptadores
{
    public class TrazaAdaptadorBaseDeDatos : IAdaptador<Traza>
    {
        private BaseDeDatos bd;
        private static Lista<Traza> _TrazaLista;

        public TrazaAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }
        public Lista<Traza> GetAll()
        {
            if (_TrazaLista == null)
            {
                Generate();
            }

            return _TrazaLista;
        }

        public Lista<Traza> Generate()
        {
            var dt = bd.GetAll(typeof(Traza).Name.ToString(), "id, fecha, bovino_id, categoria_id");

            var items = new List<Traza>();

            foreach (DataRow row in dt.Rows)
            {
                var Traza = DataRowTraza(row);

                items.Add(Traza);
            }

            _TrazaLista = new Lista<Traza>(items.ToArray());

            return _TrazaLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Traza).Name.ToString(), "id, fecha, bovino_id, categoria_id");

            var keys = new DataColumn[1];
            keys[0] = dt.Columns["id"];
            dt.PrimaryKey = keys;


            foreach (var traza in _TrazaLista)
            {
                var row = DataRowTraza(traza,dt);
                
                if (dt.Rows.Contains(row["id"]))
                {
                    //bd.UpdateData(dt, row, "bovino");
                }
                else
                {
                    bd.SetData(dt, row, "traza");
                }              
            }
        }

        private Traza DataRowTraza(DataRow row)
        {
            var traza = new Traza()
            {
                Id = (Int32)row["id"],
                Fecha = (DateTime)row["fecha"]
            };

            var bovino = new Bovino();

            bovino.Id = (Int32)row["bovino_id"];

            var servicio_cat = Categorias.Servicios.FactoriaServiciosLocales.GetInstance().GetServicioCategoria();

            var lista_cat = servicio_cat.GetAll();

            bovino.Categoria = lista_cat.Find(x => x.Id.Equals((Int32)row["categoria_id"]));

            traza.Bovino = bovino;

            return traza;
        }

        private DataRow DataRowTraza(Traza traza, DataTable dt)
        {
            var row = dt.NewRow();

            row["id"] = traza.Id;

            row["fecha"] = traza.Fecha;

            row["bovino_id"] = traza.Bovino.Id;

            row["Categoria_id"] = traza.Bovino.Categoria.Id;

            return row;
        }



    }
}
