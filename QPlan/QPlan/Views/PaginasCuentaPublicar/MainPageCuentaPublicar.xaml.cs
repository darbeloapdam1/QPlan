using QPlan.Models;
using QPlan.Services;
using QPlan.ViewModels.PaginasCuentaPublicar;
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
        public static Establecimiento establecimiento;
        public static QPlanDataBase dataBase;
        public MainPageCuentaPublicarViewModel _viewModel;
        public MainPageCuentaPublicar(User user1, Establecimiento est)
        {            
            user = user1;
            establecimiento = est;
            dataBase = new QPlanDataBase();
            InitializeComponent();
            BindingContext = _viewModel = new MainPageCuentaPublicarViewModel(user1);
        }

        public static User User
        {
            get { return user; }
        }
        public static Establecimiento Establecimiento
        {
            get { return establecimiento; }
            set { establecimiento = value; }
        }

        public static QPlanDataBase DataBase
        {
            get { return dataBase; }
        }
    }
}