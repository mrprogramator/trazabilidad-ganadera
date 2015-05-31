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
    public class NovilloAdaptador : INovilloAdaptador
    {
        private BaseDeDatos bd;
        private static NovilloLista _NovilloLista;

        public NovilloAdaptador(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Novillo GetById(Int32 id)
        {
            var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
            var row = servicio_bovino.GetById(id);
            var item = new Novillo();

            if (row.Categoria.Equals(item.Categoria))
            {
                item = DataRowNovillo(row);
            }

            return item;
        }

        public NovilloLista GetAll()
        {
            if (_NovilloLista == null)
            {
                var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
                var lista_bovino = servicio_bovino.GetAll();

                var items = new List<Novillo>();

                var novillo = new Novillo();

                foreach (var row in lista_bovino)
                {
                    if (row.Categoria.Id.Equals(novillo.Categoria.Id))
                    {
                        novillo = DataRowNovillo(row);
                        items.Add(novillo);
                    }
                }

                _NovilloLista = new NovilloLista(items.ToArray());
            }

            return _NovilloLista;
        }

        public void setData(String[] Data)
        {
        }

        private Novillo DataRowNovillo(BovinoCategorizado row)
        {
            var novillo = new Novillo(row);
            return novillo;
        }
    }
}
