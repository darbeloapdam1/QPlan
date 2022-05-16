using QPlan.Models;
using QPlan.Services;
using QPlan.Views;
using QPlan.Views.PaginasCuentaPublicar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class PaginaLoginViewModel : BaseViewModel
    {
        string usuario = string.Empty;
        string pass = string.Empty;
        public Command OnIniciarSesionTapped { get; }
        public Command OnSaltarLogin { get; }
        public Command OnRegistrarTapped { get; }
        public PaginaLoginViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            OnIniciarSesionTapped = new Command(async () => await ExecuteIniciarSesionAsync());
            OnSaltarLogin = new Command(async () => await JumpLoginPage());
            OnRegistrarTapped = new Command(async () => await ShowPaginaRegistrar()); 
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public async Task ExecuteIniciarSesionAsync()
        {            
            if(Usuario == "")
            {
                await App.Current.MainPage.DisplayAlert("Error", "Especifíque un nombre de usuario", "Aceptar");
            }
            else if(Pass == "")
            {
                await App.Current.MainPage.DisplayAlert("Error", "Especifíque una contraseña", "Aceptar");
            }
            else
            {
                QPlanDataBase dataBase = new QPlanDataBase();
                if (await dataBase.CheckUserAsync(Usuario, Pass))
                {
                    User user = (await dataBase.GetUserAsync(Usuario, Pass))[0];
                    if(user.esEstablecimiento == 1)
                    {
                        Establecimiento est = (await dataBase.GetEstablecimientoAsync(user.Id))[0];
                        FileReader reader = new FileReader();
                        await reader.WriteToFile(FileReader.constants[0] + user.name + FileReader.constants[1] + FileReader.constants[2] + user.password);
                        await Navigation.PushModalAsync(new MainPageCuentaPublicar(user, est));
                    }
                    else
                    {
                        FileReader reader = new FileReader();
                        await reader.WriteToFile(FileReader.constants[0] + user.name + FileReader.constants[1] + FileReader.constants[2] + user.password);
                        await Navigation.PushModalAsync(new MainPage(user));
                    }
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Nombre de usuario y/o contraseña incorrectos", "Aceptar");
                }
            }
        }

        public async Task JumpLoginPage()
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        public async Task ShowPaginaRegistrar()
        {
            await Navigation.PushAsync(new PaginaRegistro());
        }

    }
}
