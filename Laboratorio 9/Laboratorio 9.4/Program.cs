using System;

namespace lab9
{
    class program
    {
        public class Aleatorio
        {
            private Random random = new Random();

            public int GenerarNumero(int min, int max)
            {
                return random.Next(min, max + 1);
            }

            public int[] GenerarArreglo(int min,int max, int tamano)
            {
                int[] arreglo = new int[tamano];
                for (int i = 0; i < tamano;  i++)
                {
                    arreglo[i] = GenerarNumero(min, max);
                }
                return arreglo;
            }

            public int[] GenerarArregloSinRepetir(int min, int max, int tamano)
            {

            }
            
            

        }
    }
}