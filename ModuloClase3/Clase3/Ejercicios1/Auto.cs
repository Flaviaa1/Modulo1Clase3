﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicios1
{
    internal class Auto : Vehiculo
    {
        public Auto(string marca, int modelo) : base(marca, modelo)
        {
        }
        public override string ToString()
        {
            return $"tipo: {base.ToString()}";
        }
    }
}
