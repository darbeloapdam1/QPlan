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
    public class MainPageAppViewModel : BaseViewModel
    {
        FileReader fileReader;
        QPlanDataBase dataBase;
        public MainPageAppViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            fileReader = new FileReader();
            dataBase = new QPlanDataBase();
            LaunchApp();
        }

        private async Task LaunchApp()
        {
            if (await fileReader.CheckLoginData())
            {
                string[] loginData = await fileReader.GetLoginData();//comprobar que existen datos de inicio de sesión
                if(await dataBase.CheckUserAsync(loginData[0], loginData[1]))//comprobar que esos datos se corresponden con un usuario guardado en la bd
                {
                    var userList = await dataBase.GetUserAsync(loginData[0], loginData[1]);
                    if (userList.Count != 0)
                    {
                        User user = userList[0];
                        if (user.esEstablecimiento == 1)//comprobar si es cuenta de establecimiento
                        {
                            await Navigation.PushModalAsync(new MainPageCuentaPublicar(user));
                            return;
                        }
                        else
                        {
                            await Navigation.PushModalAsync(new MainPage());
                            return;
                        }
                    }
                }                
            }
            await Navigation.PushModalAsync(new PaginaLogin());
        }


    }
}
