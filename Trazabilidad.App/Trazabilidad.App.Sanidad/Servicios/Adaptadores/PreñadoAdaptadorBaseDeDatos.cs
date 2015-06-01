using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Sanidad.Dominio;
using Trazabilidad.App.Ganado.Dominio;
using System.Data;

namespace Trazabilidad.App.Sanidad.Servicios
{
    public class PreñadoAdaptadorBaseDeDatos : IAdaptador<Preñado>
    {
        private BaseDeDatos bd;
        private static Lista<Preñado> _PreñadoLista;

        public PreñadoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Lista<Preñado> GetAll()
        {
            if (_PreñadoLista == null)
            {
                var dt = bd.GetAll(typeof(Preñado).Name.ToString(), "id, fecha, bovino_id, observaciones");

                var items = new List<Preñado>();

                foreach (DataRow row in dt.Rows)
                {
                    var preñado = DataRowPreñado(row);

                    items.Add(preñado);
                }

                _PreñadoLista = new Lista<Preñado>(items.ToArray());
            }

            return _PreñadoLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Preñado).Name.ToString(), "id, fecha, bovino_id, observaciones");

            var keys = new DataColumn[1];

            keys[0] = dt.Columns["id"];
            dt.PrimaryKey = keys;

            foreach(var preñado in _PreñadoLista )
            {
                var row = DataRowPreñado(preñado,dt);
                
                if (dt.Rows.Contains(row["id"]))
                {
                    bd.UpdateData(dt, row, "preñado");
                }
                else
                {
                    bd.SetData(dt, row, "preñado");
                }
            }
        }

        private Preñado DataRowPreñado(DataRow row)
        {
            var preñado = new Preñado()
            {
                Id = (Int32)row["id"],
                Fecha = (DateTime)row["fecha"]
            };

            var servicio = Ganado.Servicios.FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio();
            var lista_ganado = servicio.GetAll();

            if (!(row["bovino_id"] is DBNull))
            {
                var bovino = lista_ganado.FirstOrDefault(b => b.Id.Equals((Int32)row["bovino_id"]));

                if (bovino != null)
                {
                    preñado.Bovino = bovino;
                }
            }

            if (!(row["observaciones"] is DBNull))
            {
                preñado.Observaciones = (String)row["observaciones"];
            }

            return preñado;
        }

        private DataRow DataRowPreñado(Preñado preñado, DataTable dt)
        {
            var row = dt.NewRow();
            
            row["id"] = preñado.Id;

            row["fecha"] = preñado.Fecha;

            row["observaciones"] = preñado.Observaciones;

            if (!(preñado.Bovino == null))
            {
                row["bovino_id"] = preñado.Bovino.Id;
            }
            
            return row;
        }

    }
}
