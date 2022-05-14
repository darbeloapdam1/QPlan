using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class PaginaSeleccionarTipoLugarViewModel : BaseViewModel
    {
        public Command OnGuardarTapped { get; }
        private int[] tipoLugar;
        public PaginaSeleccionarTipoLugarViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            OnGuardarTapped = new Command(async () => await GuardarTipoLugar());
            tipoLugar = PaginaNuevoEventoViewModel.evento.tipoLugar;
        }

        public async Task GuardarTipoLugar()
        {
            PaginaNuevoEventoViewModel.evento.tipoLugar = this.tipoLugar;
            await Navigation.PopAsync();
        } 

        public void CambiarValorCubierto()
        {
            if(tipoLugar[0] == -1)
            {
                tipoLugar[0] = 1;
            }
            else
            {
                tipoLugar[0] = -1;
            }
        }
        public void CambiarValorAireLibre()
        {
            if (tipoLugar[1] == -1)
            {
                tipoLugar[1] = 1;
            }
            else
            {
                tipoLugar[1] = -1;
            }
        }
        public void CambiarValorPorCalle()
        {
            if (tipoLugar[2] == -1)
            {
                tipoLugar[2] = 1;
            }
            else
            {
                tipoLugar[2] = -1;
            }
        }
        public void CambiarValorFueraCiudad()
        {
            if (tipoLugar[3] == -1)
            {
                tipoLugar[3] = 1;
            }
            else
            {
                tipoLugar[3] = -1;
            }
        }
    }
}
