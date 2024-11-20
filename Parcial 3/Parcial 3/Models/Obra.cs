using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_3.Models
{
    public class Obra
    {
        public int ID_Obra { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string Clasificacion { get; set; }
    }
}