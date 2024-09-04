using System;


class Program
{
    static void Main(string[] args)
    {
        Calculos calculos = new Calculos();


        Console.Write("Ingrese el radio del círculo: ");

        double radio = Convert.ToDouble(Console.ReadLine());

        double area = calculos.CalcularArea(radio);

        Console.WriteLine("El área del círculo es: {0}", area);

    }

    public class Calculos
    {
        public int Multiplicacion(int a, int b)
        {
            return (a + b) * (a - b);
        }

        public double CalcularArea(double radio)
        {
            return Math.PI * radio * radio;
        }

        public double CalculoRectangulo(double largo, double ancho)
        {
            return 2 * (largo + ancho);
        }
    }
}
