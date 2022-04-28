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
            _viewModel.OnAppearing();
        }

        private void btnBuscar_Clicked(object sender, EventArgs e)
        {
            SearchParameters parameters = new SearchParameters();


            _viewModel.Search(parameters);
        }
    }
}