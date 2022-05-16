using QPlan.Models;
using QPlan.Views.PaginasCuentaPublicar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class MainPageCuentaPublicarViewModel
    {
        public User user;
        public MainPageCuentaPublicarViewModel(User user)
        {
            this.user = user;
        }

        public static async Task GetEstablecimientoAsync()
        {
            Establecimiento est = (await MainPageCuentaPublicar.dataBase.GetEstablecimientoAsync(MainPageCuentaPublicar.user.Id))[0];
            while(est == null)
            {
                MainPageCuentaPublicar.Establecimiento = est;
            }           
        }
    }
}
