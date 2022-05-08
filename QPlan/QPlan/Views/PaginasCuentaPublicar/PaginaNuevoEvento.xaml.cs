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
    public partial class PaginaNuevoEvento : ContentPage
    {
        public PaginaNuevoEventoViewModel _viewModel;
        private bool EnableTimePicker = false;
        public PaginaNuevoEvento()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaNuevoEventoViewModel(Navigation);
            pckDia.Date = DateTime.Now;
            pckHora.Time = DateTime.Now.TimeOfDay;
            entTitulo.Text = "";
            edtDescripcion.Text = "";
            entEdad.Text = "";
            entPrecio.Text = "";
            edtObservaciones.Text = "";
            EnableTimePicker = true;
        }

        private void entTitulo_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.Titulo = entTitulo.Text;
        }

        private void edtDescripcion_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.Descripcion = edtDescripcion.Text;
        }

        private void entEdad_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(entEdad.Text != "")
            {
                _viewModel.EdadMinima = int.Parse(entEdad.Text);
            }           
        }

        private void entPrecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(entPrecio.Text != "")
            {
                _viewModel.Precio = double.Parse(entPrecio.Text);
            }           
        }

        private void edtObservaciones_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.Observaciones = edtObservaciones.Text;
        }

        private void pckDia_DateSelected(object sender, DateChangedEventArgs e)
        {
            _viewModel.Fecha = pckDia.Date;
        }

        private void pckHora_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (EnableTimePicker)
            {
                _viewModel.Hora = pckHora.Time;
            }           
        }
    }
}