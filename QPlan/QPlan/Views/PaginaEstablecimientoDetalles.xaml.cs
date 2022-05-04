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
    public partial class PaginaEstablecimientoDetalles : ContentPage
    {
        EstablecimientoDetallesViewModel _viewModel;
        public PaginaEstablecimientoDetalles(Establecimiento establecimiento)
        {
            InitializeComponent();
            BindingContext = _viewModel = new EstablecimientoDetallesViewModel(establecimiento, Navigation);
        }
    }
}