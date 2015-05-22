using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Servicios.Listas;
using Trazabilidad.App.Ganado.Servicios.Adaptadores;
using Trazabilidad.App.Ganado.Servicios.Interfaces;
using Trazabilidad.App.Ganado.Servicios;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class PropertyListenerAdaptador : IPropertyListenerAdaptador
    {
        private static PropertyListenerAdaptador instance;
        
        private PropertyListenerAdaptador()
        { 
        }

        public static PropertyListenerAdaptador GetInstance()
        {
            if (instance == null)
            {
                instance = new PropertyListenerAdaptador();
            }
            return instance;
        }

        public PropertyListener GetAll()
        {
            var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioGanado();
            var lista_bovino = servicio_bovino.GetAll();
            
            var items = new List<ItemListener>();

            foreach (var bovino in lista_bovino)
            {
                var myItem = GetItemListener(bovino);
                items.Add(myItem);
            }
            var _PropertyListener = new PropertyListener(items.ToArray());
            return _PropertyListener;
        }
                
        private ItemListener GetItemListener(Bovino _Bovino)
        {
            var _ItemListener = new ItemListener();
            _ItemListener.Id = _Bovino.Id.ToString();
            _ItemListener.Sexo = _Bovino.Sexo.ToString();
            _ItemListener.Estado = _Bovino.Estado;
            _ItemListener.Categoria = _Bovino.Categoria.Nombre;

            if (_Bovino.Madre != null)
            {
                _ItemListener.MadreId = _Bovino.Madre.Id.ToString();
            }

            if (_Bovino.Padre != null)
            {
                _ItemListener.PadreId = _Bovino.Padre.Id.ToString();
            }
            
            if (_Bovino.Entrada != null)
            {
                _ItemListener.Entrada = _Bovino.Entrada.Fecha;
                if (_Bovino.Entrada is Nacimiento)
                {
                    _ItemListener.TipoEntrada = "Nacimiento";
                }
                else if (_Bovino.Entrada is Compra)
                {
                    _ItemListener.TipoEntrada = "Compra";
                }
            }

            if (_Bovino.Salida != null)
            {
                _ItemListener.Salida = _Bovino.Salida.Fecha;
                if (_Bovino.Salida is Muerte)
                {
                    _ItemListener.TipoSalida = "Muerte";
                }
                else if (_Bovino.Salida is Venta)
                {
                    _ItemListener.TipoSalida = "Venta";
                }
            }

            return _ItemListener;
        }

       
    }
}
