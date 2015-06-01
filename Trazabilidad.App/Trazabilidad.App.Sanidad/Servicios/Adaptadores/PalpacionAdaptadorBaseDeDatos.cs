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
    public class PalpacionAdaptadorBaseDeDatos : IAdaptador<Palpacion>
    {
        private BaseDeDatos bd;
        private static Lista<Palpacion> _PalpacionLista;

        public PalpacionAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Lista<Palpacion> GetAll()
        {
            if (_PalpacionLista == null)
            {
                var dt = bd.GetAll(typeof(Palpacion).Name.ToString(), "id, fecha, numero, mes_gestacion, estado, bovino_id");

                var items = new List<Palpacion>();

                foreach (DataRow row in dt.Rows)
                {
                    var palpacion = DataRowPalpacion(row);

                    items.Add(palpacion);
                }

                _PalpacionLista = new Lista<Palpacion>(items.ToArray());
            }

            return _PalpacionLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Palpacion).Name.ToString(), "id, fecha, numero, mes_gestacion, estado, bovino_id");

            var keys = new DataColumn[1];

            keys[0] = dt.Columns["id"];
            dt.PrimaryKey = keys;

            foreach(var palpacion in _PalpacionLista )
            {
                var row = DataRowPalpacion(palpacion,dt);
                
                if (dt.Rows.Contains(row["id"]))
                {
                    bd.UpdateData(dt, row, "palpacion");
                }
                else
                {
                    bd.SetData(dt, row, "palpacion");
                }
            }
        }

        private Palpacion DataRowPalpacion(DataRow row)
        {
            var palpacion = new Palpacion()
            {
                Id = (Int32)row["id"],
                Fecha = (DateTime)row["fecha"],
                Estado = (Boolean)row["estado"]
            };

            var servicio = Ganado.Servicios.FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio();
            var lista_ganado = servicio.GetAll();

            if (!(row["bovino_id"] is DBNull))
            {
                var bovino = lista_ganado.FirstOrDefault(b => b.Id.Equals((Int32)row["bovino_id"]));

                if (bovino != null)
                {
                    palpacion.Bovino = bovino;
                }
            }

            if (!(row["numero"] is DBNull))
            {
                palpacion.Numero = (Int32)row["numero"];
            }

            if (!(row["mes_gestacion"] is DBNull))
            {
                palpacion.MesGestacion = (Int32)row["mes_gestacion"];
            }

            return palpacion;
        }

        private DataRow DataRowPalpacion(Palpacion palpacion, DataTable dt)
        {
            var row = dt.NewRow();
            
            row["id"] = palpacion.Id;

            row["fecha"] = palpacion.Fecha;

            row["numero"] = palpacion.Numero;
            
            row["mes_gestacion"] = palpacion.MesGestacion;

            row["estado"] = palpacion.Estado;

            if (!(palpacion.Bovino == null))
            {
                row["bovino_id"] = palpacion.Bovino.Id;
            }
            
            return row;
        }

    }
}
