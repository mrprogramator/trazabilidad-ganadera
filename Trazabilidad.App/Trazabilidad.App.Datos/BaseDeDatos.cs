using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Trazabilidad.App.Datos
{
    public abstract class BaseDeDatos
    {
        public abstract DataRow GetOne(Int32 id, String table_name, String fields);

        public abstract DataTable GetAll(String table_name, String fields);

        public abstract void SetData(DataTable dt, DataRow row, String table_name);

        public abstract void UpdateData(DataTable dt, DataRow row, String table_name);

        public static BaseDeDatos GetInstance()
        {
            // ver la configuración de la base de datos
            return BaseDeDatosPostgres.GetInstance();
        }
    }

    
}
