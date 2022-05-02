using QPlan.Models;
using QPlan.Services;
using QPlan.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels.PaginasBusqueda
{
    public class TodosResultadosBusquedaViewModel : BaseViewModel
    {
        public bool isBusy;
        public ObservableCollection<BaseModel> BaseModels { get; }
        public Command<BaseModel> ObjectTapped { get; }
        public Command LoadObjectsCommand { get; }
        public TodosResultadosBusquedaViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
            ObjectTapped = new Command<BaseModel>(OnBaseModelSelected);
            LoadObjectsCommand = new Command(async () => await ExecuteLoadBaseModelsAsync());
            BaseModels = new ObservableCollection<BaseModel>();
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public async void OnBaseModelSelected(BaseModel baseModel)
        {
            if (baseModel == null)
                return;
            Type t = baseModel.GetType();
            if (t.Equals(typeof(Evento)))
            {
                await Navigation.PushAsync(new PaginaEventoDetalles((Evento)baseModel));
            }else if (t.Equals(typeof(Establecimiento)))
            {
                await Navigation.PushAsync(new PaginaEstablecimientoDetalles((Establecimiento)baseModel));
            }           
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        private async Task ExecuteLoadBaseModelsAsync()
        {
            IsBusy = true;
            try
            {
                BaseModels.Clear();
                var bs = MainPagePaginasBusqueda.baseModels;
                foreach(var item in bs)
                {
                    BaseModels.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
