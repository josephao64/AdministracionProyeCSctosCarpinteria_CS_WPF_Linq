using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoCarpineriaCS_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnProyectos_Click(object sender, RoutedEventArgs e)
        {
            ProyectosWindow proyectosWindow = new ProyectosWindow();
            MyFrame.NavigationService.Navigate(proyectosWindow);

        }

        private void BtnGestion_Click(object sender, RoutedEventArgs e)
        {
            GestionWindow gestionWindow = new GestionWindow();
            MyFrame.NavigationService.Navigate(gestionWindow);

        }

        private void BtnClientes_Click(object sender, RoutedEventArgs e)
        {
            ClientesWindow clientesWindow = new ClientesWindow();
            MyFrame.NavigationService.Navigate(clientesWindow);
        }
    }
}
