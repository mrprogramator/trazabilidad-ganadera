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
    public class BovinoNacidoAdaptadorBaseDeDatos : IAdaptador<BovinoNacido>
    {
        private BaseDeDatos bd;
        private static Lista<BovinoNacido> _BovinoNacidoLista;

        public BovinoNacidoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;            
        }

        public Lista<BovinoNacido> Generate()
        {
            return _BovinoNacidoLista;
        }
        
        public Lista<BovinoNacido> GetAll()
        {
            if (_BovinoNacidoLista == null)
            {
                var dt = bd.GetAll(typeof(Nacimiento).Name.ToString(), "id, bovino_id, fecha, observaciones");

                var items = new List<BovinoNacido>();

                foreach (DataRow row in dt.Rows)
                {
                    var bovino = DataRowGanado(row);

                    items.Add(bovino);
                }

                _BovinoNacidoLista = new Lista<BovinoNacido>(items.ToArray());
            }

            return _BovinoNacidoLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Bovino).Name.ToString(), "id, categoria_id, padre_id, madre_id, entrada, salida");

            var dt_nac = bd.GetAll(typeof(Nacimiento).Name.ToString(), "id, bovino_id, fecha, observaciones");
            var keys = new DataColumn[1];

            keys[0] = dt.Columns["id"];
            dt.PrimaryKey = keys;

            keys[0] = dt_nac.Columns["id"];
            

            dt_nac.PrimaryKey = keys;

            foreach (var bovino in _BovinoNacidoLista)
            {
                var row = DataRowGanado(dt,bovino);
                
                if (dt.Rows.Contains(row["id"]))
                {
                    bd.UpdateData(dt, row, "bovino");
                }
                else 
                {
                    bd.SetData(dt, row, "bovino");
                }
                
                var rowNac = DataRowNac(dt_nac,bovino);
                
                if (dt_nac.Rows.Contains(rowNac["id"]))
                {
                    bd.UpdateData(dt_nac, rowNac, "nacimiento");
                }
                else 
                {
                    bd.SetData(dt_nac, rowNac, "nacimiento");
                }
            } 
        }
        
        private BovinoNacido DataRowGanado(DataRow row)
        {
            var servicio_bovino = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio();
            var bovino_lista = servicio_bovino.GetAll();

            if (bovino_lista.Exists(b => b.Id.Equals((Int32)row["bovino_id"])))
            {
                var bovino = bovino_lista.Find(b => b.Id.Equals((Int32)row["bovino_id"]));
                var bovino_nacido = new BovinoNacido()
                {
                    Id = bovino.Id,
                    Categoria = bovino.Categoria
                };

                if (bovino.Madre != null && bovino_lista.Exists(b => b.Id.Equals(bovino.Madre.Id)))
                {
                    bovino_nacido.Madre = bovino_lista.Find(b => b.Id.Equals(bovino.Madre.Id));
                }

                if (bovino.Padre != null && bovino_lista.Exists(b => b.Id.Equals(bovino.Padre.Id)))
                {
                    bovino_nacido.Padre = bovino_lista.Find(b => b.Id.Equals(bovino.Padre.Id));
                }

                bovino_nacido.Nacimiento = new Nacimiento()
                {
                    Id = (Int32)row["id"],
                    Fecha = (DateTime)row["fecha"]                    
                };

                if (!(row["observaciones"] is DBNull))
                {
                    bovino_nacido.Nacimiento.Observaciones = (String)row["observaciones"];
                }
                                
                return bovino_nacido;
            }

            return null;
        }

        private DataRow DataRowGanado(DataTable dt, BovinoNacido bovino)
        {
            var row = dt.NewRow();

            row["id"] = bovino.Id;
            row["padre_id"] = bovino.Padre.Id;
            row["madre_id"] = bovino.Madre.Id;
            row["categoria_id"] = bovino.Categoria.Id;
            var fecha = new StringBuilder();
            var nac = bovino.Nacimiento.Fecha;
            fecha.AppendFormat("{0}-{1}-{2}",nac.Year,nac.Month,nac.Day);
            row["entrada"] = nac.ToShortDateString();

            return row;
        }

        private DataRow DataRowNac(DataTable dt, BovinoNacido bovino)
        {
            var row = dt.NewRow();

            row["id"] = bovino.Nacimiento.Id;
            
            row["bovino_id"] = bovino.Id;

            if(bovino.Nacimiento.Observaciones != null)
                row["observaciones"] = bovino.Nacimiento.Observaciones;

            var fecha = new StringBuilder();
            var nac = bovino.Nacimiento.Fecha;
            fecha.AppendFormat("{0}-{1}-{2}", nac.Year, nac.Month, nac.Day);
            row["fecha"] = nac.ToShortDateString();

            return row;
        }
    }
}
