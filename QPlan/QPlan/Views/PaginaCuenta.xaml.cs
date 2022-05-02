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
    public partial class PaginaCuenta : ContentPage
    {
        public CuentaViewModel _viewModel;
        public PaginaCuenta()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CuentaViewModel(Navigation);
        }
    }
}