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
    public class VendidoPropertyListenerAdaptador : IGanadoPropertyListenerAdaptador<VendidoItemListener>
    {
        private static GanadoPropertyListener<VendidoItemListener> _PropertyListenerVendidos;

        public VendidoPropertyListenerAdaptador()
        {
        }

        public GanadoPropertyListener<VendidoItemListener> GetAll()
        {
            if (_PropertyListenerVendidos == null)
            {
                var lista_vendidos = FactoriaServiciosLocales<BovinoVendido>.GetInstance().GetServicio().GetAll();

                var items = new List<VendidoItemListener>();

                foreach (var bovino in lista_vendidos)
                {
                    var myItem = GetItemListener(bovino);
                    items.Add(myItem);
                }

                _PropertyListenerVendidos = new GanadoPropertyListener<VendidoItemListener>(items.ToArray());
            }
            return _PropertyListenerVendidos;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales<BovinoVendido>.GetInstance().GetServicio();
            var lista_ganado = servicio.GetAll();

            foreach (var item in _PropertyListenerVendidos)
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

        private VendidoItemListener GetItemListener(BovinoVendido _Bovino)
        {
            if (_Bovino.Venta == null)
                return null;

            var _ItemListener = new VendidoItemListener();

            _ItemListener.Id = _Bovino.Id;

            _ItemListener.Categoria = _Bovino.Categoria.Nombre;

            _ItemListener.Sexo = _Bovino.Categoria.Sexo;

            _ItemListener.Salida = _Bovino.Venta.Fecha;

            if (_Bovino.Venta.Destino != null)
            {
                _ItemListener.Destino = _Bovino.Venta.Destino;
            }

            _ItemListener.Observaciones = _Bovino.Venta.Observaciones;

            _ItemListener.Precio = _Bovino.Venta.Precio;

            return _ItemListener;
        }

        private BovinoVendido GetItemListener(VendidoItemListener itemListener)
        {
            var bovinoVendido = new BovinoVendido();

            bovinoVendido.Id = itemListener.Id;

            bovinoVendido.Venta = new Venta()
            {
                Fecha = itemListener.Salida,
                Destino = itemListener.Destino,
                Observaciones = itemListener.Observaciones,
                Precio = itemListener.Precio
            };

            var lista_cat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
            var cat = lista_cat.FirstOrDefault(c => c.Nombre.Equals(itemListener.Categoria));
            if (cat != null)
            {
                bovinoVendido.Categoria = new Categoria()
                {
                    Id = cat.Id,
                    Nombre = cat.Nombre,
                    Sexo = cat.Sexo,
                    Descripcion = cat.Descripcion
                };
            }
            
            return bovinoVendido;
        }

        private BovinoVendido UpdateItemListener(BovinoVendido bovinoVendido, VendidoItemListener itemListener)
        {
            bovinoVendido.Venta.Fecha = itemListener.Salida;
            bovinoVendido.Venta.Destino = itemListener.Destino;
            bovinoVendido.Venta.Observaciones = itemListener.Observaciones;
            bovinoVendido.Venta.Precio = itemListener.Precio;

            return bovinoVendido;
        }
    }
}
