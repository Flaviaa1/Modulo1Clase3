using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicios1
{
    internal class Moto : Vehiculo
    {
        public Moto(string marca, int modelo) : base(marca, modelo)
        {
        }

        public override string ToString()
        {
            return $"clase: moto;  {base.ToString()}" ;
        }
    }
}
