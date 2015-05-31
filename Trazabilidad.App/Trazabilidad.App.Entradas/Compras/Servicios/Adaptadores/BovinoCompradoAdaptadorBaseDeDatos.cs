using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Entradas.Compras.Dominio;
using Trazabilidad.App.Entradas.Compras.Servicios.Interfaces;
using Trazabilidad.App.Entradas.Compras.Servicios.Listas;
using System.Data;

namespace Trazabilidad.App.Entradas.Compras.Servicios.Adaptadores
{
    public class BovinoCompradoAdaptadorBaseDeDatos : IBovinoCompradoAdaptador
    {
        private BaseDeDatos bd;
        private static BovinoCompradoLista _BovinoCompradoLista;

        public BovinoCompradoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;            
        }
                
        public BovinoCompradoLista GetAll()
        {
            if (_BovinoCompradoLista == null)
            {
                var dt = bd.GetAll("compra",
                "id, bovino_id, fecha, observaciones, precio");

                var items = new List<BovinoComprado>();

                foreach (DataRow row in dt.Rows)
                {
                    var compra = DataRowBovinoComprado(row);

                    items.Add(compra);
                }

                _BovinoCompradoLista = new BovinoCompradoLista(items.ToArray());
            }

            return _BovinoCompradoLista;
        }

        public void setData(String[] Data)
        {
        }

        BovinoComprado DataRowBovinoComprado(DataRow row)
        {
            var servicio_bovino = Ganado.Servicios.FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
            var lista_bovino = servicio_bovino.GetAll();

            var bovino_cat = lista_bovino.Find(x => x.Id.Equals((Int32)row["bovino_id"]));
            
            var compra = new Compra()
            {
                Id = (Int32)row["id"],
                Fecha = (DateTime)row["fecha"],
                Precio = (Double)row["precio"],
            };
            
            if (!(row["observaciones"] is DBNull))
                compra.Observaciones = (String)row["observaciones"];
            
            BovinoComprado bovino_comprado = new BovinoComprado(bovino_cat,compra);
                        
            return bovino_comprado;
        }
    }
}
