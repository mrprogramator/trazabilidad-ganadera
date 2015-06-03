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
using Trazabilidad.App.Categorias.Servicios;

namespace Trazabilidad.App.Ganado.Servicios.Adaptadores
{
    public class BovinoVendidoAdaptadorBaseDeDatos : IAdaptador<BovinoVendido>
    {
        private BaseDeDatos bd;
        private static Lista<BovinoVendido> _BovinoVendidoLista;

        public BovinoVendidoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Lista<BovinoVendido> Generate()
        {
            return _BovinoVendidoLista;
        }

        public Lista<BovinoVendido> GetAll()
        {
            if (_BovinoVendidoLista == null)
            {
                var dt = bd.GetAll(typeof(Venta).Name.ToString(), "id, bovino_id, fecha, destino, precio, observaciones");

                var items = new List<BovinoVendido>();

                foreach (DataRow row in dt.Rows)
                {
                    var bovino = DataRowGanado(row);

                    if (bovino == null) continue;

                    items.Add(bovino);

                }

                _BovinoVendidoLista = new Lista<BovinoVendido>(items.ToArray());
            }

            return _BovinoVendidoLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Bovino).Name, "id, categoria_id, padre_id, madre_id, entrada, salida");

            var dt_venta = bd.GetAll(typeof(Venta).Name, "id, bovino_id, fecha, destino, precio, observaciones");

            var keys = new DataColumn[1];

            keys[0] = dt.Columns["id"];
            dt.PrimaryKey = keys;

            keys[0] = dt_venta.Columns["id"];
            dt_venta.PrimaryKey = keys;

            foreach (var bovino in _BovinoVendidoLista)
            {
                var row = DataRowGanado(dt, bovino);

                if (dt.Rows.Contains(row["id"]))
                {
                    bd.UpdateData(dt, row, "bovino");
                }
                else
                {
                    throw new Exception("No existe registro de entrada del bovino vendido.");
                }

                var row_venta = DataRowVenta(dt_venta, bovino);

                if (dt_venta.Rows.Contains(row_venta["id"]))
                {
                    bd.UpdateData(dt_venta, row_venta, "venta");
                }
                else
                {
                    bd.SetData(dt_venta, row_venta, "venta");
                }
            }
        }

        private BovinoVendido DataRowGanado(DataRow row)
        {
            var bovino_vendido = new BovinoVendido();

            var servicio_bovino_nacido = FactoriaServiciosLocales<BovinoNacido>.GetInstance().GetServicio();
            var bovino_nacido_lista = servicio_bovino_nacido.GetAll();

            if (bovino_nacido_lista.Exists(b => b.Id.Equals((Int32)row["bovino_id"])))
            {
                var bovino_nacido = bovino_nacido_lista.Find(b => b.Id.Equals((Int32)row["bovino_id"]));

                bovino_vendido = new BovinoVendido()
                {
                    Id = bovino_nacido.Id,
                    Categoria = bovino_nacido.Categoria,
                    Padre = bovino_nacido.Padre,
                    Madre = bovino_nacido.Madre
                };

                var venta = new Venta()
                {
                    Id = (Int32)row["id"],
                    Fecha = (DateTime)row["fecha"]
                };

                if (!(row["destino"] is DBNull))
                {
                    venta.Destino = (String)row["destino"];
                }

                if (!(row["precio"] is DBNull))
                {
                    venta.Precio = (Decimal)row["precio"];
                }

                if (!(row["observaciones"] is DBNull))
                {
                    venta.Observaciones = (String)row["observaciones"];
                }
                
                bovino_vendido.Venta = venta;

                bovino_nacido_lista.Remove(bovino_nacido);

            }
            else
            {
                var servicio_bovino_comprado = FactoriaServiciosLocales<BovinoComprado>.GetInstance().GetServicio();
                var bovino_comprado_lista = servicio_bovino_comprado.GetAll();

                if (bovino_comprado_lista.Exists(b => b.Id.Equals((Int32)row["bovino_id"])))
                {
                    var bovino_comprado = bovino_comprado_lista.Find(b => b.Id.Equals((Int32)row["bovino_id"]));

                    bovino_vendido = new BovinoVendido()
                    {
                        Id = bovino_comprado.Id,
                        Categoria = bovino_comprado.Categoria,                        
                    };

                    var venta = new Venta()
                    {
                        Id = (Int32)row["id"],
                        Fecha = (DateTime)row["fecha"]
                    };

                    if (!(row["destino"] is DBNull))
                    {
                        venta.Destino = (String)row["destino"];
                    }

                    if (!(row["precio"] is DBNull))
                    {
                        venta.Precio = (Decimal)row["precio"];
                    }

                    bovino_comprado_lista.Remove(bovino_comprado);

                    bovino_vendido.Venta = venta;
                }
            }
            return bovino_vendido;
        }

        private DataRow DataRowGanado(DataTable dt, BovinoVendido bovinoVendido)
        {
            var row = dt.NewRow();
            row["id"] = bovinoVendido.Id;
            row["salida"] = bovinoVendido.Venta.Fecha;

            return row;
        }

        private DataRow DataRowVenta(DataTable dt_venta, BovinoVendido bovinoVendido)
        {
            var row = dt_venta.NewRow();

            row["id"] = bovinoVendido.Venta.Id;
            row["fecha"] = bovinoVendido.Venta.Fecha;
            row["bovino_id"] = bovinoVendido.Id;
            row["destino"] = bovinoVendido.Venta.Destino;
            row["observaciones"] = bovinoVendido.Venta.Observaciones;
            row["precio"] = bovinoVendido.Venta.Precio;

            return row;
        }
    }
}
