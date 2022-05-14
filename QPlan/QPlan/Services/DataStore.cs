using QPlan.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QPlan.Services
{
    public static class DataStore
    {
        /*public static async Task<List<Evento>> GetEventosAsync()
        {
            var eventos = await DataGetJson.GetEventosAsync();
            return eventos;
        }*/

        public static List<Evento> getEventos()
        {
            return DataGetJson.GetEventos();
        }

        public static List<Establecimiento> GetEstablecimientos()
        {
            return DataGetJson.GetEstablecimientos();
        }

        //public static async List<Establecimiento> GetEstablecimientosAsync()
        //{

        //}
    }
}
