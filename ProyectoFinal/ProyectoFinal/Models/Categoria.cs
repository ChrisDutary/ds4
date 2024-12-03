using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Categoria
    {
        // Constructor para inicializar la colección
        public Categoria()
        {
            Productos = new HashSet<Producto>();
        }

        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre de Categoría")]
        public string Nombre { get; set; }

        // Propiedad de navegación
        public virtual ICollection<Producto> Productos { get; set; }
    }
}