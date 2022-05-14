using QPlan.Models;
using QPlan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QPlan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaBusqueda : ContentPage
    {
        public PaginaBusquedaViewModel _viewModel;
        public PaginaBusqueda()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaBusquedaViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            entSearchBar.Focus();
            _viewModel.OnAppearing();
        }

        /*private void btnBuscar_Clicked(object sender, EventArgs e)
        {
            SearchParameters parameters = new SearchParameters();
            if (chkDeporte.IsChecked)
            {
                parameters.Deporte = true;
            }
            if (chkConcierto.IsChecked)
            {
                parameters.Concierto = true;
            }
            if (chkMusical.IsChecked)
            {
                parameters.Musical = true;
            }
            if (chkFiesta.IsChecked)
            {
                parameters.Fiesta = true;
            }
            if (chkTeatro.IsChecked)
            {
                parameters.Teatro = true;
            }
            if (chkConcierto.IsChecked)
            {
                parameters.Cultura = true;
            }
            if (chkCubierto.IsChecked)
            {
                parameters.Cubierto = true;
            }
            if (chkAireLibre.IsChecked)
            {
                parameters.AireLibre = true;
            }
            if (chkPorCalle.IsChecked)
            {
                parameters.PorCalle = true;
            }
            if (chkFueraCiudad.IsChecked)
            {
                parameters.FueraCiudad = true;
            }
            _viewModel.Search(parameters);
        }*/
    }
}