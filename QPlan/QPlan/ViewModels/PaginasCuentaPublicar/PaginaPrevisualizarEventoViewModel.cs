using QPlan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class PaginaPrevisualizarEventoViewModel  : BaseViewModel
    {
        public Evento evento1;
        public PaginaPrevisualizarEventoViewModel(INavigation navigation, Evento evento) : base(navigation)
        {
            this.Navigation = navigation;
            evento1 = evento;
        }

        public string Nombre
        {
            get { return evento1.nombre; }
        }
        public string Descripcion
        {
            get { return evento1.descripcion; }
        }
        public string Foto
        {
            get { return evento1.foto; }
        }
        public string PrecioEuros
        {
            get { return evento1.precio + "€"; }
        }
        public string Hora
        {
            get { return evento1.hora.ToString(@"hh\:mm") + "h"; }
        }
    }
}

//https://docs.microsoft.com/es-es/xamarin/xamarin-forms/app-fundamentals/dependency-service/photo-picker
