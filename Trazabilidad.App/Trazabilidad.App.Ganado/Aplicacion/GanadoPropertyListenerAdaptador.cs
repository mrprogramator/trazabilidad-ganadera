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
using Trazabilidad.App.Categorias.Dominio;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class GanadoPropertyListenerAdaptador : IGanadoPropertyListenerAdaptador
    {
        private static GanadoPropertyListenerAdaptador instance;
        private static GanadoPropertyListener _PropertyListener;
        
        private GanadoPropertyListenerAdaptador()
        { 
        }

        public static GanadoPropertyListenerAdaptador GetInstance()
        {
            if (instance == null)
            {
                instance = new GanadoPropertyListenerAdaptador();                
            }
            return instance;
        }

        public GanadoPropertyListener GetAll()
        {
            if (_PropertyListener == null)
            {
                var servicio_bovino = FactoriaServiciosLocales.GetInstance().GetServicioBovinoCategorizado();
                var lista_bovino = servicio_bovino.GetAll();

                var items = new List<GanadoItemListener>();

                foreach (var bovino in lista_bovino)
                {
                    var myItem = GetItemListener(bovino);
                    items.Add(myItem);
                }
                _PropertyListener = new GanadoPropertyListener(items.ToArray());
            }
            List<GanadoItemListener> list = _PropertyListener;
            list = list.OrderBy(p => p.Id).ToList();
            _PropertyListener = new GanadoPropertyListener(list.ToArray());
            return _PropertyListener;
        }
                
        private static GanadoItemListener GetItemListener(BovinoCategorizado _Bovino)
        {
            var _ItemListener = new GanadoItemListener();
            _ItemListener.Id = _Bovino.Id;
            //BorrAR
            _ItemListener.Sexo = _Bovino.Categoria.Sexo.ToString();
            
            _ItemListener.Categoria = _Bovino.Categoria.Nombre;

            var servicio_hijo = FactoriaServiciosLocales.GetInstance().GetServicioHijo();
            var lista_hijos = servicio_hijo.GetAll();
            
            if (lista_hijos.Exists(x => x.Id.Equals(_Bovino.Id)))
            {
                var hijo = lista_hijos.Find(x => x.Id.Equals(_Bovino.Id));

                if (hijo != null)
                {
                    _ItemListener.MadreId = hijo.Madre.Id.ToString();
                    _ItemListener.PadreId = hijo.Padre.Id.ToString();
                }
            }
            

            var servicio_nacido = FactoriaServiciosLocales.GetInstance().GetServicioBovinoNacido();
            var lista_nacidos = servicio_nacido.GetAll();

            if (lista_nacidos.Exists(x => x.Id.Equals(_Bovino.Id)))
            {
                var nacido = lista_nacidos.Find(x => x.Id.Equals(_Bovino.Id));

                if (nacido != null)
                {
                    _ItemListener.Entrada = nacido.Nacimiento.Fecha;
                    _ItemListener.TipoEntrada = "Nacimiento";
                }                
            }

            else
            {
                var servicio_comprado = FactoriaServiciosLocales.GetInstance().GetServicioBovinoComprado();
                var lista_comprados = servicio_comprado.GetAll();

                if (lista_comprados.Exists(x => x.Id.Equals(_Bovino.Id)))
                {
                    var comprado = lista_comprados.Find(x => x.Id.Equals(_Bovino.Id));

                    if (comprado != null)
                    {
                        _ItemListener.Entrada = comprado.Compra.Fecha;
                        _ItemListener.TipoEntrada = "Compra";
                    }
                }
            }
            

            _ItemListener.Activo = true;
            
            var servicio_muerto = FactoriaServiciosLocales.GetInstance().GetServicioBovinoMuerto();
            var lista_muertos = servicio_muerto.GetAll();

            if (lista_muertos.Exists(x => x.Id.Equals(_Bovino.Id)))
            {
                var muerto = lista_muertos.Find(x => x.Id.Equals(_Bovino.Id));

                if (muerto != null)
                {
                    _ItemListener.Salida = muerto.Muerte.Fecha;
                    _ItemListener.TipoSalida = "Muerte";
                    _ItemListener.Activo = false;
                }                
            }

            else
            {
                var servicio_vendido = FactoriaServiciosLocales.GetInstance().GetServicioBovinoVendido();
                var lista_vendidos = servicio_vendido.GetAll();

                if (lista_vendidos.Exists(x => x.Id.Equals(_Bovino.Id)))
                {
                    var vendido = lista_vendidos.Find(x => x.Id.Equals(_Bovino.Id));

                    if (vendido != null)
                    {
                        _ItemListener.Entrada = vendido.Venta.Fecha;
                        _ItemListener.TipoEntrada = "Venta";
                        _ItemListener.Activo = false;
                    }
                }
            }

            return _ItemListener;
        }

       
    }
}
