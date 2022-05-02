using QPlan.Models;
using QPlan.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class PaginaBusquedaViewModel : BaseViewModel
    {

        public PaginaBusquedaViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
        }


        public async Task Search(SearchParameters parameters)
        {
            await Navigation.PushAsync(new MainPagePaginasBusqueda());
            return;
        }

        public void OnAppearing()
        {

        }
    }
}
