using Android.Content.Res;
using QPlan.Models;
using QPlan.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace QPlan.ViewModels
{
    public class EstablecimientoDetallesViewModel : BaseViewModel
    {
        public bool isBusy = false;
        public Establecimiento establecimiento;
        public Command LoadEstablecimientoCommand { get; }
        public Command OnVerEventosTapped { get; }
        public EstablecimientoDetallesViewModel(Establecimiento establecimiento, INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            Establecimiento = establecimiento;
            //LoadEstablecimientoCommand = new Command(async () => await ExecuteLoadEstablecimientoAsync());
            OnVerEventosTapped = new Command(async () => await ShowEventosPage());
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

        public Establecimiento Establecimiento
        {
            get { return establecimiento; }
            set
            {
                establecimiento = value;
                OnPropertyChanged("Establecimiento");
            }
        }

        public string Nombre
        {
            get { return Establecimiento.nombre; }
        }

        public string Direccion
        {
            get { return Establecimiento.direccion; }
        }

        public string Horario
        {
            get { return Establecimiento.GetHorario(); }
        }

        public string EdadMinima
        {
            get { return Establecimiento.edadMinima + " años"; }
        }

        public string PrecioEntrada
        {
            get { return Establecimiento.precioEntrada + "€"; }
        }

        public string Foto
        {
            get { return Establecimiento.foto; }
        }

        public string Descripcion
        {
            get { return Establecimiento.descripcion; }
        }

        public string Telefono
        {
            get { return "626 66 35 15"; }
        }

        //private async Task ExecuteLoadEstablecimientoAsync()
        //{

        //}

        public async Task ShowEventosPage()
        {
            await Navigation.PushAsync(new PaginaEventos());
        }
    }
}
