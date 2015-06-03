using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Aplicacion;
using Trazabilidad.App.Ganado.Dominio;
using Trazabilidad.App.Ganado.Servicios;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class TrazaPropertyListenerAdaptador : IGanadoPropertyListenerAdaptador<TrazaItemListener>
    {
        private static GanadoPropertyListener<TrazaItemListener> _PropertyListenerTrazas;

        public TrazaPropertyListenerAdaptador()
        {
        }

        public GanadoPropertyListener<TrazaItemListener> GetAll()
        {
            if (_PropertyListenerTrazas == null)
            {
                var lista_Trazas = FactoriaServiciosLocales<Traza>.GetInstance().GetServicio().GetAll();

                List<TrazaItemListener> items = new List<TrazaItemListener>();

                foreach (var traza in lista_Trazas)
                {
                    var myItem = GetItemListener(traza);
                    items.Add(myItem);
                }

                _PropertyListenerTrazas = new GanadoPropertyListener<TrazaItemListener>(items.ToArray());
            }
            return _PropertyListenerTrazas;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales<Traza>.GetInstance().GetServicio();
            var lista = servicio.GetAll();

            if (_PropertyListenerTrazas == null)
                return;

            foreach (var item in _PropertyListenerTrazas)
            {
                var traza = lista.FirstOrDefault(b => b.Id.Equals(item.Id));

                traza = GetItemListener(item);
                lista.Add(traza);
            }

            servicio.SetAll();
        }

        private TrazaItemListener GetItemListener(Traza traza)
        {
            var _ItemListener = new TrazaItemListener();

            _ItemListener.Id = traza.Id;

            _ItemListener.Fecha = traza.Fecha;
            _ItemListener.Bovino = traza.Bovino.Id;
            _ItemListener.Categoria = traza.Bovino.Categoria.Nombre;
            
            return _ItemListener;
        }

        private Traza GetItemListener(TrazaItemListener itemListener)
        {
            var Traza = new Traza();


            Traza.Id = itemListener.Id;
            Traza.Fecha = itemListener.Fecha;

            var lista_bovino = FactoriaAplicaciones<GanadoItemListener>.GetInstance().GetAplicacion().GetAll();
            var bovino = lista_bovino.FirstOrDefault(b => b.Id.Equals(itemListener.Bovino));

            if (bovino != null)
            {
                Traza.Bovino = new Bovino()
                {
                    Id = bovino.Id
                };

                var lista_cat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
                var cat = lista_cat.FirstOrDefault(c => c.Nombre.Equals(itemListener.Categoria));

                if (cat != null)
                {
                    Traza.Bovino.Categoria = new Categorias.Dominio.Categoria()
                    {
                        Id = cat.Id,
                        Nombre = cat.Nombre,
                        Sexo = cat.Sexo,
                        Descripcion = cat.Descripcion
                    };
                }
            }

            return Traza;
        }
        
    }
}
