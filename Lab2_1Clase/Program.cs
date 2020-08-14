using System;
using System.Threading.Tasks.Dataflow;

namespace Lab2_1Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int edad=0;
            string nombre, edadCadena;

            Console.WriteLine("Ingrese su Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad: ");
            edadCadena = Console.ReadLine();

            try
            {
                edad = Convert.ToInt32(edadCadena);
            }    
            catch(Exception error)
            {
                Console.WriteLine(error);
            }


            edad = edad + 1;

            Console.WriteLine("Su nombre es: "+nombre+" Su edad el año que viene sera: "+edad);

            Console.ReadKey();
        }
    }
}
