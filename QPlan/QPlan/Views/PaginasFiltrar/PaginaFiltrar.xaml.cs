﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QPlan.Views.PaginasFiltrar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaFiltrar : ContentPage
    {
        public PaginaFiltrar()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if(sldDistancia.Value == 0)
            {
                lblDistancia.Text = "Sin límite";
            }
            else
            {
                lblDistancia.Text = sldDistancia.Value + " km";
            }
        }
    }
}