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
    public class InseminacionAdaptadorBaseDeDatos : IAdaptador<Inseminacion>
    {
        private BaseDeDatos bd;
        private static Lista<Inseminacion> _InseminacionLista;

        public InseminacionAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Lista<Inseminacion> GetAll()
        {
            if (_InseminacionLista == null)
            {
                var dt = bd.GetAll(typeof(Inseminacion).Name.ToString(), "id, fecha, padre_id, madre_id, observaciones");

                var items = new List<Inseminacion>();

                foreach (DataRow row in dt.Rows)
                {
                    var inseminacion = DataRowInseminacion(row);

                    items.Add(inseminacion);
                }

                _InseminacionLista = new Lista<Inseminacion>(items.ToArray());
            }

            return _InseminacionLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Inseminacion).Name.ToString(), "id, fecha, padre_id, madre_id, observaciones");

            var keys = new DataColumn[1];

            keys[0] = dt.Columns["id"];
            dt.PrimaryKey = keys;

            foreach(var inseminacion in _InseminacionLista )
            {
                var row = DataRowInseminacion(inseminacion,dt);
                
                if (dt.Rows.Contains(row["id"]))
                {
                    bd.UpdateData(dt, row, "inseminacion");
                }
                else
                {
                    bd.SetData(dt, row, "inseminacion");
                }
            }
        }

        private Inseminacion DataRowInseminacion(DataRow row)
        {
            var inseminacion = new Inseminacion()
            {
                Id = (Int32)row["id"],
                Fecha = (DateTime)row["fecha"]
            };

            var servicio = Ganado.Servicios.FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio();
            var lista_ganado = servicio.GetAll();

            if (!(row["padre_id"] is DBNull))
            {
                var padre = lista_ganado.FirstOrDefault(b => b.Id.Equals((Int32)row["padre_id"]));

                if (padre != null)
                {
                    inseminacion.Padre = padre;
                }
            }

            if (!(row["madre_id"] is DBNull))
            {
                var madre = lista_ganado.FirstOrDefault(b => b.Id.Equals((Int32)row["madre_id"]));

                if (madre != null)
                {
                    inseminacion.Bovino = madre;
                }
            }

            if (!(row["observaciones"] is DBNull))
            {
                inseminacion.Observaciones = (String)row["observaciones"];
            }

            return inseminacion;
        }

        private DataRow DataRowInseminacion(Inseminacion inseminacion, DataTable dt)
        {
            var row = dt.NewRow();
            
            row["id"] = inseminacion.Id;

            row["fecha"] = inseminacion.Fecha;

            if (!(inseminacion.Padre == null))
            {
                row["padre_id"] = inseminacion.Padre.Id;
            }

            if (!(inseminacion.Bovino == null))
            {
                row["madre_id"] = inseminacion.Bovino.Id;
            }

            row["observaciones"] = inseminacion.Observaciones;

            return row;
        }

    }
}
