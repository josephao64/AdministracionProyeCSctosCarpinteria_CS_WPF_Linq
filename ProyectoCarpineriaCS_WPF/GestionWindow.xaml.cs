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
    public partial class GestionWindow : Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private DataTable proyectosTable;
        private DataRowView selectedRow;

        public GestionWindow()
        {
            InitializeComponent();
            MostrarEstadisticasProyectos();
        }

        private void MostrarEstadisticasProyectos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) AS TotalProyectos, MAX(Precio) AS PrecioMaximo, " +  //Se crea una consulta SQL en la variable query para obtener el recuento total
                                                                                                         //de proyectos, el precio máximo y la fecha de inicio máxima de los proyectos 
                                   "MAX(FechaInicio) AS FechaInicioMaxima FROM Proyectos";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    proyectosTable = new DataTable();            //Se crea un objeto DataTable llamado proyectosTable que se utilizará para almacenar los resultados de la consult
                    adapter.Fill(proyectosTable);  // Se utiliza el método Fill del objeto adapter para llenar el proyectosTable con los resultados de la consulta.

                    if (proyectosTable.Rows.Count > 0)                                           //Se verifica si el proyectosTable contiene al menos una fila .
                                                                                                 //Si hay filas en el proyectosTable, se obtiene la primera fila(DataRow) utilizando el índice 0.
                    {
                        DataRow row = proyectosTable.Rows[0];

                        lblTotalProyectos.Text = row["TotalProyectos"].ToString();
                        lblProyectoMasCaro.Text = row["PrecioMaximo"].ToString();
                        lblProyectoMasReciente.Text = row["FechaInicioMaxima"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las estadísticas de los proyectos: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
