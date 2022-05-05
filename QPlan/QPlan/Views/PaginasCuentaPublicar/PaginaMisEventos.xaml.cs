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
    public partial class PaginaMisEventos : ContentPage
    {
        PaginaMisEventosViewModel _viewModel;
        public PaginaMisEventos()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaMisEventosViewModel(Navigation);
            _viewModel.OnAppearing();
        }
    }
}