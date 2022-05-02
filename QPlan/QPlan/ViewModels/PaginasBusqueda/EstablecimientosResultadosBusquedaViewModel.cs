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
    public class EstablecimientosResultadosBusquedaViewModel : BaseViewModel
    {
        public bool isBusy;
        public ObservableCollection<Establecimiento> Establecimientos { get; }
        public Command<Establecimiento> EstablecimientoTapped { get; }
        public Command LoadEstablecimientosCommand { get; }
        public EstablecimientosResultadosBusquedaViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            EstablecimientoTapped = new Command<Establecimiento>(OnEstablecimientoSelected);
            LoadEstablecimientosCommand = new Command(async () => await ExecuteLoadEstablecimientosAsync());
            Establecimientos = new ObservableCollection<Establecimiento>();
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

        public async void OnEstablecimientoSelected(Establecimiento establecimiento)
        {
            if (establecimiento == null)
                return;
            await Navigation.PushAsync(new PaginaEstablecimientoDetalles(establecimiento));
        }

        public async Task ExecuteLoadEstablecimientosAsync()
        {
            IsBusy = true;
            try
            {
                Establecimientos.Clear();
                List<Establecimiento> establecimientos = DataStore.GetEstablecimientos();
                foreach (Establecimiento es in establecimientos)
                {
                    Establecimientos.Add(es);
                }
            }catch(Exception ex)
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
