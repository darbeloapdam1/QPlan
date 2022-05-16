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
    public partial class PaginaRegistro : ContentPage
    {
        public PaginaRegistroViewModel _viewModel;
        public PaginaRegistro()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaRegistroViewModel(Navigation);
        }

        private void entNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.nombre = entNombre.Text;
        }

        private void entEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.email = entEmail.Text;
        }

        private void entTelefono_TextChanged(object sender, TextChangedEventArgs e)
        {
           _viewModel.telefono = entTelefono.Text;
        }

        private void entContra_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.contra = entContra.Text;
        }

        private void entRepetirContra_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.contraRepetida = entRepetirContra.Text;
        }

        private void swtEsEstablecimiento_Toggled(object sender, ToggledEventArgs e)
        {
            if (swtEsEstablecimiento.IsToggled)
            {
                _viewModel.esEstablecimiento = 1;
            }
            else
            {
                _viewModel.esEstablecimiento = 0;
            }
        }
    }
}