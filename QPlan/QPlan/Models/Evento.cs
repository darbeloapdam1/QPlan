﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QPlan.Models
{
    public class Evento : BaseModel
    {     
        public string descripcion { get; set; }
        public DateTime diaHoraRealizacion { get; set; }
        public double precio { get; set; }
        public string[] enlaces { get; set; }
        public int id_establecimiento { get; set; }
        public string nombre_establecimiento { get; set; }

        public string Dia
        {
            get { return diaHoraRealizacion.Date.ToString(); }
        }

        public string Hora
        {
            get { return diaHoraRealizacion.Hour.ToString(); }
        }

        public Evento() { }

        public Evento(EventoJs ev)
        {

        }
    }
}
