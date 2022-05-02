using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class CuentaViewModel : BaseViewModel
    {
        public CuentaViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
        }
    }
}
