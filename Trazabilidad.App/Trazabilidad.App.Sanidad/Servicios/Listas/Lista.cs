﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.App.Ganado.Dominio;

namespace Trazabilidad.App.Sanidad.Servicios
{
    public class Lista<T>: List<T>
    {
        public Lista(T[] items)
            : base(items)
        {
        }
    }
}