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
    public class HijoAdaptadorBaseDeDatos : IHijoAdaptador
    {
        private BaseDeDatos bd;
        private static HijoLista _HijoLista;

        public HijoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Hijo GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "bovino",
                "id, padre_id, madre_id");

            var item = DataRowHijo(row);

            return item;
        }

        public HijoLista GetAll()
        {
            if (_HijoLista == null)
            {
                var dt = bd.GetAll("bovino",
                "id, padre_id, madre_id");

                var items = new List<Hijo>();

                foreach (DataRow row in dt.Rows)
                {
                    var bovino = DataRowHijo(row);
                    if (bovino != null)
                        items.Add(bovino);
                }

                _HijoLista = new HijoLista(items.ToArray());
            }
            return _HijoLista;
        }

        public void setData(String[] Data)
        {
        }

        private Hijo DataRowHijo(DataRow row)
        {
            var servicio_nacidos = FactoriaServiciosLocales.GetInstance().GetServicioBovinoNacido();
            var servicio_toros = FactoriaServiciosLocales.GetInstance().GetServicioToro();
            var servicio_vacas = FactoriaServiciosLocales.GetInstance().GetServicioVaca();

            var lista_nacidos = servicio_nacidos.GetAll();
            var lista_toros = servicio_toros.GetAll();
            var lista_vacas = servicio_vacas.GetAll();

            if (lista_nacidos.Exists(x => x.Id.Equals((Int32)row["id"])))
            {
                var nacido = lista_nacidos.Find(x => x.Id.Equals((Int32)row["id"]));

                if (lista_toros.Exists(x => x.Id.Equals((Int32)row["padre_id"])))
                {
                    var padre = lista_toros.Find(x => x.Id.Equals((Int32)row["padre_id"]));

                    if(lista_vacas.Exists(x => x.Id.Equals((Int32)row["madre_id"])))
                    {
                        var madre = lista_vacas.Find(x => x.Id.Equals((Int32)row["madre_id"]));

                        if (nacido != null && padre != null && madre != null)
                        {
                            var hijo = new Hijo(nacido, padre, madre);
                            return hijo;
                        }
                    }
                }
            }
            

            return null;
        }
    }
}
