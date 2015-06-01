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
    public class VacunaAdaptadorBaseDeDatos : IAdaptador<Vacuna>
    {
        private BaseDeDatos bd;
        private static Lista<Vacuna> _VacunaLista;

        public VacunaAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Lista<Vacuna> GetAll()
        {
            if (_VacunaLista == null)
            {
                var dt = bd.GetAll(typeof(Vacuna).Name.ToString(), "id, fecha, bovino_id, nombre, dosis");

                var items = new List<Vacuna>();

                foreach (DataRow row in dt.Rows)
                {
                    var vacuna = DataRowVacuna(row);

                    items.Add(vacuna);
                }

                _VacunaLista = new Lista<Vacuna>(items.ToArray());
            }

            return _VacunaLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Vacuna).Name.ToString(), "id, fecha, bovino_id, nombre, dosis");

            var keys = new DataColumn[1];

            keys[0] = dt.Columns["id"];
            dt.PrimaryKey = keys;

            foreach(var vacuna in _VacunaLista )
            {
                var row = DataRowVacuna(vacuna,dt);
                
                if (dt.Rows.Contains(row["id"]))
                {
                    bd.UpdateData(dt, row, "vacuna");
                }
                else
                {
                    bd.SetData(dt, row, "vacuna");
                }
            }
        }

        private Vacuna DataRowVacuna(DataRow row)
        {
            var vacuna = new Vacuna()
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
                    vacuna.Bovino = bovino;
                }
            }

            if (!(row["nombre"] is DBNull))
            {
                vacuna.Nombre = (String)row["nombre"];
            }

            if (!(row["dosis"] is DBNull))
            {
                vacuna.Dosis = (Decimal)row["dosis"];
            }

            return vacuna;
        }

        private DataRow DataRowVacuna(Vacuna vacuna, DataTable dt)
        {
            var row = dt.NewRow();
            
            row["id"] = vacuna.Id;

            row["fecha"] = vacuna.Fecha;

            row["nombre"] = vacuna.Nombre;

            row["dosis"] = vacuna.Dosis;

            if (!(vacuna.Bovino == null))
            {
                row["bovino_id"] = vacuna.Bovino.Id;
            }
            
            return row;
        }

    }
}
