using QPlan.Views.PaginasCuentaPublicar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class MainPageAppViewModel : BaseViewModel
    {
        private bool cuentaPublicar = true;
        public MainPageAppViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            LaunchApp();
        }

        private async Task LaunchApp()
        {
            if (cuentaPublicar)
            {
                await Navigation.PushModalAsync(new MainPageCuentaPublicar());
            }
            else
            {
                await Navigation.PushModalAsync(new MainPage());
            }
        }

    }
}
