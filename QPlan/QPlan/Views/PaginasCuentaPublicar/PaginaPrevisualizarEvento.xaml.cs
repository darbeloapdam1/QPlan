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
    public partial class PaginaPrevisualizarEvento : ContentPage
    {
        public PaginaPrevisualizarEventoViewModel _viewModel;
        public PaginaPrevisualizarEvento(Evento evento)
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaPrevisualizarEventoViewModel(Navigation, evento);
        }
    }
}