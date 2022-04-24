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
    public partial class PaginaEstablecimientos : ContentPage
    {
        EstablecimientosViewModel _viewModel;
        public PaginaEstablecimientos()
        {
            InitializeComponent();
            BindingContext = _viewModel = new EstablecimientosViewModel(Navigation);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}