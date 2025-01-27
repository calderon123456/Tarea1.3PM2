﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Views.PersonPages()));
        }

        private async void btnListPersons_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Views.ShowPersons()));
        }
    }
}
