using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCarpineriaCS_WPF
{                    //esta clase tiene 8 propiedades cada una con un metodo get y set 
    public class Proyecto
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Precio { get; set; }
        public decimal TotalPrecio { get; set; }
    }
}
