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
    public class CompradoPropertyListenerAdaptador : IGanadoPropertyListenerAdaptador<CompradoItemListener>
    {
        private static GanadoPropertyListener<CompradoItemListener> _PropertyListenerComprados;

        public CompradoPropertyListenerAdaptador()
        {
        }

        public GanadoPropertyListener<CompradoItemListener> GetAll()
        {
            if (_PropertyListenerComprados == null)
            {
                var lista_comprados = FactoriaServiciosLocales<BovinoComprado>.GetInstance().GetServicio().GetAll();

                var items = new List<CompradoItemListener>();

                foreach (var bovino in lista_comprados)
                {
                    var myItem = GetItemListener(bovino);
                    items.Add(myItem);
                }

                _PropertyListenerComprados = new GanadoPropertyListener<CompradoItemListener>(items.ToArray());
            }
            return _PropertyListenerComprados;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales<BovinoComprado>.GetInstance().GetServicio();
            var lista_ganado = servicio.GetAll();

            foreach (var item in _PropertyListenerComprados)
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


        private CompradoItemListener GetItemListener(BovinoComprado _Bovino)
        {
            var _ItemListener = new CompradoItemListener();

            _ItemListener.Id = _Bovino.Id;

            _ItemListener.Categoria = _Bovino.Categoria.Nombre;

            _ItemListener.Sexo = _Bovino.Categoria.Sexo;

            _ItemListener.Entrada = _Bovino.Compra.Fecha;

            _ItemListener.Precio = _Bovino.Compra.Precio;

            if (_Bovino.Compra.Observaciones != null)
            {
                _ItemListener.Observaciones = _Bovino.Compra.Observaciones;
            }

            return _ItemListener;
        }

        private BovinoComprado GetItemListener(CompradoItemListener itemListener)
        {
            var bovinoComprado = new BovinoComprado();


            bovinoComprado.Id = itemListener.Id;

            var lista_cat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
            var cat = lista_cat.FirstOrDefault(c => c.Nombre.Equals(itemListener.Categoria));

            if (cat != null)
            {
                bovinoComprado.Categoria = new Categoria()
                {
                    Id = cat.Id,
                    Nombre = cat.Nombre,
                    Sexo = cat.Sexo,
                    Descripcion = cat.Descripcion
                };
            }

            bovinoComprado.Compra = new Compra()
            {
                Fecha = itemListener.Entrada,
                Observaciones = itemListener.Observaciones,
                Precio = itemListener.Precio,
            }; 

            return bovinoComprado;
        }

        private BovinoComprado UpdateItemListener(BovinoComprado bovinoComprado, CompradoItemListener itemListener)
        {
            var lista_cat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();

            var cat = lista_cat.FirstOrDefault(c => c.Nombre.Equals(itemListener.Categoria));

            if (cat != null)
            {
                bovinoComprado.Categoria = new Categoria()
                {
                    Id = cat.Id,
                    Nombre = cat.Nombre,
                    Sexo = cat.Sexo,
                    Descripcion = cat.Descripcion
                };
            }

            bovinoComprado.Compra.Fecha = itemListener.Entrada;
            bovinoComprado.Compra.Observaciones = itemListener.Observaciones;
            bovinoComprado.Compra.Precio = itemListener.Precio;

            return bovinoComprado;
        }


    }
}
