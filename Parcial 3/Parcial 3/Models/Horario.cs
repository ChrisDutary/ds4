using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_3.Models
{
    public class Horario
    {
        public int ID_Horario { get; set; }
        public int ID_Obra { get; set; }
        public int ID_Sala { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora_Inicio { get; set; }
        public TimeSpan Hora_Fin { get; set; }
    }
}