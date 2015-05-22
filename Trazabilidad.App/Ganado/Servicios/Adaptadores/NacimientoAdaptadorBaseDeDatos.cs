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
    public class NacimientoAdaptadorBaseDeDatos : INacimientoAdaptador
    {
        private BaseDeDatos bd;

        public NacimientoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Nacimiento GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "nacimiento",
                "id, bovino_id, fecha, observaciones, parto_id");

            var item = DataRowNacimiento(row);

            return item;
        }

        public NacimientoLista GetAll()
        {
            var dt = bd.GetAll("nacimiento",
                "id, bovino_id, fecha, observaciones, parto_id");

            var items = new List<Nacimiento>();

            foreach (DataRow row in dt.Rows)
            {
                var nacimiento = DataRowNacimiento(row);

                items.Add(nacimiento);
            }

            var lista = new NacimientoLista(items.ToArray());

            return lista;
        }

        public void setData(String[] Data)
        { 
        }

        private Nacimiento DataRowNacimiento(DataRow row)
        {
            var nacimiento = new Nacimiento()
            {
                Id = (Int32)row["id"]                
            };
            
            nacimiento.Bovino = new Bovino()
            { 
                Id = (Int32)row["bovino_id"] 
            };

            if (!(row["fecha"] is DBNull))
                nacimiento.Fecha = (DateTime)row["fecha"];

            if (!(row["observaciones"] is DBNull))
                nacimiento.Observaciones = (String)row["observaciones"];
            
            
            return nacimiento;            
        }
    }
}
