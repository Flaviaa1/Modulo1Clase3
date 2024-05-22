using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicios2
{
    public class BIblioteca: Ibiblioteca
    {
        public List<string> Libros { get; set; }

        public BIblioteca()
        {
            Libros = new List<string>()
            {
                "Cien años de soledad",
                "1984",
                "Don Quijote de la Mancha",
                "Matar a un ruiseñor",
                "El Gran Gatsby",
                "Orgullo y prejuicio",
                "Crónica de una muerte anunciada",
                "El señor de los anillos",
                "Los miserables",
                "La sombra del viento"
            };
        }

        public List<string> traerLibros()
        {
           return Libros;
        }
    }
}

