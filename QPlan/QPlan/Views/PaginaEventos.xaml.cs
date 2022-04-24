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
    public partial class PaginaEventos : ContentPage
    {
        EventosViewModel _viewModel;
        public PaginaEventos()
        {
            InitializeComponent();
            BindingContext = _viewModel = new EventosViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}