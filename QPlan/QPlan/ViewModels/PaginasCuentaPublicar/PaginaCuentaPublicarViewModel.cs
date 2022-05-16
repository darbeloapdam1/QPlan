using QPlan.Services;
using QPlan.Views;
using QPlan.Views.PaginasCuentaPublicar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class PaginaCuentaPublicarViewModel : BaseViewModel
    {
        public Command OnCerrarSesionTapped { get; }
        public PaginaCuentaPublicarViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            OnCerrarSesionTapped = new Command(async () => await CerrarSesion());
        }

        public string Nombre
        {
            get { return MainPageCuentaPublicar.User.name; }
        }

        public string Telefono
        {
            get { return MainPageCuentaPublicar.User.phone; }
        }

        public string Email
        {
            get { return MainPageCuentaPublicar.User.email; }
        }

        public async Task CerrarSesion()
        {
            if(await App.Current.MainPage.DisplayAlert("Cerrar sesión", "Seguro que quieres cerrar sesión", "Si", "No"))
            {
                FileReader reader = new FileReader();
                await reader.EraseLoginData();
                await Navigation.PushModalAsync(new PaginaLogin());
            }
        }

    }
}
