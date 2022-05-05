using QPlan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QPlan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageApp : ContentPage
    {
        MainPageAppViewModel _viewModel;
        public MainPageApp()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MainPageAppViewModel(Navigation);
        }
    }
}