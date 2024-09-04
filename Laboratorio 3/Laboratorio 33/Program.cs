using System;

class Program
{
    static void Main(string[] args)
    {

        Calculos calculos = new Calculos();

        Console.Write("Ingrese el largo del rectangulo: ");
        double largo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el ancho del rectangulo: ");
        double ancho = Convert.ToDouble(Console.ReadLine());

        double perimetro = calculos.CalculoRectangulo(largo, ancho);

        Console.WriteLine("El perímetro del rectángulo es: {0}", perimetro);

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