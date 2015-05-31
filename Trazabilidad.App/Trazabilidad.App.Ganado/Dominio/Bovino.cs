using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Categorias.Dominio;

namespace Trazabilidad.App.Ganado.Dominio
{
	public class Bovino 
	{
        [System.ComponentModel.Description("id")]
        public Int32 Id { get; set; }

        private Bovino _padre;

        private Bovino _madre;
               
        public virtual Categoria Categoria { get; set; }

        public virtual Bovino Padre 
        {
            get
            { 
                return _padre; 
            } 
            set
            {
                if (value.Categoria.Sexo.Equals("Macho"))
                {
                    _padre = value;
                }
            }
        }

        public virtual Bovino Madre
        {
            get
            {
                return _madre;
            }
            set
            {
                if (value.Categoria.Sexo.Equals("Hembra"))
                {
                    _madre = value;
                }
            }
        }
	}
}