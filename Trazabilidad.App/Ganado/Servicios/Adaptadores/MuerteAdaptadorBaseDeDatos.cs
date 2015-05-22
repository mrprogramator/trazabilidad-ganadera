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
    public class MuerteAdaptadorBaseDeDatos : IMuerteAdaptador
    {
        private BaseDeDatos bd;

        public MuerteAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Muerte GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "muerte",
                "id, fecha, destino, observaciones, causa, bovino_id");

            var item = DataRowMuerte(row);

            return item;
        }

        public MuerteLista GetAll()
        {
            var dt = bd.GetAll("muerte",
                "id, fecha, destino, observaciones, causa, bovino_id");

            var items = new List<Muerte>();

            foreach (DataRow row in dt.Rows)
            {
                var muerte = DataRowMuerte(row);

                items.Add(muerte);
            }

            var lista = new MuerteLista(items.ToArray());

            return lista;
        }

        public void setData(String[] Data)
        { 
        }

        private Muerte DataRowMuerte(DataRow row)
        {
            var muerte = new Muerte()
            {
                Id = (Int32)row["id"]
            };

            muerte.Bovino = new Bovino()
            {
                Id = (Int32)row["bovino_id"]
            };

            if (!(row["fecha"] is DBNull))
                muerte.Fecha = (DateTime)row["fecha"];

			if (!(row["destino"] is DBNull))
                muerte.Destino = (String)row["destino"];
            
			if (!(row["observaciones"] is DBNull))
                muerte.Observaciones = (String)row["observaciones"];
				
			if (!(row["causa"] is DBNull))
                muerte.Causa = (String)row["causa"];
            
            return muerte;            
        }
    }
}
