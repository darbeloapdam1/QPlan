using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class MainPageAppViewModel : BaseViewModel
    {
        public MainPageAppViewModel(INavigation navigation) : base(navigation)
        {
            this.Navigation = navigation;
        }

    }
}
