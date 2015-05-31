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
    public class VaquillaAdaptador : IVaquillaAdaptador
    {
        private BaseDeDatos bd;
        private static VaquillaLista _VaquillaLista;

        public VaquillaAdaptador(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Vaquilla GetById(Int32 id)
        {
            var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
            var row = servicio_bovino.GetById(id);
            var item = new Vaquilla();

            if (row.Categoria.Equals(item.Categoria))
            {
                item = DataRowVaquilla(row);
            }

            return item;
        }

        public VaquillaLista GetAll()
        {
            if (_VaquillaLista == null)
            {
                var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
                var lista_bovino = servicio_bovino.GetAll();

                var items = new List<Vaquilla>();

                var vaquilla = new Vaquilla();

                foreach (var row in lista_bovino)
                {
                    if (row.Categoria.Id.Equals(vaquilla.Categoria.Id))
                    {
                        vaquilla = DataRowVaquilla(row);
                        items.Add(vaquilla);
                    }
                }

                _VaquillaLista = new VaquillaLista(items.ToArray());
            }

            return _VaquillaLista;
        }

        public void setData(String[] Data)
        {
        }

        private Vaquilla DataRowVaquilla(BovinoCategorizado row)
        {
            var vaquilla = new Vaquilla(row);
            return vaquilla;
        }
    }
}
