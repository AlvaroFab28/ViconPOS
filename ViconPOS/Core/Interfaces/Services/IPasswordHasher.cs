using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ------------------------------
// Archivo: IPasswordHasher.cs
// Propósito: Contrato que define cómo se debe hashear y verificar contraseñas.
// ------------------------------
namespace ViconPOS.Core.Interfaces.Services
{
    public interface IPasswordHasher    // Define operaciones de hash y verificación de contraseñas
    {

        string Hashear(string textoPlano);  // Hashea una contraseña en texto plano y devuelve el hash resultante.
        bool Verificar(string textoPlano, string hash); // Verifica si una contraseña en texto plano coincide con su hash.
    }
}
