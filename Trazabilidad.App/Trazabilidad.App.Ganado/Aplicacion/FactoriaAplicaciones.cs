using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Ganado.Servicios.Interfaces;
using Trazabilidad.App.Ganado.Servicios.Adaptadores;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class FactoriaAplicaciones<T> : IFactoriaAplicaciones<T>
            
    {
        private static FactoriaAplicaciones<T> instancia;

        private FactoriaAplicaciones() { }

        public static FactoriaAplicaciones<T> GetInstance()
        {
            if (instancia == null)
            {
                instancia = new FactoriaAplicaciones<T>();
            }
            return instancia;
        }

        public IGanadoPropertyListenerAdaptador<T> GetAplicacion()
        {
            IGanadoPropertyListenerAdaptador<T> servicio;

            if (typeof(T) == typeof(GanadoItemListener))
            {
                var x = new GanadoPropertyListenerAdaptador();
                servicio = (IGanadoPropertyListenerAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(NacidoItemListener))
            {
                var x = new NacidoPropertyListenerAdaptador();
                servicio = (IGanadoPropertyListenerAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(CompradoItemListener))
            {
                var x = new CompradoPropertyListenerAdaptador();
                servicio = (IGanadoPropertyListenerAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(MuertoItemListener))
            {
                var x = new MuertoPropertyListenerAdaptador();
                servicio = (IGanadoPropertyListenerAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(VendidoItemListener))
            {
                var x = new VendidoPropertyListenerAdaptador();
                servicio = (IGanadoPropertyListenerAdaptador<T>)x;
                return servicio;
            }
        
            return null;
        }
    }
}
