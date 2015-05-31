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
    public class BovinoCategorizadoAdaptadorBaseDeDatos : IBovinoCategorizadoAdaptador
    {
        private BaseDeDatos bd;
        private static BovinoCategorizadoLista _BovinoCategorizadoLista;

        public BovinoCategorizadoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;            
        }

        public BovinoCategorizado GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "bovino",
                "id, categoria_id");

            var item = DataRowGanado(row);

            return item;
        }

        public BovinoCategorizadoLista GetAll()
        {
            if (_BovinoCategorizadoLista == null)
            {
                var dt = bd.GetAll("bovino",
                "id, categoria_id");

                var items = new List<BovinoCategorizado>();

                foreach (DataRow row in dt.Rows)
                {
                    var bovino = DataRowGanado(row);

                    items.Add(bovino);
                }

                _BovinoCategorizadoLista = new BovinoCategorizadoLista(items.ToArray());
            }

            return _BovinoCategorizadoLista;
        }

        public void setData(String[] Data)
        { 
        }

        private BovinoCategorizado DataRowGanado(DataRow row)
        {
            var bovino = new BovinoCategorizado()
            {
                Id = (Int32)row["id"]                
            };
            
            var servicio_cat = Categorias.Servicios.FactoriaServiciosLocales.GetInstance().GetServicioCategoria();
                       
            var lista_cat = servicio_cat.GetAll();
            
            bovino.Categoria = lista_cat.Find(x => x.Id.Equals( (Int32)row["categoria_id"] ));

            return bovino;            
        }
    }
}
