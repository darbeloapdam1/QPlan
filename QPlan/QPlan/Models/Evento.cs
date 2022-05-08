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
        public Evento() { }

        public Evento(EventoJs ev)
        {

        }
    }
}
