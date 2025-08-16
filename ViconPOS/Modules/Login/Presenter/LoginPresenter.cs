using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViconPOS.Core.Interfaces.Services;
using ViconPOS.Modules.Login.View;
// ------------------------------
// Archivo: LoginPresenter.cs
// Propósito: Orquesta la lógica de Login entre la vista y el AuthService.
// ------------------------------
namespace ViconPOS.Modules.Login.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginView _vista;
        private readonly IAuthService _authService;

        public event Action LoginSuccess; // Para notificar al Program o a otras partes de la app


        public LoginPresenter(ILoginView vista, IAuthService authService)
        {
            _vista = vista;
            _authService = authService;

            // Suscribimos a los eventos de la vista
            _vista.IngresarClick += OnIngresarClick;
        }

        // Maneja clic en el botón Ingresar
        private void OnIngresarClick()
        {
            _vista.LimpiarError();
            var usuario = _vista.Usuario;
            var pass = _vista.Contraseña;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(pass))
            {
                _vista.MostrarError("Completa usuario y contraseña");
                return;
            }

            var ok = _authService.IniciarSesion(usuario, pass);
            if (ok)
            {
               LoginSuccess?.Invoke(); // Notificamos que el login fue exitoso
                                       //_vista.Cerrar(); // Aquí podrías abrir Form2 o notificar al Program
                                       

            }
            else
            {
                _vista.MostrarError("Credenciales incorrectas o usuario inactivo");
            }
        }
    }
}
