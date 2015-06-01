using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Sanidad.Servicios;
using Trazabilidad.App.Sanidad.Dominio;

namespace Trazabilidad.App.Sanidad.Aplicacion
{
    public class PalpacionPropertyListenerAdaptador : ISanidadPropertyListenerAdaptador<PalpacionItemListener>
    {
        private static SanidadPropertyListener<PalpacionItemListener> _PropertyListener;

        public PalpacionPropertyListenerAdaptador()
        { 
        }

        public SanidadPropertyListener<PalpacionItemListener> GetAll()
        {
            if (_PropertyListener == null)
            {
                var lista = FactoriaServiciosLocales<Palpacion>.GetInstance().GetServicio().GetAll();
                    
                var items = new List<PalpacionItemListener>();

                foreach (var sanidad in lista)
                {
                    var myItem = GetItemListener(sanidad);
                    items.Add(myItem);
                }

                _PropertyListener = new SanidadPropertyListener<PalpacionItemListener>(items.ToArray());                    
            }
            return _PropertyListener;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales<Palpacion>.GetInstance().GetServicio();
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
        
        private static PalpacionItemListener GetItemListener(Palpacion sanidad)
        {
            var itemListener = new PalpacionItemListener();
            
            itemListener.Id = sanidad.Id;            
            
            itemListener.Fecha = sanidad.Fecha;

            itemListener.Bovino = sanidad.Bovino.Id;

            itemListener.Numero = sanidad.Numero;

            itemListener.MesGestacion = sanidad.MesGestacion;

            itemListener.Preñada = sanidad.Estado;

            return itemListener;
        }

        private static Palpacion GetItemListener(PalpacionItemListener item)
        {
            var sanidad = new Palpacion();

            sanidad.Id = item.Id;

            sanidad.Fecha = item.Fecha;

            sanidad.Bovino = new Ganado.Dominio.Bovino()
            {
                Id = item.Bovino
            };

            sanidad.Numero = item.Numero;

            sanidad.MesGestacion = item.MesGestacion;

            sanidad.Estado = item.Preñada;

            return sanidad;
        }

        private static Palpacion UpdateItemListener(Palpacion sanidad, PalpacionItemListener item)
        {
            sanidad.Fecha = item.Fecha;

            sanidad.Numero = item.Numero;

            sanidad.MesGestacion = item.MesGestacion;

            sanidad.Estado = item.Preñada;

            return sanidad;
        }
    }
}
