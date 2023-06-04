using System.Windows;

namespace ProyectoCarpineriaCS_WPF
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e) //definimos el metodo para boton 
        {
            string username = txtUsername.Text;             //sed obtienen los balores  de usuario y contraseña  esto lo hacemos accediendo a las propiedades de los textbloxk
            string password = txtPassword.Password;

            // Verificar las credenciales de inicio de sesión
            if (CheckCredentials(username, password))       //lamamos al metodo  esto toma el nombre de usuario y la contraseña como paramatro y retorna un valor boleanno  que indica si es valido o no 
            {                                               
                // Mostrar la ventana principal
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();                            //si las credenciales son validas se crea una instancia de la clase mainwindows y se llama al metodo show()

                // Cerrar la ventana actual
                Close(); //luego llamamos al metodo close para que se siere la ventana actual
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Inténtalo de nuevo.");
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            //Este método verifica si las credenciales proporcionadas por el usuario coinciden con un nombre de usuario y una contraseña predefinidos. Si coinciden, el método retorna true; de lo contrario, retorna false.

            return (username == "usuario" && password == "123");
        }
    }
}
