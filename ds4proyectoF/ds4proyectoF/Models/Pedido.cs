using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ds4proyectoF.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public string NombreCliente { get; set; }
        public string Productos { get; set; }
        public decimal Total { get; set; }
        public bool RetiroLocal { get; set; }
        public bool Delivery { get; set; }
        public string Ubicacion { get; set; }
    }
}