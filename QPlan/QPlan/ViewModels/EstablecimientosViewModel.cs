﻿using QPlan.Models;
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
    public class EstablecimientosViewModel : INotifyPropertyChanged
    {
        public bool isBusy;
        public INavigation Navigation { get; set; }
        public Establecimiento _selectedEstablecimiento;
        public ObservableCollection<Establecimiento> Establecimientos { get; }
        public Command<Establecimiento> EstablecimientoTapped { get; }
        public Command LoadEstablecimientosCommand { get; }
        public EstablecimientosViewModel(INavigation navigation)
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
        private async Task ExecuteLoadEstablecimientosAsync()
        {
            IsBusy = true;
            try
            {
                Establecimientos.Clear();
                //Establecimiento establecimientos = await DataStore.GetEstablecimientosAsync();
                List<Establecimiento> establecimientos = DataStore.GetEstablecimientos();
                foreach (Establecimiento es in establecimientos)
                {
                    Establecimientos.Add(es);
                }
                //Establecimientos.Add(establecimientos);
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
            _selectedEstablecimiento = null;
            IsBusy = true;
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