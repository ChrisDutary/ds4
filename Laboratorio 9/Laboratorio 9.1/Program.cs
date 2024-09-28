using System;

namespace lab9
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Forma de pago: efectivo/tarjeta: ");
            string formaPago = Console.ReadLine(). ToLower();

            if (formaPago =="tarjeta")
            {
                Console.Write("Ingrese el numero de cuenta (16 digitos:");
                string numeroCuenta = Console.ReadLine();

                if (numeroCuenta.Length != 16)
                {
                    Console.WriteLine("el numero de la cuenta se paso de 16 digitos intente, nuevamente");
                }
                else
                {
                    Console.WriteLine("Pago realizado con tarjeta");
                }
            }
            else if (formaPago == "efectivo")
            {
                Console.WriteLine("Pago realizado en efecito.");
            }
            else
            {
                Console.WriteLine("Forma de pago invalido.");
            } 
                
        }
    }
}