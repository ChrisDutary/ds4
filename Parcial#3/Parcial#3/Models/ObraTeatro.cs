using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_3.Models
{
    public class ObraTeatro
    {
        public int ObraID { get; set; }
        public string Titulo { get; set; }
        public int DirectorID { get; set; }
        public string DirectorNombre { get; set; }
        public int GeneroID { get; set; }
        public string GeneroNombre { get; set; }
        public int ClasificacionID { get; set; }
        public string ClasificacionNombre { get; set; }
    }
}