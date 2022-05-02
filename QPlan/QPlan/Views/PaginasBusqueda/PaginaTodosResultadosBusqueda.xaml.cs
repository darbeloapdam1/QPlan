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
    public partial class PaginaTodosResultadosBusqueda : ContentPage
    {
        TodosResultadosBusquedaViewModel _viewModel;
        public PaginaTodosResultadosBusqueda()
        {
            InitializeComponent();
            BindingContext = _viewModel = new TodosResultadosBusquedaViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}