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
    public class NacidoPropertyListenerAdaptador : IGanadoPropertyListenerAdaptador<NacidoItemListener>
    {
        private static GanadoPropertyListener<NacidoItemListener> _PropertyListenerNacidos;

        public NacidoPropertyListenerAdaptador()
        {
        }

        public GanadoPropertyListener<NacidoItemListener> GetAll()
        {
            if (_PropertyListenerNacidos == null)
            {
                var lista_nacidos = FactoriaServiciosLocales<BovinoNacido>.GetInstance().GetServicio().GetAll();

                var items = new List<NacidoItemListener>();

                foreach (var bovino in lista_nacidos)
                {
                    var myItem = GetItemListener(bovino);
                    myItem.GetCode(myItem);
                    items.Add(myItem);
                }

                _PropertyListenerNacidos = new GanadoPropertyListener<NacidoItemListener>(items.ToArray());
            }
            return _PropertyListenerNacidos;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales<BovinoNacido>.GetInstance().GetServicio();
            var lista_ganado = servicio.GetAll();

            foreach (var item in _PropertyListenerNacidos)
            {
                var bovino = lista_ganado.FirstOrDefault(b => b.Id.Equals(item.Id));

                if (bovino != null)
                {
                    bovino = UpdateItemListener(bovino, item);
                    continue;
                }

                bovino = GetItemListener(item);
                lista_ganado.Add(bovino);
            }

            servicio.SetAll();
        }

        private static NacidoItemListener GetItemListener(BovinoNacido _Bovino)
        {
            var _ItemListener = new NacidoItemListener();
            
            if (_Bovino.Nacimiento == null)
                return null;
            
            _ItemListener.Id = _Bovino.Id;

            _ItemListener.Categoria = _Bovino.Categoria.Nombre;

            _ItemListener.Sexo = _Bovino.Categoria.Sexo;
            var lista = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio().GetAll();

            if (_Bovino.Padre != null)
            {
                var padre = lista.FirstOrDefault(b => b.Id.Equals(_Bovino.Padre.Id));
                
                var padreItem = new NacidoItemListener() 
                { 
                    Id = padre.Id,
                    Categoria = padre.Categoria.Nombre
                };

                _ItemListener.Padre = padreItem.GetCode(padreItem).Codigo;
            }

            if (_Bovino.Madre != null)
            {
                var madre = lista.FirstOrDefault(b => b.Id.Equals(_Bovino.Madre.Id));
                var madreItem = new NacidoItemListener()
                {
                    Id = madre.Id,
                    Categoria = madre.Categoria.Nombre
                }; 
                _ItemListener.Madre = madreItem.GetCode(madreItem).Codigo;
            }

            if (_Bovino.Nacimiento.Fecha != null)
            {
                _ItemListener.Entrada = _Bovino.Nacimiento.Fecha;
            }

            if (_Bovino.Nacimiento.Observaciones != null)
            {
                _ItemListener.Observaciones = _Bovino.Nacimiento.Observaciones;
            }

            return _ItemListener;
        }

        private static BovinoNacido GetItemListener(NacidoItemListener item)
        {
            var _Bovino = new BovinoNacido();

            _Bovino.Id = item.Id;


            var lista_cat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();

            var cat = lista_cat.Find(c => c.Nombre.Equals(item.Categoria));
            _Bovino.Categoria = new Categoria()
            {
                Id = cat.Id,
                Nombre = cat.Nombre,
                Sexo = cat.Sexo,
                Descripcion = cat.Descripcion
            };

            if (item.Padre != null)
            {
                var padre_id = Convert.ToInt32(item.Padre.Substring(3));
                var lista_ganado = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio().GetAll();
                var padre = lista_ganado.FirstOrDefault(b => b.Id.Equals(padre_id));
                
                if (padre != null)
                    _Bovino.Padre = padre;
            }

            if (item.Madre != null)
            {
                var madre_id = Convert.ToInt32(item.Madre.Substring(3));
                var lista_ganado = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio().GetAll();
                var madre = lista_ganado.FirstOrDefault(b => b.Id.Equals(madre_id));

                if (madre != null)
                    _Bovino.Madre = madre;
            }

            if (item.Entrada != null)
            {
                _Bovino.Nacimiento = new Nacimiento()
                {
                    Fecha = item.Entrada
                };
            }

            if (item.Observaciones != null)
            {
                _Bovino.Nacimiento.Observaciones = item.Observaciones;
            }

            return _Bovino;
        }

        private static BovinoNacido UpdateItemListener(BovinoNacido bovinoNacido, NacidoItemListener item)
        {
            var lista_cat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();

            var cat = lista_cat.Find(c => c.Nombre.Equals(item.Categoria));
            bovinoNacido.Categoria = new Categoria()
            {
                Id = cat.Id,
                Nombre = cat.Nombre,
                Sexo = cat.Sexo,
                Descripcion = cat.Descripcion
            };

            if (item.Padre != null)
            {
                var padre_id = Convert.ToInt32(item.Padre.Substring(3));
                var lista_ganado = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio().GetAll();
                var padre = lista_ganado.Find(b => b.Id.Equals(padre_id));
                bovinoNacido.Padre = padre;
            }

            if (item.Madre != null)
            {
                var madre_id = Convert.ToInt32(item.Padre.Substring(3));
                var lista_ganado = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio().GetAll();
                var madre = lista_ganado.Find(b => b.Id.Equals(madre_id));
                bovinoNacido.Madre = madre;
            }

            bovinoNacido.Nacimiento.Fecha = item.Entrada;

            if (item.Observaciones != null)
            {
                bovinoNacido.Nacimiento.Observaciones = item.Observaciones;
            }

            return bovinoNacido;
        }

    }
}
