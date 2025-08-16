using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ------------------------------
// Archivo: IDatabaseSeeder.cs
// Propósito: Contrato para sembrar datos iniciales en la base de datos.
// ------------------------------
namespace ViconPOS.Core.Interfaces.Services
{
    public interface IDatabaseSeeder
    {
        // Ejecuta el sembrado de datos iniciales (ej: admin, roles base, etc)
        void Sembrar();
    }
}
