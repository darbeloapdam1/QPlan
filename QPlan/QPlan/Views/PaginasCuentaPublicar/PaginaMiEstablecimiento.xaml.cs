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
    public partial class PaginaMiEstablecimiento : ContentPage
    {
        public PaginaMiEstablecimientoViewModel _viewModel;
        public PaginaMiEstablecimiento()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaMiEstablecimientoViewModel(Navigation);
            _viewModel.OnAppearing();
        }

    }
}