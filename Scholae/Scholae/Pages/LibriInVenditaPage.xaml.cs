﻿using Xamarin.Forms;

namespace Scholae.Pages
{
    public partial class LibriInVenditaPage : ContentPage
    {
        public LibriInVenditaPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        void Back_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

    }
}
