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
    public partial class PaginaLogin : ContentPage
    {
        public PaginaLoginViewModel _viewModel;
        public PaginaLogin()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PaginaLoginViewModel(Navigation);
        }

        private void entUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.Usuario = entUsuario.Text;
        }

        private void entContra_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.Pass = entContra.Text;
        }
    }
}