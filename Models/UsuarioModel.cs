using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_caldas.Models
{
    public class UsuarioModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "El Nombre es obigatorio.")] 
        public required string Usuario_Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio.")]
        public required string Usuario_Apellido { get; set; }
        [Required(ErrorMessage = "El Correo es bligatorio.")] 
        public required string Usuario_Correo { get; set; }
        [Required(ErrorMessage = "La Contraseña es obligatoria.")] 
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres.")]
        public required string Usuario_Contrasena { get; set; } 
    }
}