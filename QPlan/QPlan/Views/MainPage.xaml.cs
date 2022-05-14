using QPlan.Models;
using QPlan.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan
{
    public partial class MainPage : TabbedPage
    {
        public static User user { get; set; }
        public MainPage(User user2)
        {
            InitializeComponent();
            user = user2;
        }

        public MainPage()
        {
            InitializeComponent();
        }
        
    }
}
