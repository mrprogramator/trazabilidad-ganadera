using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Ganado.Servicios.Interfaces;
using Trazabilidad.App.Ganado.Servicios.Adaptadores;

namespace Trazabilidad.App.Ganado.Servicios
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

        public IBovinoAdaptador GetServicioGanado()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new BovinoAdaptadorBaseDeDatos(bd);
            return servicio;
        }

        public INacimientoAdaptador GetServicioNacimiento()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new NacimientoAdaptadorBaseDeDatos(bd);
            return servicio;
        }

        public ICategoriaAdaptador GetServicioCategoria()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new CategoriaAdaptadorBaseDeDatos(bd);
            return servicio;
        }

        public ICompraAdaptador GetServicioCompra()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new CompraAdaptadorBaseDeDatos(bd);
            return servicio;
        }
        
        public IMuerteAdaptador GetServicioMuerte()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new MuerteAdaptadorBaseDeDatos(bd);
            return servicio;
        }
        
        public IVentaAdaptador GetServicioVenta()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new VentaAdaptadorBaseDeDatos(bd);
            return servicio;
        }        
    }
}
