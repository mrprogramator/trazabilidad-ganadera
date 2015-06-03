using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Sanidad.Dominio;
namespace Trazabilidad.App.Sanidad.Servicios
{
    public class FactoriaServiciosLocales<T> : IFactoriaServicios<T>
            
    {
        private static FactoriaServiciosLocales<T> instancia;

        private FactoriaServiciosLocales() { }

        public static FactoriaServiciosLocales<T> GetInstance()
        {
            if (instancia == null)
            {
                instancia = new FactoriaServiciosLocales<T>();
            }
            return instancia;
        }

        public IAdaptador<T> GetServicio()
        {
            var bd = BaseDeDatos.GetInstance();
            IAdaptador<T> servicio;

            if (typeof(T) == typeof(Inseminacion))
            {
                var x = new InseminacionAdaptadorBaseDeDatos(bd);
                servicio = (IAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(Palpacion))
            {
                var x = new PalpacionAdaptadorBaseDeDatos(bd);
                servicio = (IAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(Preñado))
            {
                var x = new PreñadoAdaptadorBaseDeDatos(bd);
                servicio = (IAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(Vacuna))
            {
                var x = new VacunaAdaptadorBaseDeDatos(bd);
                servicio = (IAdaptador<T>)x;
                return servicio;
            }
            return null;
        }
    }
}
