using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Categorias.Servicios.Interfaces;
using Trazabilidad.App.Categorias.Servicios.Adaptadores;

namespace Trazabilidad.App.Categorias.Servicios
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

        public ICategoriaAdaptador GetServicioCategoria()
        {
            var bd = BaseDeDatos.GetInstance();
            var servicio = new CategoriaAdaptadorBaseDeDatos(bd);
            return servicio;
        }       
    }
}
