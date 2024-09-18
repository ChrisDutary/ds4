using System;

namespace Laboratorio_7._1
{
    class program
    {
        static void Main(string[] args)
        {

            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepositarTotales();
            Console.ReadKey();
        }
    }
}
