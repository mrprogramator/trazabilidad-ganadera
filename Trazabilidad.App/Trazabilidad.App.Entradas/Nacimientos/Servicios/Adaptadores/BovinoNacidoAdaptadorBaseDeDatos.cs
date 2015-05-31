using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Entradas.Nacimientos.Dominio;
using Trazabilidad.App.Entradas.Nacimientos.Servicios.Interfaces;
using Trazabilidad.App.Entradas.Nacimientos.Servicios.Listas;
using System.Data;

namespace Trazabilidad.App.Entradas.Nacimientos.Servicios.Adaptadores
{
    public class BovinoNacidoAdaptadorBaseDeDatos : IBovinoNacidoAdaptador
    {
        private BaseDeDatos bd;
        private static BovinoNacidoLista _BovinoNacidoLista;

        public BovinoNacidoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;            
        }
        
        public BovinoNacidoLista GetAll()
        {
            if (_BovinoNacidoLista == null)
            {
                var dt = bd.GetAll("nacimiento",
                "id, bovino_id, fecha, observaciones, parto_id");

                var items = new List<BovinoNacido>();

                foreach (DataRow row in dt.Rows)
                {
                    var nacimiento = DataRowNacimiento(row);

                    items.Add(nacimiento);
                }

                _BovinoNacidoLista = new BovinoNacidoLista(items.ToArray());
            }

            return _BovinoNacidoLista;
        }

        public void setData(String[] Data)
        { 
        }

        private BovinoNacido DataRowNacimiento(DataRow row)
        {
            var servicio_bovino = Ganado.Servicios.FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
            var lista_bovino = servicio_bovino.GetAll();

            var bovino_cat = lista_bovino.Find(x => x.Id.Equals((Int32)row["bovino_id"]));            

            var nacimiento = new Nacimiento()
            {
                Id = (Int32)row["id"]
            };

            if (!(row["fecha"] is DBNull))
                nacimiento.Fecha = (DateTime)row["fecha"];

            if (!(row["observaciones"] is DBNull))
                nacimiento.Observaciones = (String)row["observaciones"];

            BovinoNacido bovino_nacido = new BovinoNacido(bovino_cat,nacimiento);
            
            return bovino_nacido;            
        }
    }
}
