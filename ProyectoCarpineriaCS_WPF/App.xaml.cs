using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoCarpineriaCS_WPF
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            try
            {
                // Mostrar la ventana de inicio de sesión al iniciar la aplicación
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción no controlada
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Shutdown();
            }
        }
    }
}
