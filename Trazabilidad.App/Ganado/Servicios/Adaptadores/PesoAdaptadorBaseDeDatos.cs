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
    public class PesoAdaptadorBaseDeDatos : IPesoAdaptador
    {
        private BaseDeDatos bd;

        public PesoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Peso GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "peso",
                "id, fecha, peso, bovino_id");

            var item = DataRowPeso(row);

            return item;
        }

        public PesoLista GetAll()
        {
            var dt = bd.GetAll("peso",
                "id, fecha, peso, bovino_id");

            var items = new List<Peso>();

            foreach (DataRow row in dt.Rows)
            {
                var peso = DataRowPeso(row);

                items.Add(peso);
            }

            var lista = new PesoLista(items.ToArray());

            return lista;
        }

        public void setData(String[] Data)
        { 
        }

        private Peso DataRowPeso(DataRow row)
        {
            var peso = new Peso()
            {
                Id = (Int32)row["id"],
				Valor = (Double)row["peso"]
            };

            if (!(row["fecha"] is DBNull))
                peso.Fecha = (DateTime)row["fecha"];
  
            var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioGanado();
            var lista_bovino = servicio_bovino.GetAll();
            
            peso.Bovino = lista_bovino.Find(x => x.Id == (Int32)row["bovino_id"] );
            
            return peso;            
        }
    }
}
