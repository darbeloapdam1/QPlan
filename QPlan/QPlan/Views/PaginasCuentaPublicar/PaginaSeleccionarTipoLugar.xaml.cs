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
    public partial class PaginaSeleccionarTipoLugar : ContentPage
    {
        PaginaSeleccionarTipoLugarViewModel _viewModel;
        public PaginaSeleccionarTipoLugar()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaSeleccionarTipoLugarViewModel(Navigation);
            InizializarSwitchs();
        }

        private void InizializarSwitchs()
        {
            int[] tipoLugar = PaginaNuevoEventoViewModel.evento.tipoLugar;
            if (tipoLugar[0] == 1)
            {
                swtCubierto.IsToggled = true;
            }
            if (tipoLugar[1] == 1)
            {
                swcAireLibre.IsToggled = true;
            }
            if (tipoLugar[2] == 1)
            {
                swcPorCalle.IsToggled = true;
            }
            if (tipoLugar[3] == 1)
            {
                swcFueraCiudad.IsToggled = true;
            }
        }

        private void swtCubierto_Toggled(object sender, ToggledEventArgs e)
        {
            _viewModel.CambiarValorCubierto();
        }

        private void swcAireLibre_Toggled(object sender, ToggledEventArgs e)
        {
            _viewModel.CambiarValorAireLibre();
        }

        private void swcPorCalle_Toggled(object sender, ToggledEventArgs e)
        {
            _viewModel.CambiarValorPorCalle();
        }

        private void swcFueraCiudad_Toggled(object sender, ToggledEventArgs e)
        {
            _viewModel.CambiarValorFueraCiudad();
        }
    }
}