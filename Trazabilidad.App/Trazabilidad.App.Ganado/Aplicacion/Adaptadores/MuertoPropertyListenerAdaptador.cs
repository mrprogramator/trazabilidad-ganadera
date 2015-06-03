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
    public class MuertoPropertyListenerAdaptador: IGanadoPropertyListenerAdaptador<MuertoItemListener>
    {
        private static GanadoPropertyListener<MuertoItemListener> _PropertyListenerMuertos;

        public MuertoPropertyListenerAdaptador()
        {
        }

        public GanadoPropertyListener<MuertoItemListener> GetAll()
        {
            if (_PropertyListenerMuertos == null)
            {
                var lista_muertos = FactoriaServiciosLocales<BovinoMuerto>.GetInstance().GetServicio().GetAll();

                var items = new List<MuertoItemListener>();

                foreach (var bovino in lista_muertos)
                {
                    var myItem = GetItemListener(bovino);
                    myItem.GetCode(myItem);
                    items.Add(myItem);
                }

                _PropertyListenerMuertos = new GanadoPropertyListener<MuertoItemListener>(items.ToArray());
            }
            return _PropertyListenerMuertos;
        }

        public void SetAll()
        {
            var servicio = FactoriaServiciosLocales<BovinoMuerto>.GetInstance().GetServicio();
            var lista_ganado = servicio.GetAll();

            foreach (var item in _PropertyListenerMuertos)
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

        private MuertoItemListener GetItemListener(BovinoMuerto _Bovino)
        {
            if (_Bovino.Muerte == null)
                return null;

            var _ItemListener = new MuertoItemListener();

            _ItemListener.Id = _Bovino.Id;

            _ItemListener.Categoria = _Bovino.Categoria.Nombre;

            _ItemListener.Sexo = _Bovino.Categoria.Sexo;

            _ItemListener.Salida = _Bovino.Muerte.Fecha;

            if (_Bovino.Muerte.Causa != null)
            {
                _ItemListener.Causa = _Bovino.Muerte.Causa;
            }

            return _ItemListener;
        }

        private BovinoMuerto GetItemListener(MuertoItemListener itemListener)
        {
            var bovinoMuerto = new BovinoMuerto();

            bovinoMuerto.Id = itemListener.Id;
            bovinoMuerto.Muerte = new Muerte()
            {
                Fecha = itemListener.Salida,
                Causa = itemListener.Causa
            };

            var lista_cat = Categorias.Aplicacion.CategoriaPropertyListenerAdaptador.GetInstance().GetAll();
            var cat = lista_cat.FirstOrDefault(c => c.Nombre.Equals(itemListener.Categoria));

            if (cat != null)
            {
                bovinoMuerto.Categoria = new Categoria()
                {
                    Id = cat.Id,
                    Nombre = cat.Nombre,
                    Sexo = cat.Sexo,
                    Descripcion = cat.Descripcion
                };
            }
            
            return bovinoMuerto;
        }

        private BovinoMuerto UpdateItemListener(BovinoMuerto bovinoMuerto, MuertoItemListener itemListener)
        {
            bovinoMuerto.Muerte.Fecha = itemListener.Salida;
            bovinoMuerto.Muerte.Causa = itemListener.Causa;
            return bovinoMuerto;
        }
    }
}
