using Newtonsoft.Json;
using QPlan.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QPlan.Services
{
    public class DataGetJson
    {
        public static readonly string AllEventsRequest = "https://localhost:44368/api/Eventoes";

        public static async Task<Evento> GetEventoAsync()
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var responseStream = await response.Content.ReadAsStringAsync();
                    Rootobject eventos = JsonConvert.DeserializeObject<Rootobject>(responseStream);
                    
                    
                }
            }catch(Exception ex)
            {
                Console.WriteLine("===>Error<=== " + ex);
            }
            
            return null;
        }

        public static async Task<List<Evento>> GetEventosAsync()
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(AllEventsRequest);
                if (response.IsSuccessStatusCode)
                {
                    var responseStream = await response.Content.ReadAsStringAsync();
                    var eventos = JsonConvert.DeserializeObject<Rootobject>(responseStream);
                    List<Evento> eventosList = new List<Evento>();
                    foreach (var ev in eventos.Property1)
                    {
                        eventosList.Add(new Evento(ev));
                    }
                    return eventosList;
                }
            }catch (Exception ex)
            {
                Console.WriteLine("====>Error<====" + ex);
            }
            return null;
        }

        public static List<Evento> GetEventos()
        {
            List<Evento> eventos = new List<Evento>();
            int[] ids = { 1, 2, 3, 4, 5 };
            string[] titulos = { "MG Lurauto X Gravity", "Fito & Fitipaldis", "Sábado 2 - Canalla", "El musical de coco", "Paul Alone" };
            DateTime[] diasHoras = { DateTime.Parse("2022-04-02T18:00"), DateTime.Parse("2022-04-23T22:00"), DateTime.Parse("2022-04-02T23:59"), DateTime.Parse("2022-04-03T17:30"), DateTime.Parse("2022-04-01T20:15") };
            double[] precios = { 25, 30, 12, 20, 18 };
            string[] fotos = { "evento1_motos.jpg", "evento2_fito_detalles.jfif", "evento3_canalla.jpg", "evento4_coco.jpg", "evento5_paul_alone.jpg" };
            for (int i = 0; i < ids.Length; i++)
            {
                Evento ev = new Evento()
                {
                    id = ids[i],
                    nombre = titulos[i],
                    diaHoraRealizacion = diasHoras[i],
                    precio = precios[i],
                    foto = fotos[i],
                    descripcion = "Fito & Fitipaldis anuncian su vuelta a la carretera con su gira “cada vez cadáver Tour”. " +
                    "El esperado regreso del artista ya es una realidad y 21 únicas ciudades españolas son las elegidas para su puesta en escena."
                };
                eventos.Add(ev);
            }
            return eventos;
        }

        public static List<Establecimiento> GetEstablecimientos()
        {
            List<Establecimiento> est = new List<Establecimiento>();
            int[] ids = { 1, 2, 3, 4, 5 };
            string[] nombres = { "Baluarte", "Bar Kla-B", "Goiko Grill", "El corte inglés", "La tagliatella" };
            string[] direcciones = { "PL. del Baluarte", "C, Navas de Tolosa, 11", "P. de Pablo Sarasate", "C. Estella, 9", "Pl. del Castillo, 37"};
            string[] horarios = { "De 8:30 a 20:00", "De 23:00 a 4:00", "De 12:00 a 24:00", "De 10:00 a 22:00", "De 13:30 a 23:00" };
            string[] fotos = { "establecimiento1_baluarte.jpg", "establecimiento2_klab.jpg", "establecimiento3_goiko.jpg", "establecimiento4_corte_ingles.png", "establecimiento5_tagliatella.jfif" };
            int[] precios = { 0, 10, 0, 0, 0 };
            int[] edadesMinimas = { 0, 18, 0, 0, 0 };
            for(int i = 0; i < ids.Length; i++)
            {
                Establecimiento esta = new Establecimiento()
                {
                    id = ids[i],
                    nombre = nombres[i],
                    direccion = direcciones[i],
                    horario = horarios[i],
                    foto = fotos[i],
                    precioEntrada = precios[i],
                    edadMinima = edadesMinimas[i],
                    descripcion = "🍸Tu bar de copas, una forma diferente de diversión en Pamplona. 🔥💃🏽🕺🏽Porque en la vida #bailaresklab"
                };
                est.Add(esta);
            }
            return est;
        }
    }
    
}
