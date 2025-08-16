using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViconPOS.Core.Interfaces.Repositories;
using ViconPOS.Core.Interfaces.Services;
using ViconPOS.Core.Models;
// ------------------------------
// Archivo: AuthService.cs
// Propósito: Gestiona la autenticación y la sesión de usuario en memoria
//            utilizando BCrypt para verificar contraseñas.
// ------------------------------
namespace ViconPOS.Infrastructure.Services
{
    // Servicio de autenticación simple (cachea al usuario activo)
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepo;
        private readonly IPasswordHasher _hasher;      // Hasher inyectado
        private UsuarioModel? _usuarioActivo; // Cache de sesión actual ? se usa null para indicar que no hay sesión activa

        public AuthService(IUsuarioRepository usuarioRepo, IPasswordHasher hasher)
        {
            _usuarioRepo = usuarioRepo;
            _hasher = hasher;
        }

        // Intenta iniciar sesión con username y password; devuelve true si es correcto
        public bool IniciarSesion(string username, string password)
        {
            var usuario = _usuarioRepo.ObtenerPorUsername(username);
            if (usuario == null || !usuario.Activo)
                return false;

            // 🔐 Verificamos el password contra el hash almacenado
            var passwordCoincide = _hasher.Verificar(password, usuario.PasswordHash);
            if (!passwordCoincide)
                return false;

            _usuarioActivo = usuario;
            return true;
        }

        // Cierra la sesión limpiando el cache
        public void CerrarSesion()
        {
            _usuarioActivo = null;
        }

        // Devuelve el usuario actualmente autenticado (o null si no hay sesión)
        public UsuarioModel? ObtenerUsuarioActivo()
        {
            return _usuarioActivo;
        }
    }
}
