using System.ComponentModel.DataAnnotations;

namespace DulceriaWeb.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
    }
}