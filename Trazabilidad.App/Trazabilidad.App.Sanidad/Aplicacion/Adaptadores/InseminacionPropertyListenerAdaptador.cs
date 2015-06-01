using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Sanidad.Servicios;
using Trazabilidad.App.Sanidad.Dominio;

namespace Trazabilidad.App.Sanidad.Aplicacion
{
    public class InseminacionPropertyListenerAdaptador : ISanidadPropertyListenerAdaptador<InseminacionItemListener>
    {
        private static SanidadPropertyListener<InseminacionItemListener> _PropertyListenerInseminacion;

        public InseminacionPropertyListenerAdaptador()
        { 
        }

        public SanidadPropertyListener<InseminacionItemListener> GetAll()
        {
            if (_PropertyListenerInseminacion == null)
            {
                var lista = FactoriaServiciosLocales<Inseminacion>.GetInstance().GetServicio().GetAll();
                    
                var items = new List<InseminacionItemListener>();

                foreach (var sanidad in lista)
                {
                    var myItem = GetItemListener(sanidad);
                    items.Add(myItem);
                }

                _PropertyListenerInseminacion = new SanidadPropertyListener<InseminacionItemListener>(items.ToArray());                    
            }
            return _PropertyListenerInseminacion;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales<Inseminacion>.GetInstance().GetServicio();
            var lista = servicio.GetAll();
            foreach (var item in _PropertyListenerInseminacion)
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
        
        private static InseminacionItemListener GetItemListener(Inseminacion sanidad)
        {
            var itemListener = new InseminacionItemListener();
            
            itemListener.Id = sanidad.Id;            
            
            itemListener.Fecha = sanidad.Fecha;

            itemListener.Madre = sanidad.Bovino.Id;

            itemListener.Padre = sanidad.Padre.Id;

            itemListener.Observaciones = sanidad.Observaciones;

            return itemListener;
        }

        private static Inseminacion GetItemListener(InseminacionItemListener item)
        {
            var sanidad = new Inseminacion();

            sanidad.Id = item.Id;

            sanidad.Fecha = item.Fecha;

            sanidad.Bovino = new Ganado.Dominio.Bovino()
            {
                Id = item.Madre
            };

            sanidad.Padre = new Ganado.Dominio.Bovino()
            {
                Id = item.Padre
            };

            sanidad.Observaciones = item.Observaciones;

            return sanidad;
        }

        private static Inseminacion UpdateItemListener(Inseminacion sanidad, InseminacionItemListener item)
        {
            sanidad.Fecha = item.Fecha;

            sanidad.Observaciones = item.Observaciones;

            return sanidad;
        }
    }
}
