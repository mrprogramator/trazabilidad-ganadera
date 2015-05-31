using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Categorias.Servicios.Listas;
using Trazabilidad.App.Categorias.Servicios.Adaptadores;
using Trazabilidad.App.Categorias.Servicios.Interfaces;
using Trazabilidad.App.Categorias.Servicios;
using Trazabilidad.App.Categorias.Dominio;

namespace Trazabilidad.App.Categorias.Aplicacion
{
    public class CategoriaPropertyListenerAdaptador : ICategoriaPropertyListenerAdaptador
    {
        private static CategoriaPropertyListenerAdaptador instance;
        private static CategoriaPropertyListener _PropertyListener;
        
        private CategoriaPropertyListenerAdaptador()
        { 
        }

        public static CategoriaPropertyListenerAdaptador GetInstance()
        {
            if (instance == null)
            {
                instance = new CategoriaPropertyListenerAdaptador();                
            }
            return instance;
        }

        public CategoriaPropertyListener GetAll()
        {
            if (_PropertyListener == null)
            {
                var servicio_cat = FactoriaServiciosLocales.GetInstance().GetServicioCategoria();
                var lista_cat = servicio_cat.GetAll();

                var items = new List<CategoriaItemListener>();

                foreach (var cat in lista_cat)
                {
                    var myItem = GetItemListener(cat);
                    items.Add(myItem);
                }

                _PropertyListener = new CategoriaPropertyListener(items.ToArray());
            }

            List<CategoriaItemListener> list = _PropertyListener;
            list = list.OrderBy(p => p.Id).ToList();
            _PropertyListener = new CategoriaPropertyListener(list.ToArray());
            
            return _PropertyListener;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales.GetInstance().GetServicioCategoria();
            var lista_categoria = servicio.GetAll();

            foreach (var item in _PropertyListener)
            {
                var cat = lista_categoria.FirstOrDefault(b => b.Id.Equals(item.Id));

                if (cat != null)
                {
                    cat = UpdateItemListener(cat, item);
                    continue;
                }

                cat = GetItemListener(item);
                lista_categoria.Add(cat);
            }

            servicio.SetAll();
        }

        private CategoriaItemListener GetItemListener(Categoria _Categoria)
        {
            var _ItemListener = new CategoriaItemListener();
            _ItemListener.Id = _Categoria.Id;
            _ItemListener.Nombre = _Categoria.Nombre.ToString();
            _ItemListener.Sexo = _Categoria.Sexo.ToString();

            if (_Categoria.Sexo.Equals('H'))
            {
                _ItemListener.Sexo = "Hembra";
            }
            else if (_Categoria.Sexo.Equals('M'))
            {
                _ItemListener.Sexo = "Macho";
            }

            _ItemListener.Descripcion = _Categoria.Descripcion;

            return _ItemListener;
        }

        private Categoria GetItemListener(CategoriaItemListener itemListener)
        {
            var categoria = new Categoria()
            {
                Id = itemListener.Id,
                Nombre = itemListener.Nombre,
                Sexo = itemListener.Sexo,
                Descripcion = itemListener.Descripcion
            };

            return categoria;
        }

        private Categoria UpdateItemListener(Categoria categoria, CategoriaItemListener itemListener)
        {
            categoria.Nombre = itemListener.Nombre;
            categoria.Sexo = itemListener.Sexo;
            categoria.Descripcion = itemListener.Descripcion;
            return categoria;
        }
    }
}
