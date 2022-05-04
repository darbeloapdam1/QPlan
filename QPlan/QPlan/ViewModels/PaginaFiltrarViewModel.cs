using QPlan.Views.PaginasFiltrar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class PaginaFiltrarViewModel : BaseViewModel
    {
        public Command OnCategoriaTapped { get; }
        public Command OnLugarTapped { get; }
        public PaginaFiltrarViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            OnCategoriaTapped = new Command(LoadPaginaCategorias);
            OnLugarTapped = new Command(LoadPaginaLugares);
        }

        public void LoadPaginaCategorias()
        {
            Navigation.PushAsync(new PaginaTipoCategorias());
        }

        public void LoadPaginaLugares()
        {
            Navigation.PushAsync(new PaginaTipoLugar());
        }
    }
}
