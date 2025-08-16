using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViconPOS.Core.Interfaces.Repositories;
using ViconPOS.Core.Interfaces.Services;
using ViconPOS.Core.Models;
// ------------------------------
// Archivo: DatabaseSeeder.cs
// Propósito: Crea datos iniciales si la base está vacía (como un admin).
// ------------------------------
namespace ViconPOS.Infrastructure.Services
{
    public class DatabaseSeeder : IDatabaseSeeder
    {
        private readonly IUsuarioRepository _usuarios;

        public DatabaseSeeder(IUsuarioRepository usuarios)
        {
            _usuarios = usuarios;
        }

        // Ejecuta el sembrado solo si no hay usuarios en la base
        public void Sembrar()
        {
            if (_usuarios.HayUsuarios()) return;

            var admin = new UsuarioModel 
            { 
                Username = "Fabian",
                Email = "alvarofabianvillenam@gmail.com",
                PasswordHash = "fabi",
                RolId = 1, // Asegurate de tener este Rol en la DB
                Activo = true
            };

            _usuarios.Agregar(admin);
        }
    }
}
