using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_3.Models
{
    public class Funcion
    {
        public int FuncionID { get; set; }
        public int ObraID { get; set; }
        public int SalaID { get; set; }
        public DateTime FechaHora { get; set; }
    }
}