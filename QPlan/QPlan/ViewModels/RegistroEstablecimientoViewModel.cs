using QPlan.Models;
using QPlan.Services;
using QPlan.Views.PaginasCuentaPublicar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class RegistroEstablecimientoViewModel : BaseViewModel
    {
        private User user { get; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string horario { get; set; }
        public string descripcion { get; set; }
        public string telefono { get; set; }
        public int edadMinima { get; set; }
        public double precioEntrada { get; set; }
        public string foto { get; set; }
        public Command OnButtonTapped { get; }
        public RegistroEstablecimientoViewModel(INavigation navigation, User user) : base(navigation)
        {
            this.Navigation = navigation;
            this.user = user;
            OnButtonTapped = new Command(async () => await ExecuteRegistrarEstablecimiento());
            nombre = string.Empty;
            direccion = string.Empty;
            horario = string.Empty;
            descripcion = string.Empty;
            foto = string.Empty;
            telefono = string.Empty;
        }

        public async Task ExecuteRegistrarEstablecimiento()
        {
            if (CheckEstablecimiento())
            {
                QPlanDataBase dataBase = new QPlanDataBase();
                int id_user = (await dataBase.GetUserAsync(user.name, user.password))[0].Id;
                Establecimiento est = new Establecimiento()
                {
                    nombre = this.nombre,
                    direccion = this.direccion,
                    horario = this.horario,
                    descripcion = this.descripcion,
                    telefono = this.telefono,
                    edadMinima = this.edadMinima,
                    precioEntrada = this.precioEntrada,
                    foto = this.foto,
                    userId = id_user
                };
                int resul = await dataBase.SaveEstablecimientoAsync(est);
                if(resul == 1)
                {
                    await Navigation.PushModalAsync(new MainPageCuentaPublicar(user, est));
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "No se ha podido insertar el establecimiento", "Aceptar");
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Los datos introducidos no son correctos", "Aceptar");
            }
        }

        public bool CheckEstablecimiento()
        {
            if (nombre == "") return false;
            if (direccion == "") return false; 
            if (horario == "") return false;
            if (descripcion == "") return false;
            if (telefono == "") return false;
            //if (foto == "") return false;
            return true;
        }
    }
}
