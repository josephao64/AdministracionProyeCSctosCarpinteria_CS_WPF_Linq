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
    public partial class ProyectosWindow : Page

              // se definen 3 valiavels pribadas de la clase 
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private DataTable proyectosTable;  // un objeto datatable que se utiliza para almacenar los datos de los proyectos cargados desde la base 
        private DataRowView selectedRow;  //representa la fila seleccioanda 

        public ProyectosWindow()
        {
            InitializeComponent();
            LoadProyectos();
        }

       

        private void LoadProyectos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ID, Nombre, Telefono, Descripcion, FechaInicio, FechaFin, Precio FROM Proyectos";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    proyectosTable = new DataTable();
                    adapter.Fill(proyectosTable);

                    ProyectosGrid.ItemsSource = proyectosTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proyectos: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ProyectosGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProyectosGrid.SelectedItem != null)
            {
                selectedRow = (DataRowView)ProyectosGrid.SelectedItem;

                TxtId.Text = selectedRow["ID"].ToString();
                TxtNombre.Text = selectedRow["Nombre"].ToString();
                TxtTelefono.Text = selectedRow["Telefono"].ToString();
                TxtDescripcion.Text = selectedRow["Descripcion"].ToString();
                FechaInicioPicker.SelectedDate = (selectedRow["FechaInicio"] != DBNull.Value) ? (DateTime?)selectedRow["FechaInicio"] : null;
                FechaFinPicker.SelectedDate = (selectedRow["FechaFin"] != DBNull.Value) ? (DateTime?)selectedRow["FechaFin"] : null;
                TxtPrecio.Text = selectedRow["Precio"].ToString();
            }
        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selectedRow != null)  //se verifica si hay una fila seleccionada 
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))  //se crea un objeto sqlcomand con la consulta de actualizzacion del proyecto seleccionasdo
                    {                                                                          //3se asignan los valores de control de texto y los seleccionadores de fechas a los parametros 
                        string query = "UPDATE Proyectos SET Nombre = @nombre, Telefono = @telefono, Descripcion = @descripcion, " +
                                       "FechaInicio = @fechaInicio, FechaFin = @fechaFin, Precio = @precio WHERE ID = @id";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@nombre", TxtNombre.Text);                 //Se asignan los valores de los controles de texto y los seleccionadores de fecha a los parámetros de la consulta.
                        command.Parameters.AddWithValue("@telefono", TxtTelefono.Text);
                        command.Parameters.AddWithValue("@descripcion", TxtDescripcion.Text);    //se ejecuta la consulta command ,executeninquery

                        if (FechaInicioPicker.SelectedDate.HasValue)
                
                            command.Parameters.AddWithValue("@fechaInicio", FechaInicioPicker.SelectedDate.Value);
                        else
                            command.Parameters.AddWithValue("@fechaInicio", DBNull.Value);

                        if (FechaFinPicker.SelectedDate.HasValue)
                            command.Parameters.AddWithValue("@fechaFin", FechaFinPicker.SelectedDate.Value);
                        else
                            command.Parameters.AddWithValue("@fechaFin", DBNull.Value);

                        decimal precio;
                        if (decimal.TryParse(TxtPrecio.Text, out precio))
                            command.Parameters.AddWithValue("@precio", precio);
                        else
                            command.Parameters.AddWithValue("@precio", DBNull.Value);

                        int id = (int)selectedRow["ID"];
                        command.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        command.ExecuteNonQuery();      //se ejecuta la consulta command ,executeninquery

                        LoadProyectos();    //Se llama al método LoadProyectos() para recargar la lista de proyectos y se llama al método ClearInputs() para borrar los campos de entrada.
                        ClearInputs();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún proyecto.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearInputs()
        {
            TxtId.Text = "";
            TxtNombre.Text = "";
            TxtTelefono.Text = "";
            TxtDescripcion.Text = "";
            FechaInicioPicker.SelectedDate = null;
            FechaFinPicker.SelectedDate = null;
            TxtPrecio.Text = "";
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e) //definimos el metodo que carga los proyectos desde la basde de datps y los muestra en el datagrid
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) // sse crea una instancia de sqlcneccion utilizando la cadena de conexion 
                {
                    string query = "INSERT INTO Proyectos (Nombre, Telefono, Descripcion, FechaInicio, FechaFin, Precio) " + // se define  una consultasql para seleccionar loss datos de los proyectos 
                                   "VALUES (@nombre, @telefono, @descripcion, @fechaInicio, @fechaFin, @precio)";

                    SqlCommand command = new SqlCommand(query, connection);  // se crea un objeto sqlcomand con la consulta y la conexion 
                    command.Parameters.AddWithValue("@nombre", TxtNombre.Text);//  se usa sqladapter para ejecutar la consulta y llenar el datatable 
                    command.Parameters.AddWithValue("@telefono", TxtTelefono.Text);
                    command.Parameters.AddWithValue("@descripcion", TxtDescripcion.Text);

                    if (FechaInicioPicker.SelectedDate.HasValue)
                        command.Parameters.AddWithValue("@fechaInicio", FechaInicioPicker.SelectedDate.Value);
                    else
                        command.Parameters.AddWithValue("@fechaInicio", DBNull.Value);
                                                                                                //esta parte se encarga de manejar los parametros de fecha de inicio decha fin y precio para realizar opereaciones de insercion o actualizacion 
                    if (FechaFinPicker.SelectedDate.HasValue)
                        command.Parameters.AddWithValue("@fechaFin", FechaFinPicker.SelectedDate.Value);
                    else
                        command.Parameters.AddWithValue("@fechaFin", DBNull.Value);

                    decimal precio;
                    if (decimal.TryParse(TxtPrecio.Text, out precio))
                        command.Parameters.AddWithValue("@precio", precio);
                    else
                        command.Parameters.AddWithValue("@precio", DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();

                    LoadProyectos();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el proyecto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selectedRow != null)   //se berifica si una fila fue seleccionada 
                {
                    MessageBoxResult result = MessageBox.Show("¿Está seguro de que desea eliminar este proyecto?", "Confirmar eliminación", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString)) // se  crea un objeto sqlcomand con la consulta de eliminacion para eliminarla 
                        {
                            string query = "DELETE FROM Proyectos WHERE ID = @id";
                            SqlCommand command = new SqlCommand(query, connection);
                            int id = (int)selectedRow["ID"];
                            command.Parameters.AddWithValue("@id", id);

                            connection.Open();
                            command.ExecuteNonQuery();  //se utiliza la consulta ulitisando "coman.exe"  y se llama al mtdo loadproyect  para recargar la lista de proyect y se llama al metodo clearinputs para borrar los datos 

                            LoadProyectos();    
                            ClearInputs();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún proyecto.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proyecto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
