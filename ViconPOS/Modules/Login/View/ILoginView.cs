using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ------------------------------
// Archivo: ILoginView.cs
// Propósito: Contrato de la vista de Login para el patrón MVP.
// ------------------------------
namespace ViconPOS.Modules.Login.View
{
    // Vista del formulario de login. Expone eventos y datos a leer por el Presenter.
    public interface ILoginView
    {
        // Usuario escrito en el TextBox
        string Usuario { get; }
        // Contraseña escrita en el TextBox
        string Contraseña { get; }

        // Se dispara cuando el usuario hace clic en "Ingresar"
        event Action IngresarClick;
        // Se dispara cuando cambia el check de "Mostrar contraseña" (true = mostrar)
        event Action<bool> MostrarPasswordCambio;

        // Muestra un mensaje de error en la UI
        void MostrarError(string mensaje);
        // Limpia cualquier mensaje de error
        void LimpiarError();
        // (Opcional) Cierra el formulario cuando el login es exitoso
        void Cerrar();
        void CambiarVisibilidadPassword(bool mostrar);
    }
}
