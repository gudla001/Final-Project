using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Xamarin.Forms;

namespace FinalProject
{
    public partial class Logout : ContentPage
    {
        public Logout()
        {
            InitializeComponent();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(Logout)}:  ctor");

         
        }

      
       
        void OnAppearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnAppearing)}");
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
               Thread.CurrentThread.Abort();

                return true; // True = Repeat again, False = Stop the timer
            });

        }

        void OnDisappearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnDisappearing)}");
        }
    }
}
