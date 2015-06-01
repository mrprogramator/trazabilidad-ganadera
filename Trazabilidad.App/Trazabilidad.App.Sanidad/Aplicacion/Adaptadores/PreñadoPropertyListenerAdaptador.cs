using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Sanidad.Servicios;
using Trazabilidad.App.Sanidad.Dominio;

namespace Trazabilidad.App.Sanidad.Aplicacion
{
    public class PreñadoPropertyListenerAdaptador : ISanidadPropertyListenerAdaptador<PreñadoItemListener>
    {
        private static SanidadPropertyListener<PreñadoItemListener> _PropertyListener;

        public PreñadoPropertyListenerAdaptador()
        {
        }

        public SanidadPropertyListener<PreñadoItemListener> GetAll()
        {
            if (_PropertyListener == null)
            {
                var lista = FactoriaServiciosLocales<Preñado>.GetInstance().GetServicio().GetAll();

                var items = new List<PreñadoItemListener>();

                foreach (var sanidad in lista)
                {
                    var myItem = GetItemListener(sanidad);
                    items.Add(myItem);
                }

                _PropertyListener = new SanidadPropertyListener<PreñadoItemListener>(items.ToArray());
            }
            return _PropertyListener;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales<Preñado>.GetInstance().GetServicio();
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

        private static PreñadoItemListener GetItemListener(Preñado sanidad)
        {
            var itemListener = new PreñadoItemListener();

            itemListener.Id = sanidad.Id;

            itemListener.Fecha = sanidad.Fecha;

            itemListener.Bovino = sanidad.Bovino.Id;

            itemListener.Observaciones = sanidad.Observaciones;

            return itemListener;
        }

        private static Preñado GetItemListener(PreñadoItemListener item)
        {
            var sanidad = new Preñado();

            sanidad.Id = item.Id;

            sanidad.Fecha = item.Fecha;

            sanidad.Bovino = new Ganado.Dominio.Bovino()
            {
                Id = item.Bovino
            };

            sanidad.Observaciones = item.Observaciones;

            return sanidad;
        }

        private static Preñado UpdateItemListener(Preñado sanidad, PreñadoItemListener item)
        {
            sanidad.Fecha = item.Fecha;
            
            sanidad.Observaciones = item.Observaciones;

            return sanidad;
        }
    }
}
