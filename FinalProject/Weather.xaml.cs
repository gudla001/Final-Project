using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace FinalProject
{
    public partial class Weather : ContentPage
    {
        public Weather()
        {
            InitializeComponent();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(Weather)}:  ctor");
        }

        void OnAppearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnAppearing)}");
        }

        void OnDisappearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnDisappearing)}");
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://en.wikipedia.org/wiki/Bulldogt"));
        }
    }
}