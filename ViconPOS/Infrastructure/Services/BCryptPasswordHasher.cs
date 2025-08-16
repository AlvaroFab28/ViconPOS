using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViconPOS.Core.Interfaces.Services;
// ------------------------------
// Archivo: BCryptPasswordHasher.cs
// Propósito: Implementación de IPasswordHasher usando BCrypt.
// ------------------------------
namespace ViconPOS.Infrastructure.Services
{
    public class BCryptPasswordHasher : IPasswordHasher
    {
        // Hashea la contraseña utilizando BCrypt
        public string Hashear(string textoPlano)
        {
            return BCrypt.Net.BCrypt.HashPassword(textoPlano);
        }

        // Verifica que el texto plano coincida con el hash almacenado
        public bool Verificar(string textoPlano, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(textoPlano, hash);
        }
    }
}
