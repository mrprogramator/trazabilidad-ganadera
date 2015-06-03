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
    public class GanadoPropertyListenerAdaptador : IGanadoPropertyListenerAdaptador<GanadoItemListener>
    {
        private static GanadoPropertyListener<GanadoItemListener> _PropertyListenerGanado;
        
        public GanadoPropertyListenerAdaptador()
        { 
        }

        public GanadoPropertyListener<GanadoItemListener> GetAll()
        {
            if (_PropertyListenerGanado == null)
            {
                var lista_ganado = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio().GetAll();
                    
                var items = new List<GanadoItemListener>();

                foreach (var bovino in lista_ganado)
                {
                    var myItem = GetItemListener(bovino);
                    myItem.GetCode(myItem);
                    items.Add(myItem);
                }

                _PropertyListenerGanado = new GanadoPropertyListener<GanadoItemListener>(items.ToArray());                    
            }
            return _PropertyListenerGanado;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales<Bovino>.GetInstance().GetServicio();
            var lista_ganado = servicio.GetAll();
            lista_ganado.RemoveAll(b => b.Id == b.Id);   
            foreach (var item in _PropertyListenerGanado)
            {
                var bovino = GetItemListener(item);
                lista_ganado.Add(bovino);
            }
        }
        
        private static GanadoItemListener GetItemListener(Bovino _Bovino)
        {
            var _ItemListener = new GanadoItemListener();
            
            _ItemListener.Id = _Bovino.Id;            
            
            _ItemListener.Categoria = _Bovino.Categoria.Nombre;

            _ItemListener.Sexo = _Bovino.Categoria.Sexo;

            return _ItemListener;
        }

        private static Bovino GetItemListener(GanadoItemListener item)
        {
            var Bovino = new Bovino();

            Bovino.Id = item.Id;

            var lista_cat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
            
            var cat = lista_cat.Find(c => c.Nombre.Equals(item.Categoria));

            Bovino.Categoria = new Categoria()
            {
                Id = cat.Id,
                Nombre = cat.Nombre,
                Sexo = cat.Sexo,
                Descripcion = cat.Descripcion,
            };

            return Bovino;
        }
    }
}
