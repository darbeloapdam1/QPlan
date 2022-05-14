using QPlan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QPlan.Views.PaginasCuentaPublicar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageCuentaPublicar : TabbedPage
    {
        public static User user;
        public MainPageCuentaPublicar(User user1)
        {
            InitializeComponent();
            user = user1;
        }
    }
}