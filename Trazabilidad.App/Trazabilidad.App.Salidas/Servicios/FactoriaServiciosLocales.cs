using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Salidas.Ventas.Servicios.Interfaces;
using Trazabilidad.App.Salidas.Ventas.Servicios.Adaptadores;
using Trazabilidad.App.Salidas.Muertes.Servicios.Interfaces;
using Trazabilidad.App.Salidas.Muertes.Servicios.Adaptadores;

namespace Trazabilidad.App.Salidas.Servicios
{
    public class FactoriaServiciosLocales : IFactoriaServicios
    {
        private static FactoriaServiciosLocales instancia;

        private FactoriaServiciosLocales() { }

        public static FactoriaServiciosLocales GetInstance()
        {
            if (instancia == null)
            {
                instancia = new FactoriaServiciosLocales();
            }
            return instancia;
        }

        public IBovinoMuertoAdaptador GetServicioBovinoMuerto()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new BovinoMuertoAdaptadorBaseDeDatos(bd);
            return servicio;
        }
        
        public IBovinoVendidoAdaptador GetServicioBovinoVendido()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new BovinoVendidoAdaptadorBaseDeDatos(bd);
            return servicio;
        }
    }
}
