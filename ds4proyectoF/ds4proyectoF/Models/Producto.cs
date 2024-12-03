using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ds4proyectoF.Models
{

public class Producto
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioPedazo { get; set; }
        public decimal? PrecioEntero { get; set; }
    }
}