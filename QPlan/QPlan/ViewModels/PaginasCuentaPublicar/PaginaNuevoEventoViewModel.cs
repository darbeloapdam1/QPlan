using QPlan.Models;
using QPlan.Views.PaginasCuentaPublicar;
using QPlan.Views.PaginasFiltrar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class PaginaNuevoEventoViewModel : BaseViewModel
    {
        public Evento evento;
        public Command CategoriasTapped { get; }
        public Command LugarTapped { get; }
        public Command PrevisualizarEventoTapped { get; }
        public PaginaNuevoEventoViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            CategoriasTapped = new Command(async () => await ShowPaginaCategorias());
            LugarTapped = new Command(async () => await ShowPaginaTipoLugar());
            PrevisualizarEventoTapped = new Command(async () => await ExecutePrevisualizarEvento ());
            evento = new Evento();
            evento.foto = "evento2_fito_detalles.jfif";
        }

        public async Task ShowPaginaCategorias()
        {
            await Navigation.PushAsync(new PaginaTipoCategorias());
        }

        public async Task ShowPaginaTipoLugar()
        {
            await Navigation.PushAsync(new PaginaTipoLugar());
        }

        public async Task ExecutePrevisualizarEvento()
        {
            await Navigation.PushAsync(new PaginaPrevisualizarEvento(evento));
        }

        public string Titulo
        {
            get{ return evento.nombre; }
            set { evento.nombre = value; }
        }
        public string Descripcion
        {
            get { return evento.descripcion; }
            set { evento.descripcion = value; }
        }

        public int EdadMinima
        {
            get { return evento.edad_minima; }
            set { evento.edad_minima = value; }
        }

        public double Precio
        {
            get { return evento.precio; }
            set { evento.precio = value; }
        }
        public string Observaciones
        {
            get { return evento.observaciones; }
            set { evento.observaciones = value; }
        }

        public DateTime Fecha
        {
            get { return evento.dia; }
            set { evento.dia = value; }
        }

        public TimeSpan Hora
        {
            get { return evento.hora; }
            set { evento.hora = value; }
        }
    }
}
