using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViconPOS.Core.Interfaces.Repositories;
using ViconPOS.Core.Interfaces.Services;
using ViconPOS.Core.Models;
using ViconPOS.Infrastructure.Data;
// ------------------------------
// Archivo: UsuarioRepository.cs
// Propósito: Implementa las operaciones CRUD de Usuario usando SQLite.
// ------------------------------
namespace ViconPOS.Infrastructure.Repositories
{
    // Repositorio concreto de Usuario    
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        private readonly IPasswordHasher _hasher;
        public UsuarioRepository(SQLiteConnectionFactory conexionFactory, IPasswordHasher hasher) : base(conexionFactory)
        {
            _hasher = hasher;
        }

        // Trae un usuario por Id
        public UsuarioModel ObtenerPorId(int id)
        {
            using var conn = _conexionFactory.CrearConexion();
            using var cmd = new SQLiteCommand("SELECT Id, Username, Email, PasswordHash, RolId, Activo FROM Usuarios WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            using var reader = cmd.ExecuteReader();
            return reader.Read() ? MapearUsuario(reader) : throw new InvalidOperationException("Usuario no encontrado");
        }

        // Trae un usuario por Username o null si no existe
        public UsuarioModel? ObtenerPorUsername(string username)
        {
            using var conn = _conexionFactory.CrearConexion();
            using var cmd = new SQLiteCommand("SELECT Id, Username, Email, PasswordHash, RolId, Activo FROM Usuarios WHERE Username = @Username", conn); //
            cmd.Parameters.AddWithValue("@Username", username);
            using var reader = cmd.ExecuteReader();
            return reader.Read() ? MapearUsuario(reader) : null;
        }

        // Inserta un usuario y devuelve su nuevo Id
        public int Agregar(UsuarioModel usuario)
        {
            using var conn = _conexionFactory.CrearConexion();
            using var tx = conn.BeginTransaction();

            // Hasheamos la contraseña antes de guardar
            var hash = _hasher.Hashear(usuario.PasswordHash);

            var insertCmd = new SQLiteCommand(@"INSERT INTO Usuarios (Username, Email, PasswordHash, RolId, Activo)
                                                VALUES (@Username, @Email, @PasswordHash, @RolId, @Activo);", conn, tx);
            insertCmd.Parameters.AddWithValue("@Username", usuario.Username);
            insertCmd.Parameters.AddWithValue("@Email", usuario.Email);
            insertCmd.Parameters.AddWithValue("@PasswordHash", hash);
            insertCmd.Parameters.AddWithValue("@RolId", usuario.RolId);
            insertCmd.Parameters.AddWithValue("@Activo", usuario.Activo ? 1 : 0);
            insertCmd.ExecuteNonQuery();

            var idCmd = new SQLiteCommand("SELECT last_insert_rowid();", conn, tx);
            var newId = (long)idCmd.ExecuteScalar();
            tx.Commit();
            return (int)newId;
        }

        // Actualiza los datos de un usuario existente
        public void Actualizar(UsuarioModel usuario)
        {
            using var conn = _conexionFactory.CrearConexion();
            // Hasheamos la nueva contraseña (si el caller ya envía hash, no pasa nada malo)
            var hash = _hasher.Hashear(usuario.PasswordHash);
            var cmd = new SQLiteCommand(@"UPDATE Usuarios
                                          SET Username = @Username,
                                              Email = @Email,
                                              PasswordHash = @PasswordHash,
                                              RolId = @RolId,
                                              Activo = @Activo
                                          WHERE Id = @Id;", conn);
            cmd.Parameters.AddWithValue("@Username", usuario.Username);
            cmd.Parameters.AddWithValue("@Email", usuario.Email);
            cmd.Parameters.AddWithValue("@PasswordHash", hash);
            cmd.Parameters.AddWithValue("@RolId", usuario.RolId);
            cmd.Parameters.AddWithValue("@Activo", usuario.Activo ? 1 : 0);
            cmd.Parameters.AddWithValue("@Id", usuario.Id);
            cmd.ExecuteNonQuery();
        }

        // Elimina un usuario por Id
        public void Eliminar(int id)
        {
            using var conn = _conexionFactory.CrearConexion();
            using var cmd = new SQLiteCommand("DELETE FROM Usuarios WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        // Mapea un registro de la DB a UsuarioModel
        private static UsuarioModel MapearUsuario(SQLiteDataReader reader) // mapear significa convertir un registro de la base de datos a un objeto UsuarioModel
        {
            return new UsuarioModel
            {
                Id = reader.GetInt32(0),
                Username = reader.GetString(1),
                Email = reader.GetString(2),
                PasswordHash = reader.GetString(3),
                RolId = reader.GetInt32(4),
                Activo = reader.GetInt32(5) == 1
            };
        }

        public bool HayUsuarios()
        {
            using var conn = _conexionFactory.CrearConexion();
            using var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Usuarios;", conn);
            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}

