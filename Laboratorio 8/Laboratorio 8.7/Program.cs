using System;

namespace lab8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Corrio la aplicacion");
        }
    }

    sealed class ClaseBase
    {
        public void test()
        {

        }

        public void moretesting()
        {

        }
    }

    class ClaseHijo : ClaseBase // sale error porq la clase esta sealed
    {

    }
}