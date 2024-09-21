using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la base del triángulo:");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa la altura del triángulo:");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            double area = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine($"El área del triángulo es: {area}");

            Console.ReadLine();
        }
    }
}
