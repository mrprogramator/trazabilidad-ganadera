using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trazabilidad.App.Ganado.Aplicacion
{
    public class GanadoItemListener
    {
        public Int32 Id { get; set; }

        public String Codigo { get; set; }
        
        public String Categoria { get; set; }
        
        public String Sexo { get; set; }

        public GanadoItemListener GetCode(GanadoItemListener item)
        {
            if (item != null)
            {
                if (item.Categoria != null)
                {
                    var str = new StringBuilder();

                    str = str.AppendFormat("{0}{1}",item.Categoria.ToUpper().Substring(0,3),item.Id.ToString().PadLeft(4,'0'));

                    item.Codigo = str.ToString();
                }
            }
            return item;
        }
    }
}
