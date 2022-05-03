using QPlan.Models;
using QPlan.Services;
using QPlan.Views;
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
        private Evento _selectedEvento;
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

        public Evento SelectedEvento
        {
            get => _selectedEvento;
            set
            {
                _selectedEvento = value;
                OnEventoSelected(value);
            }
        }

        public async void OnEventoSelected(Evento evento)
        {
            if (evento == null)
                return;
            getEventoSelected(evento);
            await Navigation.PushAsync(new PaginaEventoDetalles(evento));
        }

        private void getEventoSelected(Evento evento)
        {
            foreach(Evento evento2 in Eventos)
            {
                if(evento2.id == evento.id)
                {
                    _selectedEvento = evento;
                    return;
                }
            }
        }

        public void OnAppearing()
        {
            _selectedEvento = null;
            IsBusy = true;
        }

        private async Task ExecuteLoadEventosAsync()
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
            //await Navigation.PushAsync();
        }
    }
}
