using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ProyectoCarpineriaCS_WPF
{
    public partial class ClientesWindow : Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; //definimos la cadena de conexion
        private List<Proyecto> clientesList; //se declara una lista de objetos proyecto llamada clienteslist  se utilizara para guardar los clientes gurdados desde la abse 

        public ClientesWindow() // en el constructoe de kla clase clientes windows se llama cuando cuando se crea una nueva instancillamamos los metodos 
        {
            InitializeComponent();
            LoadClientes();
            LoadClientesFrecuentes();
        }

        private SqlConnection CrearConexion()
        {
            return new SqlConnection(connectionString);
        }

        private void LoadClientes()   // se encarga de cargar los clientes desde la base de datos y mostrarlos en un datagrid utilizando una consulta para seleclos nom y cel de los clients
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Nombre, Telefono FROM Proyectos";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    clientesList = new List<Proyecto>();

                    while (reader.Read())
                    {
                        Proyecto proyecto = new Proyecto
                        {
                            Nombre = reader["Nombre"].ToString(),
                            Telefono = reader["Telefono"].ToString()
                        };

                        clientesList.Add(proyecto);
                    }

                    ClientesGrid.ItemsSource = clientesList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadClientesFrecuentes()  //
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Nombre, Telefono, COUNT(*) AS Frecuencia " +  //creamos la consulta en la variable query 
                                   "FROM Proyectos " +
                                   "GROUP BY Nombre, Telefono " +        //la consulta utiliza "group by " para agrupar los resultados por nombre y telefono y la
                                                                         //calausula "HAVING" PARA FIILTRAR SOLO AQUELLSO CLIENTES CON UNA RECUENCIA MAYOR A 1
                                   "HAVING COUNT(*) > 1";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    List<string> clientesFrecuentes = new List<string>();

                    while (reader.Read())                                         //utilizando el bucle while (reader.Read()). En cada iteración, se obtiene el nombre,
                                                                                //el teléfono y la frecuencia del cliente frecuente.
                    {
                        string nombre = reader["Nombre"].ToString();                                      
                        string telefono = reader["Telefono"].ToString();        
                        int frecuencia = Convert.ToInt32(reader["Frecuencia"]);

                        clientesFrecuentes.Add($"{nombre} - {telefono} (Frecuencia: {frecuencia})");
                    }

                    ClientesFrecuentesListBox.ItemsSource = clientesFrecuentes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes frecuentes: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
