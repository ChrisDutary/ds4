using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }

        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock es requerido")]
        [Display(Name = "Stock Disponible")]
        public int Stock { get; set; }

        [Display(Name = "Imagen")]
        public string ImagenURL { get; set; }

        // Referencia a la categoría
        public virtual Categoria Categoria { get; set; }
    }
}