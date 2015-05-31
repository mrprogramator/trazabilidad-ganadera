using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Ganado.Servicios.Interfaces;
using Trazabilidad.App.Ganado.Servicios.Adaptadores;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Ganado.Servicios
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

            if (typeof(T) == typeof(Bovino))
            {
                var x = new BovinoAdaptadorBaseDeDatos(bd);
                servicio = (IAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(BovinoNacido))
            {
                var x = new BovinoNacidoAdaptadorBaseDeDatos(bd);
                servicio = (IAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(BovinoComprado))
            {
                var x = new BovinoCompradoAdaptadorBaseDeDatos(bd);
                servicio = (IAdaptador<T>)x;
                return servicio;
            }

            if (typeof(T) == typeof(BovinoMuerto))
            {
                var x = new BovinoMuertoAdaptadorBaseDeDatos(bd);
                servicio = (IAdaptador<T>)x;
                return servicio;
            }
            if (typeof(T) == typeof(BovinoVendido))
            {
                var x = new BovinoVendidoAdaptadorBaseDeDatos(bd);
                servicio = (IAdaptador<T>)x;
                return servicio;
            }
            return null;
        }
    }
}
