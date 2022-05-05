using QPlan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class PaginaModificarEstablecimientoViewModel : BaseViewModel
    {
        Establecimiento establecimiento; 
        public bool isBusy;
        public PaginaModificarEstablecimientoViewModel(INavigation navigation, Establecimiento establecimiento) : base(navigation)
        {
            this.Navigation = navigation;
            Establecimiento = establecimiento;
        }

        public void OnAppearing()
        {
            IsBusy = true;
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

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public string Telefono
        {
            get{ return Establecimiento.telefono; }
        }
    }
}
