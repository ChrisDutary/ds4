using DulceriaWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }

        public int UsuarioID { get; set; }

        [Display(Name = "Fecha de Pedido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaPedido { get; set; }

        [Required(ErrorMessage = "El estado del pedido es requerido")]
        [Display(Name = "Estado del Pedido")]
        public string EstadoPedido { get; set; }  // 'Pendiente', 'Confirmado', 'Entregado'

        [Required(ErrorMessage = "El tipo de entrega es requerido")]
        [Display(Name = "Tipo de Entrega")]
        public string TipoEntrega { get; set; }   // 'Delivery', 'Recojo'

        [Display(Name = "Dirección de Entrega")]
        public string DireccionEntrega { get; set; }

        [Required(ErrorMessage = "El monto total es requerido")]
        [Display(Name = "Monto Total")]
        [DataType(DataType.Currency)]
        public decimal MontoTotal { get; set; }

        // Referencias a otras clases
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<DetallePedido> DetallesPedido { get; set; }

        // Constructor
        public Pedido()
        {
            FechaPedido = DateTime.Now;
            DetallesPedido = new HashSet<DetallePedido>();
        }
    }
}