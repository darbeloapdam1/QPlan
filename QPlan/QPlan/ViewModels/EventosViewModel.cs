using QPlan.Models;
using QPlan.Services;
using QPlan.Views;
using QPlan.Views.PaginasFiltrar;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class EventosViewModel : BaseViewModel
    {
        public ObservableCollection<Evento> Eventos { get; }
        public Command<Evento> EventoTapped { get; }
        public Command LoadEventosCommand { get; }
        public Command OnFiltrarTapped { get; }
        public bool isBusy;

        public EventosViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            EventoTapped = new Command<Evento>(OnEventoSelected);
            LoadEventosCommand = new Command(async () => await ExecuteLoadEventosAsync());
            Eventos = new ObservableCollection<Evento>();
            OnFiltrarTapped = new Command(async () => await ShowFilterPage());
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public async void OnEventoSelected(Evento evento)
        {
            if (evento == null)
                return;
            await Navigation.PushAsync(new PaginaEventoDetalles(evento));
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        public async Task ExecuteLoadEventosAsync()
        {
            IsBusy = true;
            try
            {
                Eventos.Clear();
                //Evento eventos = await DataStore.GetEventosAsync();
                List<Evento> eventos = DataStore.getEventos();
                foreach (Evento ev in eventos)
                {
                    Eventos.Add(ev);
                }
                //Eventos.Add(eventos);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public async Task ShowFilterPage()
        {
            await Navigation.PushAsync(new PaginaFiltrar());
        }
    }
}
