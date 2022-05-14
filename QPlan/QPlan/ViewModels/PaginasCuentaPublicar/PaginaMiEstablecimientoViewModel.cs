﻿using QPlan.Models;
using QPlan.Services;
using QPlan.Views.PaginasCuentaPublicar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class PaginaMiEstablecimientoViewModel : BaseViewModel
    {
        public bool isBusy;
        public Command OnModificarTapped { get; }
        public Command LoadEstablecimientoCommand { get; }
        public Establecimiento establecimiento;
        public PaginaMiEstablecimientoViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            OnModificarTapped = new Command(async () => await ShowPageModificar());
            LoadEstablecimientoCommand = new Command(async () => await ExecuteLoadEstablecimiento());
            ExecuteLoadEstablecimiento();
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

        public Establecimiento Establecimiento1
        {
            get { return establecimiento; }
            set
            {
                this.establecimiento = value;
                OnPropertyChanged("Establecimiento");
            }
        }

        public string Nombre
        {
            get { return Establecimiento1.nombre; }
        }

        public string Direccion
        {
            get { return Establecimiento1.direccion; }
        }

        public string Horario
        {
            get { return Establecimiento1.GetHorario(); }
        }

        public string EdadMinima
        {
            get { return Establecimiento1.edadMinima + " años"; }
        }

        public string PrecioEntrada
        {
            get { return Establecimiento1.precioEntrada + "€"; }
        }

        public string Foto
        {
            get { return Establecimiento1.foto; }
        }

        public string Descripcion
        {
            get { return Establecimiento1.descripcion; }
        }

        public string Telefono
        {
            get { return "626 66 35 15"; }
        }

        public void OnAppearing()
        {
            isBusy = true;
        }

        public async Task ShowPageModificar()
        {
            await Navigation.PushAsync(new PaginaModificarEstablecimiento(this.establecimiento));
        }

        public async Task ExecuteLoadEstablecimiento()
        {
            IsBusy = true;
            try
            {
                this.Establecimiento1 = DataGetJson.GetUnEstablecimiento();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }            
        }
    }
}
