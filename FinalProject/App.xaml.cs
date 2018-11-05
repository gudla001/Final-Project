using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FinalProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(App)}:  ctor");
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnStart)}");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnSleep)}");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnResume)}");
        }
    }
}
