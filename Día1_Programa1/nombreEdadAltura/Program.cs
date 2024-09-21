using System;

namespace Día1_Programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa tu altura en metros (ej. 1.75):");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hola {nombre}, tienes {edad} años y mides {altura} metros.");
            Console.ReadLine();
        }
    }
}
