using System;
using System.Collections.Generic;
using System.Text;

namespace QPlan.Models
{
    public class Establecimiento : BaseModel
    {
        public string direccion { get; set; }
        public string horario { get; set; }
        public int edadMinima { get; set; }
        public double precioEntrada { get; set; }
        public string[] redesSociales { get; set; }
        public string descripcion { get; set; }
        public string telefono { get; set; }

        public string GetHorario()
        {
            string resul = "";
            string[] dias = { "Lunes: ", "Martes: ", "Miércoles: ", "Jueves: ", "Viernes: ", "Sábado: ", "Domingo: " };
            foreach(string dia in dias)
            {
                resul += dia + horario + "&#x0a;";
            }
            return resul;
        }
    }
}
