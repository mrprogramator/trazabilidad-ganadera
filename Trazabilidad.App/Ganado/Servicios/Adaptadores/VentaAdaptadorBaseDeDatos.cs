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
    public class VentaAdaptadorBaseDeDatos : IVentaAdaptador
    {
        private BaseDeDatos bd;

        public VentaAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Venta GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "venta",
                "id, fecha, destino, observaciones, precio, bovino_id");

            var item = DataRowVenta(row);

            return item;
        }

        public VentaLista GetAll()
        {
            var dt = bd.GetAll("venta",
                "id, fecha, destino, observaciones, precio, bovino_id");

            var items = new List<Venta>();

            foreach (DataRow row in dt.Rows)
            {
                var venta = DataRowVenta(row);

                items.Add(venta);
            }

            var lista = new VentaLista(items.ToArray());

            return lista;
        }

        public void setData(String[] Data)
        { 
        }

        private Venta DataRowVenta(DataRow row)
        {
            var venta = new Venta()
            {
                Id = (Int32)row["id"]
            };

            venta.Bovino = new Bovino()
            {
                Id = (Int32)row["bovino_id"]
            };

            if (!(row["fecha"] is DBNull))
                venta.Fecha = (DateTime)row["fecha"];
            
            if (!(row["destino"] is DBNull))
                venta.Destino = (String)row["destino"];
            
			if (!(row["observaciones"] is DBNull))
                venta.Observaciones = (String)row["observaciones"];
				
			if (!(row["precio"] is DBNull))
                venta.Precio = (Double)row["precio"];
                            
            return venta;            
        }
    }
}
