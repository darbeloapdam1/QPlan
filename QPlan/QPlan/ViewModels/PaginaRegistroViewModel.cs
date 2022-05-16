using QPlan.Models;
using QPlan.Services;
using QPlan.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class PaginaRegistroViewModel : BaseViewModel
    {
        public string nombre { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string contra { get; set; }
        public string contraRepetida { get; set; }
        public int esEstablecimiento { get; set; }
        public Command OnRegistrarTapped { get; }
        public QPlanDataBase dataBase = new QPlanDataBase();
        public PaginaRegistroViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            OnRegistrarTapped = new Command(async () => await ExecuteRegistro());
            nombre = string.Empty;
            email = string.Empty;
            telefono = string.Empty;
            contra = string.Empty;
            contraRepetida = string.Empty;
            esEstablecimiento = 0;
        }

        public async Task ExecuteRegistro()
        {
            if (CheckCorrectUserData())
            {
                User user = new User()
                {
                    name = nombre,
                    email = this.email,
                    phone = telefono,
                    password = contra,
                    esEstablecimiento = this.esEstablecimiento
                };               
                int resul = await dataBase.SaveUserAsync(user);
                if (resul == 1)//comprobar que el user se ha insertado correctamente en la bd
                {
                    if(user.esEstablecimiento == 0)
                    {
                        await Navigation.PushModalAsync(new MainPage(user));
                    }
                    else
                    {
                        await Navigation.PushAsync(new PaginaRegistroModificarEstablecimiento(user));
                    }                   
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "No se ha podido completar el registro", "Aceptar");
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Los datos de algunos campos no son correctos", "Aceptar");
            }
        }

        public bool CheckCorrectUserData()
        {
            if (nombre == "")
            {
                return false;
            }
            if (email == "") return false;
            if (telefono == "") return false;
            if (contra == "") return false;
            if (contraRepetida == "") return false;
            if (!contra.Equals(contraRepetida)) return false;
            return true;
        }
    }
}
