using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViconPOS.Core.Models;
// ------------------------------
// Archivo: IUsuarioRepository.cs
// Propósito: Contrato de acceso a datos (CRUD) para la entidad Usuario.
// ------------------------------
namespace ViconPOS.Core.Interfaces.Repositories
{
    // Define las operaciones básicas que se pueden realizar sobre Usuarios en la DB
    public interface IUsuarioRepository
    {
        UsuarioModel ObtenerPorId(int id);            // Trae un usuario por ID
        UsuarioModel? ObtenerPorUsername(string username); // Trae un usuario por Username o null
        int Agregar(UsuarioModel usuario);            // Inserta y devuelve el nuevo ID
        void Actualizar(UsuarioModel usuario);        // Actualiza los datos del usuario
        void Eliminar(int id);                        // Borra un usuario por ID
        bool HayUsuarios();

    }
}
