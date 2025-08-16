using ViconPOS.Core.Interfaces.Services;
using ViconPOS.Infrastructure.Data;
using ViconPOS.Infrastructure.Repositories;
using ViconPOS.Infrastructure.Services;
using ViconPOS.Modules.Login.Presenter;
using ViconPOS.Modules.Login.View;
using ViconPOS.UI;

namespace ViconPOS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();   // High‑DPI y demás

            // 👉 Cadena de conexión (simple) apuntando al archivo .db
            var dbPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\CrisCoreDB.db"));
            var connectionString = $"Data Source={dbPath};Version=3;";

            // 🔧 Construimos “a mano” la infraestructura
            var conexionFactory = new SQLiteConnectionFactory(connectionString);

            // 👉 NUEVO: una única instancia del hasher
            IPasswordHasher hasher = new BCryptPasswordHasher();

            // 🗃️ Repositorio de usuarios con inyección de dependencias
            var usuarioRepo = new UsuarioRepository(conexionFactory, hasher);
            IAuthService auth = new AuthService(usuarioRepo, hasher);

            // 🖼️ Creamos la vista y el presenter
            var loginForm = new LoginForm();
            var presenter = new LoginPresenter(loginForm, auth);

            // 🗃️ Sembramos la base de datos con un usuario inicial si no existe
            var seeder = new DatabaseSeeder(usuarioRepo);
            seeder.Sembrar(); // 🌱 Solo se ejecuta si no hay usuarios

            #region // Eventos de la vista
            //🎯 Evento que lanza el menú cuando el login es exitoso
            presenter.LoginSuccess += () => 
            {
                // ⚠️ Abrí el menú en un nuevo ciclo del loop UI
                loginForm.Invoke(() => //
                {
                    var menu = new MainMenuForm(auth, loginForm);
                    menu.Show();
                    loginForm.Ocultar(); // Ocultamos el login                 
                });
            };

            
            #endregion

            // 🚀 Lanzamos la aplicación
            Application.Run(loginForm);
        }
    }
}