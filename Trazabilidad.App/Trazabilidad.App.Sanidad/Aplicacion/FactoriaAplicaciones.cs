using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Sanidad.Servicios;
using Trazabilidad.App.Sanidad.Dominio;

namespace Trazabilidad.App.Sanidad.Aplicacion
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

        public ISanidadPropertyListenerAdaptador<T> GetAplicacion()
        {
            ISanidadPropertyListenerAdaptador<T> servicio;

            if (typeof(T) == typeof(InseminacionItemListener))
            {
                var x = new InseminacionPropertyListenerAdaptador();
                servicio = (ISanidadPropertyListenerAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(PalpacionItemListener))
            {
                var x = new PalpacionPropertyListenerAdaptador();
                servicio = (ISanidadPropertyListenerAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(PreñadoItemListener))
            {
                var x = new PreñadoPropertyListenerAdaptador();
                servicio = (ISanidadPropertyListenerAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(VacunaItemListener))
            {
                var x = new VacunaPropertyListenerAdaptador();
                servicio = (ISanidadPropertyListenerAdaptador<T>)x;
                return servicio;
            }
        
            return null;
        }
    }
}
