using QPlan.Models;
using QPlan.Services;
using QPlan.Views;
using QPlan.Views.PaginasCuentaPublicar;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class PaginaMisEventosViewModel : BaseViewModel
    {
        public bool isBusy;
        public ObservableCollection<Evento> Eventos { get; }
        public Command<Evento> EventoTapped { get; }
        public Command LoadEventosCommand { get; }
        public Command NuevoEventoTapped { get; }
        public PaginaMisEventosViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            EventoTapped = new Command<Evento>(OnEventoSelected);
            LoadEventosCommand = new Command(async () => await ExecuteLoadEventosAsync());
            Eventos = new ObservableCollection<Evento>();
            NuevoEventoTapped = new Command(async () => await ShowPaginaNuevoEvento());
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

        public async Task ShowPaginaNuevoEvento()
        {
            await Navigation.PushAsync(new PaginaNuevoEvento());
        }

    }
}
