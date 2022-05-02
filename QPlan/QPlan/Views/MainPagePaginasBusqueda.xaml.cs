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
    public partial class MainPagePaginasBusqueda : TabbedPage        
    {
        public static List<BaseModel> baseModels;
        MainPagePaginasBusquedaViewModel _viewModel;
        public MainPagePaginasBusqueda()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MainPagePaginasBusquedaViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            baseModels = _viewModel.BaseModels;
        }

        public void LoadEventos()
        {
            _viewModel.LoadEventos(ref baseModels);
        }

        public void LoadEstablecimientos()
        {
            _viewModel.LoadEstablecimientos(ref baseModels);
        }
    }
}