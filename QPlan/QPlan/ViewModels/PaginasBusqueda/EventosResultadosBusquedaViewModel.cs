using QPlan.Models;
using QPlan.Services;
using QPlan.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasBusqueda
{
    public class EventosResultadosBusquedaViewModel : BaseViewModel
    {
        public bool isBusy;
        public ObservableCollection<Evento> Eventos { get; }
        public Command<Evento> EventoTapped { get; }
        public Command LoadEventosCommand { get; }
        public EventosResultadosBusquedaViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            Eventos = new ObservableCollection<Evento>();
            EventoTapped = new Command<Evento>(OnEventoSelected);
            LoadEventosCommand = new Command(async () => await ExecuteLoadEventosAsync());
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

        public async Task ExecuteLoadEventosAsync()
        {
            IsBusy = true;
            try
            {
                Eventos.Clear();
                List<Evento> eventos = DataStore.getEventos();
                foreach (Evento ev in eventos)
                {
                    Eventos.Add(ev);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

    }
}
