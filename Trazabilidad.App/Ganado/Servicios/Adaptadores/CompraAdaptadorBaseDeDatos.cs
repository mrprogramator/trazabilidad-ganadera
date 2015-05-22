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
    public class CompraAdaptadorBaseDeDatos : ICompraAdaptador
    {
        private BaseDeDatos bd;

        public CompraAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Compra GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "compra",
                "id, bovino_id, fecha, observaciones, precio");

            var item = DataRowCompra(row);

            return item;
        }

        public CompraLista GetAll()
        {
            var dt = bd.GetAll("compra",
                "id, bovino_id, fecha, observaciones, precio");

            var items = new List<Compra>();

            foreach (DataRow row in dt.Rows)
            {
                var compra = DataRowCompra(row);

                items.Add(compra);
            }

            var lista = new CompraLista(items.ToArray());

            return lista;
        }

        public void setData(String[] Data)
        {
        }

        private Compra DataRowCompra(DataRow row)
        {
            var compra = new Compra()
            {
                Id = (Int32)row["id"],
                Fecha = (DateTime)row["fecha"],
                Precio = (Double)row["precio"],
            };

            compra.Bovino = new Bovino()
            {
                Id = (Int32)row["bovino_id"]
            };
            
            if (!(row["observaciones"] is DBNull))
                compra.Observaciones = (String)row["observaciones"];
            
            return compra;
        }
    }
}
