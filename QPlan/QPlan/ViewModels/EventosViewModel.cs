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
    public class EventosViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }
        private Evento _selectedEvento;
        public ObservableCollection<Evento> Eventos { get; }
        public Command<Evento> EventoTapped { get; }
        public Command LoadEventosCommand { get; }
        public bool isBusy;

        public EventosViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            EventoTapped = new Command<Evento>(OnEventoSelected);
            LoadEventosCommand = new Command(async () => await ExecuteLoadEventosAsync());
            Eventos = new ObservableCollection<Evento>();
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
