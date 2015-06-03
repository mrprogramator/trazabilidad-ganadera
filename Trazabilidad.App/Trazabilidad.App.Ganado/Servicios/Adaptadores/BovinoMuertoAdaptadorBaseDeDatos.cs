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
using Trazabilidad.App.Categorias.Servicios;

namespace Trazabilidad.App.Ganado.Servicios.Adaptadores
{
    public class BovinoMuertoAdaptadorBaseDeDatos : IAdaptador<BovinoMuerto>
    {
        private BaseDeDatos bd;
        private static Lista<BovinoMuerto> _BovinoMuertoLista;

        public BovinoMuertoAdaptadorBaseDeDatos(BaseDeDatos bd)
        {
            this.bd = bd;
        }

        public Lista<BovinoMuerto> Generate()
        {
            return _BovinoMuertoLista;
        }

        public Lista<BovinoMuerto> GetAll()
        {
            if (_BovinoMuertoLista == null)
            {
                var dt = bd.GetAll(typeof(Muerte).Name.ToString(), "id, bovino_id, fecha, causa");

                var items = new List<BovinoMuerto>();

                foreach (DataRow row in dt.Rows)
                {
                    var bovino = DataRowGanado(row);

                    if (bovino == null) continue;

                    items.Add(bovino);

                }

                _BovinoMuertoLista = new Lista<BovinoMuerto>(items.ToArray());
            }

            return _BovinoMuertoLista;
        }

        public void SetAll()
        {
            var dt = bd.GetAll(typeof(Bovino).Name, "id, categoria_id, padre_id, madre_id, entrada, salida");

            var dt_muerte = bd.GetAll(typeof(Muerte).Name, "id, bovino_id, fecha, causa");
            
            var keys = new DataColumn[1];

            keys[0] = dt.Columns["id"];
            dt.PrimaryKey = keys;

            keys[0] = dt_muerte.Columns["id"];
            dt_muerte.PrimaryKey = keys;

            foreach (var bovino in _BovinoMuertoLista)
            {
                var row = DataRowGanado(dt, bovino);

                if (dt.Rows.Contains(row["id"]))
                {
                    bd.UpdateData(dt, row, "bovino");
                }
                else
                {
                    throw new Exception("No existe registro de entrada del bovino muerto.");
                }

                var row_muerte = DataRowMuerte(dt_muerte, bovino);

                if (dt_muerte.Rows.Contains(row_muerte["id"]))
                {
                    bd.UpdateData(dt_muerte, row_muerte, "muerte");
                }
                else
                {
                    bd.SetData(dt_muerte, row_muerte, "muerte");
                }
            }
        }

        private BovinoMuerto DataRowGanado(DataRow row)
        {
            var bovino_muerto = new BovinoMuerto();

            var servicio_bovino = FactoriaServiciosLocales<BovinoNacido>.GetInstance().GetServicio();
            var bovino_lista = servicio_bovino.GetAll();

            if (bovino_lista.Exists(b => b.Id.Equals((Int32)row["bovino_id"])))
            {
                var bovino_nacido = bovino_lista.Find(b => b.Id.Equals((Int32)row["bovino_id"]));

                bovino_muerto = new BovinoMuerto()
                {
                    Id = bovino_nacido.Id,
                    Categoria = bovino_nacido.Categoria,
                    Madre = bovino_nacido.Madre,
                    Padre = bovino_nacido.Padre
                };

                var muerte = new Muerte()
                {
                    Id = (Int32)row["id"],
                    Fecha = (DateTime)row["fecha"]
                };

                if (!(row["causa"] is DBNull))
                {
                    muerte.Causa = (String)row["causa"];
                }

                bovino_muerto.Muerte = muerte;

                bovino_lista.Remove(bovino_nacido);

            }
            else
            {
                var servicio_bovino_comprado = FactoriaServiciosLocales<BovinoComprado>.GetInstance().GetServicio();
                var bovino_comprado_lista = servicio_bovino_comprado.GetAll();

                if (bovino_comprado_lista.Exists(b => b.Id.Equals((Int32)row["bovino_id"])))
                {
                    var bovino_comprado = bovino_comprado_lista.Find(b => b.Id.Equals((Int32)row["bovino_id"]));

                    bovino_muerto = new BovinoMuerto() 
                    {
                        Id = bovino_comprado.Id,
                        Categoria = bovino_comprado.Categoria                        
                    };

                    var muerte = new Muerte()
                    {
                        Id = (Int32)row["id"],
                        Fecha = (DateTime)row["fecha"]
                    };

                    if (!(row["causa"] is DBNull))
                    {
                        muerte.Causa = (String)row["causa"];
                    }

                    bovino_muerto.Muerte = muerte;

                    bovino_comprado_lista.Remove(bovino_comprado);
                }
            }
            return bovino_muerto;
        }
        private DataRow DataRowGanado(DataTable dt,BovinoMuerto bovinoMuerto)
        {
            var row = dt.NewRow();

            row["id"] = bovinoMuerto.Id;
            
            row["salida"] = bovinoMuerto.Muerte.Fecha;

            return row;
        }
        private DataRow DataRowMuerte(DataTable dt_muerte, BovinoMuerto bovinoMuerto)
        {
            var row = dt_muerte.NewRow();
            row["id"] = bovinoMuerto.Muerte.Id;
            row["fecha"] = bovinoMuerto.Muerte.Fecha;
            row["bovino_id"] = bovinoMuerto.Id;
            row["causa"] = bovinoMuerto.Muerte.Causa;
            return row;
        }
    }
}
