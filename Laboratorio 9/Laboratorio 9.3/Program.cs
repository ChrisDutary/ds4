using System;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado 1: ");
            double lado1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 2: ");
            double lado2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 3: ");
            double lado3 = double.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman un triángulo.");
            }
        }
    }
}