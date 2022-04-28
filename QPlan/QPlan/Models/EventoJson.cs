using System;
using System.Collections.Generic;
using System.Text;

namespace QPlan.Models
{
    public class Rootobject
    {
        public EventoJs[] Property1 { get; set; }
    }

    public class EventoJs
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime dia { get; set; }
        public DateTime hora { get; set; }
        public int precio { get; set; }
        public string foto { get; set; }
        public int id_establecimiento { get; set; }
    }

}
