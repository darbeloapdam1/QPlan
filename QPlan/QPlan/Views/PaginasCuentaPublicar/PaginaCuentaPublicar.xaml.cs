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
    public partial class PaginaCuentaPublicar : ContentPage
    {
        public PaginaCuentaPublicarViewModel _viewModel;
        public PaginaCuentaPublicar()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaCuentaPublicarViewModel(Navigation);
        }
    }
}