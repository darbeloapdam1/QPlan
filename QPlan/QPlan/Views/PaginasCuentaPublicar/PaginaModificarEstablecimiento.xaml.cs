using QPlan.Models;
using QPlan.ViewModels.PaginasCuentaPublicar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QPlan.Views.PaginasCuentaPublicar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaModificarEstablecimiento : ContentPage
    {
        public PaginaModificarEstablecimientoViewModel _viewModel;
        public PaginaModificarEstablecimiento(Establecimiento establecimiento)
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaModificarEstablecimientoViewModel(Navigation, establecimiento);
            _viewModel.OnAppearing();
        }
    }
}