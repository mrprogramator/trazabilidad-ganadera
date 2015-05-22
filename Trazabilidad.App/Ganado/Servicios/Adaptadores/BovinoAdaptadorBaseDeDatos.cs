using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Datos;
using Trazabilidad.App.Ganado.Dominio;
using Trazabilidad.App.Ganado.Servicios.Interfaces;
using Trazabilidad.App.Ganado.Servicios.Listas;
using System.Data;

namespace Trazabilidad.App.Ganado.Servicios.Adaptadores
{
    public class BovinoAdaptadorBaseDeDatos : IBovinoAdaptador
    {
        private BaseDeDatos bd;

        public BovinoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Bovino GetById(Int32 id)
        {
            var row = bd.GetOne(
                id,
                "bovino",
                "id, sexo, madre_id, padre_id, estado, estancia_id, categoria_id");

            var item = DataRowGanado(row);

            return item;
        }

        public BovinoLista GetAll()
        {
            var dt = bd.GetAll("bovino",
                "id, sexo, madre_id, padre_id, estado, estancia_id, categoria_id");

            var items = new List<Bovino>();

            foreach (DataRow row in dt.Rows)
            {
                var bovino = DataRowGanado(row);

                items.Add(bovino);
            }

            var lista = new BovinoLista(items.ToArray());

            return lista;
        }

        public void setData(String[] Data)
        { 
        }

        private Bovino DataRowGanado(DataRow row)
        {
            var bovino = new Bovino()
            {
                Id = (Int32)row["id"],
                Sexo = ((String)row["sexo"]).First(),
                Estado = (Boolean)row["estado"],
                
            };
            
            var servicio_cat = FactoriaServiciosLocales.GetInstance().GetServicioCategoria();
            var servicio_nac = FactoriaServiciosLocales.GetInstance().GetServicioNacimiento();
            var servicio_compra = FactoriaServiciosLocales.GetInstance().GetServicioCompra();
            var servicio_muerte = FactoriaServiciosLocales.GetInstance().GetServicioMuerte();
            var servicio_venta = FactoriaServiciosLocales.GetInstance().GetServicioVenta();
                        
            var lista_cat = servicio_cat.GetAll();
            var lista_nac = servicio_nac.GetAll();
            var lista_compra = servicio_compra.GetAll();
            var lista_muerte = servicio_muerte.GetAll();
            var lista_venta = servicio_venta.GetAll();

            bovino.Categoria = lista_cat.Find(x => x.Id.Equals( (Int32)row["categoria_id"] ));

            if (!(row["madre_id"] is DBNull))
            {
                bovino.Madre = new Bovino()
                {
                    Id = (Int32)row["madre_id"]
                };
            }

            if (!(row["padre_id"] is DBNull))
            {
                bovino.Padre = new Bovino()
                {
                    Id = (Int32)row["padre_id"]
                };
            }

            var nac = lista_nac.Find(x => x.Bovino.Id.Equals(bovino.Id));
            if (nac != null)
            {
                bovino.Entrada = nac;
            }
            else
            {
                var compra = lista_compra.Find(x => x.Bovino.Id.Equals(bovino.Id));
                if (compra != null)
                {
                    bovino.Entrada = compra;
                }
            }

            var muerte = lista_muerte.Find(x => x.Bovino.Id.Equals(bovino.Id));
            if (muerte != null)
            {
                bovino.Salida = muerte;
            }
            else
            {
                var venta = lista_venta.Find(x => x.Bovino.Id.Equals(bovino.Id));
                if (venta != null)
                {
                    bovino.Salida = venta;
                }
            }
            return bovino;            
        }
    }
}
