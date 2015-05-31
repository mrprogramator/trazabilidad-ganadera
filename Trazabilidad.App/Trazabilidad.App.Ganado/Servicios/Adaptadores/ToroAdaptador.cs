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
    public class ToroAdaptador : IToroAdaptador
    {
        private BaseDeDatos bd;
        private static ToroLista _ToroLista;

        public ToroAdaptador(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Toro GetById(Int32 id)
        {
            var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
            var row = servicio_bovino.GetById(id);
            var item = new Toro();

            if (row.Categoria.Id.Equals(item.Categoria.Id))
            {
                item = DataRowToro(row);
            }

            return item;
        }

        public ToroLista GetAll()
        {
            if (_ToroLista == null)
            {
                var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
                var lista_bovino = servicio_bovino.GetAll();

                var items = new List<Toro>();

                var toro = new Toro();

                foreach (var row in lista_bovino)
                {
                    if (row.Categoria.Id.Equals(toro.Categoria.Id))
                    {
                        toro = DataRowToro(row);
                        items.Add(toro);
                    }
                }

                _ToroLista = new ToroLista(items.ToArray());
            }

            return _ToroLista;
        }

        public void setData(String[] Data)
        {
        }

        private Toro DataRowToro(BovinoCategorizado row)
        {
            var toro = new Toro(row);
            return toro;
        }
    }
}
