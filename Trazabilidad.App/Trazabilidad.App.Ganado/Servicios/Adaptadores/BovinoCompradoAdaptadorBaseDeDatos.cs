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
    public class BovinoCompradoAdaptadorBaseDeDatos : IAdaptador<BovinoComprado>
    {
        private BaseDeDatos bd;
        private static Lista<BovinoComprado> _BovinoCompradoLista;

        public BovinoCompradoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Lista<BovinoComprado> GetAll()
        {
            if (_BovinoCompradoLista == null)
            {
                var dt = bd.GetAll(typeof(Compra).Name.ToString(), "id, bovino_id, fecha, observaciones, precio");

                var items = new List<BovinoComprado>();

                foreach (DataRow row in dt.Rows)
                {
                    var bovino = DataRowGanado(row);

                    if (bovino == null) continue;
                    
                    items.Add(bovino);
                    
                }

                _BovinoCompradoLista = new Lista<BovinoComprado>(items.ToArray());
            }

            return _BovinoCompradoLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Bovino).Name, "id, categoria_id, padre_id, madre_id, entrada, salida");

            var dt_compra = bd.GetAll(typeof(Compra).Name, "id, bovino_id, fecha, observaciones, precio");
            var keys = new DataColumn[1];

            keys[0] = dt.Columns["id"];
            dt.PrimaryKey = keys;

            keys[0] = dt_compra.Columns["id"];
            dt_compra.PrimaryKey = keys;

            foreach (var bovino in _BovinoCompradoLista)
            {
                var row = DataRowGanado(dt, bovino);

                if (dt.Rows.Contains(row["id"]))
                {
                    bd.UpdateData(dt, row, "bovino");
                }
                else
                {
                    bd.SetData(dt, row, "bovino");
                }

                var row_compra = DataRowCompra(dt_compra, bovino);

                if (dt_compra.Rows.Contains(row_compra["id"]))
                {
                    bd.UpdateData(dt_compra, row_compra, "compra");
                }
                else
                {
                    bd.SetData(dt_compra, row_compra, "compra");
                }
            }
        }
        
        private BovinoComprado DataRowGanado(DataRow row)
        {
            var servicio_bovino = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio();
            var bovino_lista = servicio_bovino.GetAll();

            if (bovino_lista.Exists(b => b.Id.Equals((Int32)row["bovino_id"])))
            {
                var bovino_nacido = bovino_lista.Find(b => b.Id.Equals((Int32)row["bovino_id"]));
                var bovino_comprado = new BovinoComprado() 
                {
                    Id = bovino_nacido.Id,
                    Categoria = bovino_nacido.Categoria                  
                };

                if (bovino_nacido.Madre != null)
                {
                    bovino_comprado.Madre = bovino_nacido.Madre;
                }

                if (bovino_nacido.Padre != null)
                {
                    bovino_comprado.Padre = bovino_nacido.Padre;
                }

                bovino_comprado.Compra = new Compra() 
                {
                    Id = (Int32)row["id"],
                    Fecha = (DateTime)row["fecha"],
                    Precio = (Decimal)row["precio"]
                };

                if (row["observaciones"] != null)
                {
                    bovino_comprado.Compra.Observaciones = (String)row["observaciones"];
                }
               
                return bovino_comprado;
            }

            return null;
        }

        private DataRow DataRowGanado(DataTable dt,BovinoComprado bovinoComprado)
        {
            var row = dt.NewRow();
            
            if (bovinoComprado != null)
            {
                row["id"] = bovinoComprado.Id;
                row["categoria_id"] = bovinoComprado.Categoria.Id;
               

                if (bovinoComprado.Madre != null)
                {
                    row["madre_id"] = bovinoComprado.Madre.Id;
                }

                if (bovinoComprado.Padre != null)
                {
                    row["padre_id"] = bovinoComprado.Padre.Id;
                }

                row["entrada"] = bovinoComprado.Compra.Fecha;

                return row;
            }

            return null;
        }

        private DataRow DataRowCompra(DataTable dt_compra, BovinoComprado bovinoComprado)
        {
            var row = dt_compra.NewRow();
            
            if (bovinoComprado != null)
            {
                row["id"] = bovinoComprado.Compra.Id;
                row["fecha"] = bovinoComprado.Compra.Fecha;
                row["precio"] = bovinoComprado.Compra.Precio;
                row["bovino_id"] = bovinoComprado.Id;
                
                if (bovinoComprado.Compra.Observaciones != null)
                {
                    row["observaciones"] = bovinoComprado.Compra.Observaciones ;
                }
                                
                return row;
            }

            return null;
        }
    }
}
