using System;
using System.Collections.Generic;

namespace Aleatorios
{
    public class Aleatorios
    {
        private Random random = new Random();

        public int GenerarNumero(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public int[] GenerarArregloSinRepetir(int min, int max, int tamaño)
        {
            if (tamaño > max - min + 1)
            {
                Console.WriteLine("El tamaño del arreglo es demasiado grande para el rango especificado.");
                return null;
            }

            HashSet<int> numeros = new HashSet<int>();
            while (numeros.Count < tamaño)
            {
                numeros.Add(GenerarNumero(min, max));
            }

            return numeros.ToArray();
        }
    }
}