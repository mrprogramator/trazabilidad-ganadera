using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Salidas.Muertes.Dominio;
using Trazabilidad.App.Salidas.Muertes.Servicios.Interfaces;
using Trazabilidad.App.Salidas.Muertes.Servicios.Listas;
using System.Data;

namespace Trazabilidad.App.Salidas.Muertes.Servicios.Adaptadores
{
    public class BovinoMuertoAdaptadorBaseDeDatos : IBovinoMuertoAdaptador
    {
        private BaseDeDatos bd;
        public static BovinoMuertoLista _BovinoMuertoLista;

        public BovinoMuertoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;            
        }

        public BovinoMuerto GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "muerte",
                "id, fecha, destino, observaciones, causa, bovino_id");

            var item = DataRowBovinoMuerto(row);

            return item;
        }

        public BovinoMuertoLista GetAll()
        {
            if (_BovinoMuertoLista == null)
            {
                var dt = bd.GetAll("muerte",
                "id, fecha, destino, observaciones, causa, bovino_id");

                var items = new List<BovinoMuerto>();

                foreach (DataRow row in dt.Rows)
                {
                    var muerte = DataRowBovinoMuerto(row);

                    items.Add(muerte);
                }

                _BovinoMuertoLista = new BovinoMuertoLista(items.ToArray());
            }

            return _BovinoMuertoLista;
        }

        public void setData(String[] Data)
        { 
        }

        private BovinoMuerto DataRowBovinoMuerto(DataRow row)
        {
            var servicio_bovino = Ganado.Servicios.FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
            var lista_bovino = servicio_bovino.GetAll();

            var bovino_cat = lista_bovino.Find(x => x.Id.Equals( (Int32)row["bovino_id"]) );
            
            var muerte = new Muerte()
            {
                Id = (Int32)row["id"]
            };

            if (!(row["fecha"] is DBNull))
                muerte.Fecha = (DateTime)row["fecha"];

			if (!(row["destino"] is DBNull))
                muerte.Destino = (String)row["destino"];
            
            if (!(row["causa"] is DBNull))
                muerte.Causa = (String)row["causa"];

            var bovino_muerto = new BovinoMuerto(bovino_cat, muerte);
            
            return bovino_muerto;            
        }
    }
}
