using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Entradas.Servicios;
using Trazabilidad.App.Entradas.Compras.Servicios;
using Trazabilidad.App.Entradas.Compras.Servicios.Interfaces;
using Trazabilidad.App.Entradas.Nacimientos.Servicios;
using Trazabilidad.App.Entradas.Nacimientos.Servicios.Interfaces;
using Trazabilidad.App.Categorias.Dominio;
using Trazabilidad.App.Entradas.Dominio;
using Trazabilidad.App.Entradas.Compras.Dominio;
using Trazabilidad.App.Entradas.Nacimientos.Dominio;


namespace Trazabilidad.App.Entradas.Aplicacion
{
    public class EntradaPropertyListenerAdaptador : IEntradaPropertyListenerAdaptador
    {
        private static EntradaPropertyListenerAdaptador instance;
        private static EntradaPropertyListener _PropertyListener;
        
        private EntradaPropertyListenerAdaptador()
        { 
        }

        public static EntradaPropertyListenerAdaptador GetInstance()
        {
            if (instance == null)
            {
                instance = new EntradaPropertyListenerAdaptador();                
            }
            return instance;
        }

        public EntradaPropertyListener GetAll()
        {
            if (_PropertyListener == null)
            {
                var items = new List<EntradaItemListener>();

                var servicio_bovino_compra = FactoriaServiciosLocales.GetInstance().GetServicioBovinoComprado();
                var lista_bovino_compra = servicio_bovino_compra.GetAll();                

                foreach (var bovino in lista_bovino_compra)
                {
                    var myItem = GetItemListener(bovino);
                    items.Add(myItem);
                }

                var servicio_bovino_nacido = FactoriaServiciosLocales.GetInstance().GetServicioBovinoNacido();
                var lista_bovino_nacido = servicio_bovino_nacido.GetAll();

                foreach (var bovino in lista_bovino_nacido)
                {
                    var myItem = GetItemListener(bovino);
                    items.Add(myItem);
                }

                _PropertyListener = new EntradaPropertyListener(items.ToArray());
            }
            List<EntradaItemListener> list = _PropertyListener;
            list = list.OrderBy(p => p.Fecha).ToList();
            _PropertyListener = new EntradaPropertyListener(list.ToArray());
            return _PropertyListener;
        }

        private static EntradaItemListener GetItemListener(BovinoComprado _BovinoEntrante)
        {
            var _ItemListener = new EntradaItemListener();
            
            _ItemListener.Fecha = _BovinoEntrante.Compra.Fecha;
            _ItemListener.Tipo = typeof(Compra).Name.ToString();
            _ItemListener.BovinoId = _BovinoEntrante.Id;
            _ItemListener.Categoria = _BovinoEntrante.Categoria.Nombre;
            
            if( _BovinoEntrante.Compra.Observaciones != null)
                _ItemListener.Observaciones = _BovinoEntrante.Compra.Observaciones;
            
            return _ItemListener;
        }
        private static EntradaItemListener GetItemListener(BovinoNacido _BovinoEntrante)
        {
            var _ItemListener = new EntradaItemListener();

            _ItemListener.Fecha = _BovinoEntrante.Nacimiento.Fecha;

            _ItemListener.Tipo = typeof(Nacimiento).Name.ToString();
            _ItemListener.BovinoId = _BovinoEntrante.Id;
            _ItemListener.Categoria = _BovinoEntrante.Categoria.Nombre;

            if (_BovinoEntrante.Nacimiento.Observaciones != null)
                _ItemListener.Observaciones = _BovinoEntrante.Nacimiento.Observaciones;

            return _ItemListener;
        }
       
    }
}
