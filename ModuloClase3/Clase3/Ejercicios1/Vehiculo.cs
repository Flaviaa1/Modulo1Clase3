using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicios1
{
    internal class Vehiculo
    {
        public string Marca { get;  set; }
        public int Modelo { get;  set;}

        public Vehiculo(string marca, int modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo{Modelo}";
        }

    }
}
