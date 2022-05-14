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
    public partial class PaginaSeleccionarCategorias : ContentPage
    {
        PaginaSeleccionarCategoriasViewModel _viewModel;
        public PaginaSeleccionarCategorias()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaSeleccionarCategoriasViewModel(Navigation);
            InizializarSwitchs();
        }

        private void InizializarSwitchs()
        {
            int[] categorias = PaginaNuevoEventoViewModel.evento.categorias;
            if(categorias[0] == 1)
            {
                swtMusical.IsToggled = true;
            }
            if (categorias[1] == 1)
            {
                swcFiesta.IsToggled = true;
            }
            if (categorias[2] == 1)
            {
                swcTeatro.IsToggled = true;
            }
            if (categorias[3] == 1)
            {
                swcDeporte.IsToggled = true;
            }
            if (categorias[4] == 1)
            {
                swcCultura.IsToggled = true;
            }
            if (categorias[5] == 1)
            {
                swcConcierto.IsToggled = true;
            }
        }

        private void swtMusical_Toggled(object sender, ToggledEventArgs e)
        {
            _viewModel.CambiarValorMusical();
        }

        private void swcFiesta_Toggled(object sender, ToggledEventArgs e)
        {
            _viewModel.CambiarValorFiesta();
        }

        private void swcTeatro_Toggled(object sender, ToggledEventArgs e)
        {
            _viewModel.CambiarValorTeatro();
        }

        private void swcDeporte_Toggled(object sender, ToggledEventArgs e)
        {
            _viewModel.CambiarValorDeporte();
        }

        private void swcCultura_Toggled(object sender, ToggledEventArgs e)
        {
            _viewModel.CambiarValorCultura();
        }

        private void swcConcierto_Toggled(object sender, ToggledEventArgs e)
        {
            _viewModel.CambiarValorConcierto();
        }
    }
}