using System;
using System.Collections.Generic;
using System.Text;

namespace QPlan.Models
{
    public class Evento : BaseModel
    {     
        public string descripcion { get; set; }
        public DateTime dia { get; set; }
        public TimeSpan hora { get; set; }
        public double precio { get; set; }
        public string[] enlaces { get; set; }
        public int id_establecimiento { get; set; }
        public string nombre_establecimiento { get; set; }
        public int edad_minima { get; set; }
        public string observaciones { get; set; }
        public int[] categorias { get; set; }
        //Cada posición de array se corresponde con un tipo de categoría diferente. El orden de la posición 0 a la 5 es: 
        //Musical, Fiesta, Teatro, Deporte, Cultura, Concierto
        public int[] tipoLugar { get; set; }
        //Lo mismo que el array de categorias pero con el tipo de lugar en el que realiza.
        //Cubierto, Al aire libre, Por la calle, Fuera de la ciudad


        public Evento() {
            categorias = new int[] { -1, -1, -1, -1, -1, -1 };
            tipoLugar = new int[] { -1, -1, -1, -1 };
        }

    }
}
