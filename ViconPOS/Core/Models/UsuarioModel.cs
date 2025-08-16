using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ------------------------------
// Archivo: UsuarioModel.cs
// Propósito: Representa la entidad Usuario y sus datos de autenticación.
// ------------------------------
namespace ViconPOS.Core.Models
{
    // Clase que representa a un usuario del sistema
    public class UsuarioModel
    {
        public int Id { get; set; } // ID único del usuario
        public string Username { get; set; } = string.Empty; // Nombre de usuario
        public string Email { get; set; } = string.Empty; // Correo electrónico del usuario
        public string PasswordHash { get; set; } = string.Empty; // Contraseña en forma de hash
        public int RolId { get; set; } // ID del rol al que pertenece
        public bool Activo { get; set; } = true; // Indica si el usuario está activo o no 

        public RolModel? Rol { get; set; } // Referencia al rol (opcional)
    }
}
