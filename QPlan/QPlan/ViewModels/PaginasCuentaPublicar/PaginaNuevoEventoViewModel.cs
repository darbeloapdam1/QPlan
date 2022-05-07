using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class PaginaNuevoEventoViewModel : BaseViewModel
    {
        public Command CategoriasTapped { get; }
        public Command LugarTapped { get; }
        public Command PrevisualizarEventoTapped { get; }
        public PaginaNuevoEventoViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            CategoriasTapped = new Command(async () => ShowPaginaCategorias());
            LugarTapped = new Command(async () => ShowPaginaTipoLugar());
            PrevisualizarEventoTapped = new Command(async () => ExecutePrevisualizarEvento());
        }

        public async Task ShowPaginaCategorias()
        {

        }

        public async Task ShowPaginaTipoLugar()
        {

        }

        public async Task ExecutePrevisualizarEvento()
        {

        }
    }
}
