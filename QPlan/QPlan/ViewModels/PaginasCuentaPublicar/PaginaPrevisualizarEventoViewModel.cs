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
    }
}
