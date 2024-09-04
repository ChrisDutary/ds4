using System;


class Program
{
    static void Main(string[] args)
    {
        int a, b;

        Calculos calculos = new Calculos();


        Console.Write("Ingrese el primer número: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        b = Convert.ToInt32(Console.ReadLine());


        int resultado  = calculos.Multiplicacion(a, b);


        Console.WriteLine("El resultado de la operación {0} ",resultado);
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
