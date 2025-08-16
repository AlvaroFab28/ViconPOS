using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViconPOS.Core.Models;
// ------------------------------
// Archivo: IAuthService.cs
// Propósito: Contrato de servicio para manejar la autenticación y sesión.
// ------------------------------
namespace ViconPOS.Core.Interfaces.Services
{
    // Define las operaciones de autenticación y gestión de sesión de usuario
    public interface IAuthService
    {
        bool IniciarSesion(string username, string password); // Devuelve true si el login es exitoso
        void CerrarSesion();                                  // Finaliza la sesión actual
        UsuarioModel? ObtenerUsuarioActivo();                 // Devuelve el usuario actualmente logueado
    }
}
