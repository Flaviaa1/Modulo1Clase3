using Clase3.Ejercicios1;
using Clase3.Ejercicios2;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            #region Ejercicio 1


            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de Vehiculo

            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del Vehiculo independientemente de que si es una moto o un auto 

            //Uso
            //ImprimirDatosVehiculo(moto);
            //ImprimirDatosVehiculo(auto);
            #endregion
           Moto moto = new Moto("zanella",1995);
            Auto auto =new Auto("toyota",2024);
            

            ImprimirDatosVehiculo(moto);
            ImprimirDatosVehiculo(auto);
            Console.WriteLine("hola");
           

            #region Ejercicio 2
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca
            #endregion


            BIblioteca bIblioteca = new BIblioteca();
            List<string> todosLosLibros = bIblioteca.traerLibros();
            Console.WriteLine("Loa libros que se encuentran almacenado son:");
             for (int i = 0; i < todosLosLibros.Count; i++)
            {
                Console.WriteLine(todosLosLibros[i]);
            }

            Console.ReadKey();
        }

        

        static void ImprimirDatosVehiculo(Vehiculo V)
        {
            Console.WriteLine(V);
             
        }


    
     }
}

