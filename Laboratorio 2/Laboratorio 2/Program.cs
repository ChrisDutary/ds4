using Laboratorio21;
using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            // Ejemplo utilizando las variables de instancia de clase.
            client.FirstName = "Christian";
            client.LastName = "Dutary";
            client.Age = 23;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

        }
    }

    public class Client
    {
        //Declarando varaibles de instancia en clase.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public string GetFullName()
        {
            //Utilizando variables de instancia dentro de metodos de la clase.
            return FirstName + " " + LastName;

        }


        public class MyClass
        {
            //Declarando variable estatica
            public static int valor;
        }
    }
}


namespace Laboratorio21
{
    public class Program
    {
        public static void Main()
        {
            //Asignado valor a variable estatica.
            MyClass.valor = 1;
            Console.WriteLine(MyClass.valor);

        }
    }
    public class MyClass
    {
        //Declarando variable estatica
        public static int valor;
    }

}
int nombreVariable = 1000;

int valor1 = 28;
interface valor1 = 28; //Declaramos variable1 con un valor de 28
valor2 = valor1; //Asignamos el valor de  variable1 a valor2

valor2 = 30;

//Imprimiendoen consola variables
Console.WriteLine(valor1);
Console.WriteLine(valor2);

Console.WriteLine(valor1);
Console.WriteLine(valor2);


MyClass object1 = new MyClass(); // Creando nueva instancia
object.Nombre = "fulano";
object.Edad = 28;
MyClass object2 = object1; // Asignando una variable a otra


//Creando nueva instancia
MyClass object1 = new MyClass();
object1.Nombre = "Yeison";
object1.Edad = 28;
//Asignando un variable a otra
MyClass object2 = object1;
//este cambio en la propiedad afecta tanto a object1 como bject2;
object2.Nombre = "jose";
//Al imprimir en consola vemos que ambas referencias imprimen el mismo valor Jose.
Console.WriteLine(object2.Nombre);
Console.WriteLine(object1.Nombre);

char caracter = 'A'; //Variable almacenando el caracter de A.
string cadena = "Cadena de caracteres";//Variable almacenando una cadena de caracteres.

bool condicion = true;