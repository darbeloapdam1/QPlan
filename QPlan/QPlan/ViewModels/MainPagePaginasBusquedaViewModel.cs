using QPlan.Models;
using QPlan.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class MainPagePaginasBusquedaViewModel : BaseViewModel
    {
        List<BaseModel> baseModels = new List<BaseModel>();
        public MainPagePaginasBusquedaViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
        }

        public void LoadBaseModels()
        {
            List<Evento> eventos = DataStore.getEventos();
            List<Establecimiento> establecimientos = DataStore.GetEstablecimientos();
            for(int i = 0; i < eventos.Count; i++)
            {
                baseModels.Add(eventos[i]);
                baseModels.Add(establecimientos[i]);
            }
        }

        public void LoadEventos(ref List<BaseModel> baseModels)
        {
            baseModels.Clear();
            baseModels.AddRange(DataStore.getEventos());
        }
        public void LoadEstablecimientos(ref List<BaseModel> baseModels)
        {
            baseModels.Clear();
            baseModels.AddRange(DataStore.GetEstablecimientos());
        }

        public List<BaseModel> BaseModels
        {
            get {
                LoadBaseModels();
                return baseModels; 
            }
        }
    }
}
