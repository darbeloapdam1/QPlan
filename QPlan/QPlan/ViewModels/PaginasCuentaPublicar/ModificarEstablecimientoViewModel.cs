using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class ModificarEstablecimientoViewModel : BaseViewModel
    {

        public ModificarEstablecimientoViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
        }

        public string TituloPagina
        {
            get { return "Modificar establecimiento"; }
        }
    }
}
