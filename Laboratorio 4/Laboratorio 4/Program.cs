﻿using System;

class program
{
    static void Main(String[] args)
    {
        int n, x;
        string linea;
        Console.Write("Ingrese el valorr de n:");
        linea = Console.ReadLine();
        n = int.Parse(linea);
        x = 1;

        while (x <= n)
        {
            Console.Write(x);
            Console.Write(" , ");
            x = x + 1;
        }
        Console.ReadKey();
    }
}