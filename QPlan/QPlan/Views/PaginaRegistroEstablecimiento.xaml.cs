using QPlan.Models;
using QPlan.ViewModels;
using QPlan.ViewModels.PaginasCuentaPublicar;
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
    public partial class PaginaRegistroModificarEstablecimiento : ContentPage
    {
        public RegistroEstablecimientoViewModel _viewModel;
        public PaginaRegistroModificarEstablecimiento(User user)
        {
            InitializeComponent();
            BindingContext = _viewModel = new RegistroEstablecimientoViewModel(Navigation, user);
        }
        public PaginaRegistroModificarEstablecimiento()
        {
            InitializeComponent();
            BindingContext = _viewModel = new RegistroEstablecimientoViewModel(Navigation, null);
        }

        private void entNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.nombre = entNombre.Text;
        }

        private void entDireccion_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.direccion = entDireccion.Text;
        }

        private void entHorario_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.horario = entHorario.Text;
        }

        private void edtDescripcion_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.descripcion = edtDescripcion.Text;
        }

        private void entTelefono_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.telefono = entTelefono.Text;
        }

        private void entEdad_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.edadMinima = int.Parse(entEdad.Text);
        }

        private void entPrecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                _viewModel.precioEntrada = Double.Parse(entPrecio.Text);
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}