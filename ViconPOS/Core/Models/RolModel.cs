using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ------------------------------
// Archivo: RolModel.cs
// Propósito: Representa la entidad Rol que define los permisos de acceso dentro del sistema.
namespace ViconPOS.Core.Models
{
    // Clase que representa un rol en el sistema (Ej: Administrador, Cajero, etc.)
    public class RolModel
    {
        public int Id { get; set; } // ID único del rol
        public string Nombre { get; set; } = string.Empty; // Nombre del rol
    }
}
