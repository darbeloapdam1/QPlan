using QPlan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class EstablecimientoDetallesViewModel : INotifyPropertyChanged
    {
        public bool isBusy = false;
        public Establecimiento establecimiento;
        public Command LoadEstablecimientoCommand { get; }
        public EstablecimientoDetallesViewModel(Establecimiento establecimiento)
        {
            Establecimiento = establecimiento;
            //LoadEstablecimientoCommand = new Command(async () => await ExecuteLoadEstablecimientoAsync());
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
            get { return Establecimiento.horario; }
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
