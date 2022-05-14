using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasCuentaPublicar
{
    public class PaginaSeleccionarCategoriasViewModel : BaseViewModel
    {
        private int[] categorias;
        public Command OnGuardarTapped { get; }
        public PaginaSeleccionarCategoriasViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            OnGuardarTapped = new Command(async () => await GuardarCategorias());
            categorias = PaginaNuevoEventoViewModel.evento.categorias;
        }

        public async Task GuardarCategorias()
        {
            PaginaNuevoEventoViewModel.evento.categorias = this.categorias;
            await Navigation.PopAsync();
        }

        public void CambiarValorMusical()
        {
            if(this.categorias[0] == -1)
            {
                this.categorias[0] = 1;
            }
            else
            {
                this.categorias[0] = -1;
            }
        }
        public void CambiarValorFiesta()
        {
            if (this.categorias[1] == -1)
            {
                this.categorias[1] = 1;
            }
            else
            {
                this.categorias[1] = -1;
            }
        }
        public void CambiarValorTeatro()
        {
            if (this.categorias[2] == -1)
            {
                this.categorias[2] = 1;
            }
            else
            {
                this.categorias[2] = -1;
            }
        }
        public void CambiarValorDeporte()
        {
            if (this.categorias[3] == -1)
            {
                this.categorias[3] = 1;
            }
            else
            {
                this.categorias[3] = -1;
            }
        }
        public void CambiarValorCultura()
        {
            if (this.categorias[4] == -1)
            {
                this.categorias[4] = 1;
            }
            else
            {
                this.categorias[4] = -1;
            }
        }
        public void CambiarValorConcierto()
        {
            if (this.categorias[5] == -1)
            {
                this.categorias[5] = 1;
            }
            else
            {
                this.categorias[5] = -1;
            }
        }
    }
}
