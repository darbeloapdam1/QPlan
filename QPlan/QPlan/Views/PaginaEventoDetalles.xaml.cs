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
    public partial class PaginaEventoDetalles : ContentPage
    {
        public EventoDetallesViewModel _viewModel;
        public PaginaEventoDetalles(Evento evento)
        {
            InitializeComponent();
            BindingContext = _viewModel = new EventoDetallesViewModel(evento);
        }
    }
}