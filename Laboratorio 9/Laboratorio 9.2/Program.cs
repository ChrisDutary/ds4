using System;

namespace lab9
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros pares o divisibles entre 3 del 1 al 100:");
            for (int i = 1; i <= 100; i++)
            {
                if (1 % 2 == 0 || i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}