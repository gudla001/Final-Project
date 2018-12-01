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
            //InitializeComponent();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(Logout)}:  ctor");
           

                Thread.CurrentThread.Abort();
           
        }

      
       
        void OnAppearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnAppearing)}");
        }

        void OnDisappearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnDisappearing)}");
        }
    }
}
