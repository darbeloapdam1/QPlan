using QPlan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class PaginaBusquedaViewModel : BaseViewModel
    {

        public PaginaBusquedaViewModel(INavigation navigation) : base(navigation)
        {

        }


        public Task Search(SearchParameters parameters)
        {
            
            return null;
        }

        public void OnAppearing()
        {

        }
    }
}
