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
    public class VacaAdaptador : IVacaAdaptador
    {
        private BaseDeDatos bd;
        private static VacaLista _VacaLista;

        public VacaAdaptador(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Vaca GetById(Int32 id)
        {
            var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
            var row = servicio_bovino.GetById(id);
            var item = new Vaca();
            
            if (row.Categoria.Equals(item.Categoria))
            {
                item = DataRowVaca(row);
            }           
 
            return item;
        }

        public VacaLista GetAll()
        {
            if (_VacaLista == null)
            {
                var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
                var lista_bovino = servicio_bovino.GetAll();

                var items = new List<Vaca>();

                var vaca = new Vaca();

                foreach (var row in lista_bovino)
                {
                    if (row.Categoria.Id.Equals(vaca.Categoria.Id))
                    {
                        vaca = DataRowVaca(row);
                        items.Add(vaca);
                    }
                }

                _VacaLista = new VacaLista(items.ToArray());
            }

            return _VacaLista;
        }

        public void setData(String[] Data)
        {
        }

        private Vaca DataRowVaca(BovinoCategorizado row)
        {           
            var vaca = new Vaca(row);
            return vaca;
        }
    }
}
