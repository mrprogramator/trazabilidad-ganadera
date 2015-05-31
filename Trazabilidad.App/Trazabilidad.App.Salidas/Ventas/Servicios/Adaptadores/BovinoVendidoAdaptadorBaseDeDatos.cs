using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Salidas.Ventas.Dominio;
using Trazabilidad.App.Salidas.Ventas.Servicios.Interfaces;
using Trazabilidad.App.Salidas.Ventas.Servicios.Listas;
using System.Data;

namespace Trazabilidad.App.Salidas.Ventas.Servicios.Adaptadores
{
    public class BovinoVendidoAdaptadorBaseDeDatos : IBovinoVendidoAdaptador
    {
        private BaseDeDatos bd;
        private static BovinoVendidoLista _BovinoVendidoLista;

        public BovinoVendidoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;            
        }

        public BovinoVendido GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "venta",
                "id, fecha, destino, observaciones, precio, bovino_id");

            var item = DataRowBovinoVendido(row);

            return item;
        }

        public BovinoVendidoLista GetAll()
        {
            if (_BovinoVendidoLista == null)
            {
                var dt = bd.GetAll("venta",
                "id, fecha, destino, observaciones, precio, bovino_id");

                var items = new List<BovinoVendido>();

                foreach (DataRow row in dt.Rows)
                {
                    var venta = DataRowBovinoVendido(row);

                    items.Add(venta);
                }

                _BovinoVendidoLista = new BovinoVendidoLista(items.ToArray());
            }

            return _BovinoVendidoLista;
        }

        public void setData(String[] Data)
        { 
        }

        private BovinoVendido DataRowBovinoVendido(DataRow row)
        {
            var servicio_bovino = Ganado.Servicios.FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
            var lista_bovino = servicio_bovino.GetAll();

            var bovino_cat = lista_bovino.Find(x => x.Id.Equals((Int32)row["bovino_id"]));

            var venta = new Venta()
            {
                Id = (Int32)row["id"]
            };

            if (!(row["fecha"] is DBNull))
                venta.Fecha = (DateTime)row["fecha"];
            
            if (!(row["destino"] is DBNull))
                venta.Destino = (String)row["destino"];
            
			if (!(row["precio"] is DBNull))
                venta.Precio = (Double)row["precio"];

            var bovino_muerto = new BovinoVendido(bovino_cat, venta);

            return bovino_muerto;            
        }
    }
}
