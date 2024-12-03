using DulceriaWeb.Models;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class DetallePedido
    {
        public int DetallePedidoID { get; set; }

        public int PedidoID { get; set; }

        public int ProductoID { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El precio unitario es requerido")]
        [Display(Name = "Precio Unitario")]
        [DataType(DataType.Currency)]
        public decimal PrecioUnitario { get; set; }

        // Referencias a otras clases
        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }
    }
}