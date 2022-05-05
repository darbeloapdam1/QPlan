using QPlan.Views;
using QPlan.Views.PaginasCuentaPublicar;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QPlan
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPageCuentaPublicar();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
