using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Ganado.Dominio
{
	public class BovinoMuerto : Bovino
	{
        public Muerte Muerte { get; set; }
	}
}