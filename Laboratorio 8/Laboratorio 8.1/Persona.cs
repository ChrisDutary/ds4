using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8._1
{
    internal class Persona
    {
        public string Nombre;

        public int Edad;

        public int NIF;

        void Cumpleamos()
        {
            Edad++;
        }

        public Persona(string nombre, int edad, int nIF)
        {
            Nombre = nombre;
            Edad = edad;
            NIF = nIF;
        }
    }
}
