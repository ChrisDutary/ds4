Imports System

Module Area
    Sub Main()
        Dim radio As Single
        Dim area As Single
        Dim cirunferencia As Single
        Const pi = 3.1415926

        Console.WriteLine("Ingrese el radio: ")
        radio = Console.ReadLine

        area = pi * radio ^ 2
        cirunferencia = 2 * pi * radio

        Console.WriteLine("El area es : {0}", area)
        Console.WriteLine("La circunferencia es: {0}", cirunferencia)

        Console.ReadKey()

    End Sub
End Module
