using System;

using Xamarin.Forms;

namespace FinalProject
{
    public class Sports : ContentPage
    {
        public Sports()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

