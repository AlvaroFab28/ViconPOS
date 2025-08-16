using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ------------------------------
// Archivo: BaseRepository.cs
// Propósito: Clase base que guarda la conexión y helpers comunes para los repositorios
// ------------------------------
namespace ViconPOS.Infrastructure.Data
{
    // Clase base para repositorios que maneja la conexión SQLite
    public abstract class BaseRepository
    {
        protected readonly SQLiteConnectionFactory _conexionFactory;

        protected BaseRepository(SQLiteConnectionFactory conexionFactory)
        {
            _conexionFactory = conexionFactory;
        }
    }
}