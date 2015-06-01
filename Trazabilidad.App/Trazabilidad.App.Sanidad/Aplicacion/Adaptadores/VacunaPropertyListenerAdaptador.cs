using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Sanidad.Servicios;
using Trazabilidad.App.Sanidad.Dominio;

namespace Trazabilidad.App.Sanidad.Aplicacion
{
    public class VacunaPropertyListenerAdaptador : ISanidadPropertyListenerAdaptador<VacunaItemListener>
    {
        private static SanidadPropertyListener<VacunaItemListener> _PropertyListener;

        public VacunaPropertyListenerAdaptador()
        {
        }

        public SanidadPropertyListener<VacunaItemListener> GetAll()
        {
            if (_PropertyListener == null)
            {
                var lista = FactoriaServiciosLocales<Vacuna>.GetInstance().GetServicio().GetAll();

                var items = new List<VacunaItemListener>();

                foreach (var sanidad in lista)
                {
                    var myItem = GetItemListener(sanidad);
                    items.Add(myItem);
                }

                _PropertyListener = new SanidadPropertyListener<VacunaItemListener>(items.ToArray());
            }
            return _PropertyListener;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales<Vacuna>.GetInstance().GetServicio();
            var lista = servicio.GetAll();
            foreach (var item in _PropertyListener)
            {
                var sanidad = lista.FirstOrDefault(b => b.Id.Equals(item.Id));

                if (sanidad != null)
                {
                    sanidad = UpdateItemListener(sanidad, item);
                    continue;
                }

                sanidad = GetItemListener(item);
                lista.Add(sanidad);
            }

            servicio.SetAll();
        }

        private static VacunaItemListener GetItemListener(Vacuna sanidad)
        {
            var itemListener = new VacunaItemListener();

            itemListener.Id = sanidad.Id;

            itemListener.Fecha = sanidad.Fecha;

            itemListener.Bovino = sanidad.Bovino.Id;

            itemListener.Nombre = sanidad.Nombre;

            itemListener.Dosis = sanidad.Dosis;

            return itemListener;
        }

        private static Vacuna GetItemListener(VacunaItemListener item)
        {
            var sanidad = new Vacuna();

            sanidad.Id = item.Id;

            sanidad.Fecha = item.Fecha;

            sanidad.Bovino = new Ganado.Dominio.Bovino()
            {
                Id = item.Bovino
            };

            sanidad.Nombre = item.Nombre;

            sanidad.Dosis = item.Dosis;

            return sanidad;
        }

        private static Vacuna UpdateItemListener(Vacuna sanidad, VacunaItemListener item)
        {
            sanidad.Fecha = item.Fecha;

            sanidad.Nombre = item.Nombre;

            sanidad.Dosis = item.Dosis;

            return sanidad;
        }
    }
}
