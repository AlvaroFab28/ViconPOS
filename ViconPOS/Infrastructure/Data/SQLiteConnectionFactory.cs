using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ------------------------------
// Archivo: SQLiteConnectionFactory.cs
// Propósito: Proporciona conexión SQLite a partir del archivo configurado
// ------------------------------
namespace ViconPOS.Infrastructure.Data
{
    // Crea y configura conexiones a la base de datos SQLite
    public class SQLiteConnectionFactory
    {
        private readonly string _connectionString;

        public SQLiteConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SQLiteConnection CrearConexion()
        {
            var conexion = new SQLiteConnection(_connectionString);
            conexion.Open();
            return conexion;
        }
    }
}
