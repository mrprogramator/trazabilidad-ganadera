using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Entradas.Compras.Servicios.Interfaces;
using Trazabilidad.App.Entradas.Compras.Servicios.Adaptadores;
using Trazabilidad.App.Entradas.Nacimientos.Servicios.Interfaces;
using Trazabilidad.App.Entradas.Nacimientos.Servicios.Adaptadores;
namespace Trazabilidad.App.Entradas.Servicios
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

        public IBovinoNacidoAdaptador GetServicioBovinoNacido()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new BovinoNacidoAdaptadorBaseDeDatos(bd);
            return servicio;
        }        

        public IBovinoCompradoAdaptador GetServicioBovinoComprado()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new BovinoCompradoAdaptadorBaseDeDatos(bd);
            return servicio;
        }       

        public IHijoAdaptador GetServicioHijo()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new HijoAdaptadorBaseDeDatos(bd);
            return servicio;
        }
    }
}
