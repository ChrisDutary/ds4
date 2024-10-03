using System;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz (N, debe ser par): ");
            int N = int.Parse(Console.ReadLine());
            if (N % 2 != 0)
            {
                Console.WriteLine("N debe ser un número par.");
                return;
            }
            int[,] matriz = new int[N, N];
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (N <= 4 && (i < 1 || i >= N - 1 || j == 0 || j == N - 1))
                    {
                        matriz[i, j] = 0;
                    }
                    else if (N > 4 && (i < 2 || i >= N - 2 || j == 0 || j == N - 1))
                    {
                        matriz[i, j] = 0;
                    }
                    else
                    {
                        matriz[i, j] = random.Next(101, 200);
                    }
                }
            

        }
            int multiplicar = 1;
            int mitad = N / 2;
            for (int i = mitad - 1; i <= mitad; i++)
            {
                for (int j = mitad - 1; j <= mitad; j++)
                {
                    multiplicar *= matriz[i, j];
                }
            }
            Console.WriteLine("Matriz:");
            ImprimirMatriz(matriz);
            Console.WriteLine("Resultado de la multiplicación: " + multiplicar);
        }
        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}