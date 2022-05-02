using QPlan.ViewModels.PaginasBusqueda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QPlan.Views.PaginasBusqueda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaEstablecimientosResultadosBusqueda : ContentPage
    {
        EstablecimientosResultadosBusquedaViewModel _viewModel;
        public PaginaEstablecimientosResultadosBusqueda()
        {
            InitializeComponent();
            BindingContext = _viewModel = new EstablecimientosResultadosBusquedaViewModel(Navigation);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}