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
    public class BaseDeDatosPostgres : BaseDeDatos
    {
        private static BaseDeDatosPostgres bdp_instance;

        private BaseDeDatosPostgres()
        {
        }

        public static BaseDeDatosPostgres GetInstance()
        {
            if (bdp_instance == null)
            {
                bdp_instance = new BaseDeDatosPostgres();
            }
            return bdp_instance;
        }

        public override DataRow GetOne(Int32 id, String table_name, String fields)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=" + Constants.SERVER + "; Port=" + Constants.PORT + "; User Id= " + Constants.USER + "; Password=" + Constants.PASS + "; Database=" + Constants.DB))
            {
                conn.Open();

                // Declare the parameter in the query string
                using (NpgsqlCommand command = new NpgsqlCommand("select " + fields + " from " + table_name + " where id = :column1", conn))
                {
                    // Now add the parameter to the parameter collection of the command specifying its type.
                    command.Parameters.Add(new NpgsqlParameter("column1", NpgsqlDbType.Integer));

                    // Now, prepare the statement.
                    command.Prepare();

                    // Now, add a value to it and later execute the command as usual.
                    command.Parameters[0].Value = id;

                    var dt = new DataTable();

                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        dt.Load(dr);

                        return dt.Rows[0];
                    }
                }
            }
        }

        public override DataTable GetAll(String table_name, String fields)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=" + Constants.SERVER + "; Port=" + Constants.PORT + "; User Id= " + Constants.USER + "; Password=" + Constants.PASS + "; Database=" + Constants.DB))
            {
                conn.Open();

                // Declare the parameter in the query string
                using (NpgsqlCommand command = new NpgsqlCommand("select " + fields + " from " + table_name, conn))
                {
                    // Now, prepare the statement.
                    command.Prepare();

                    var dt = new DataTable();

                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        dt.Load(dr);
                        return dt;
                    }
                }
            }
        }
    }
}
