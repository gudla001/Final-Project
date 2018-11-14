using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Plugin.Connectivity;
using Xamarin.Forms;


namespace FinalProject
{

    public partial class Animals : ContentPage
    {
        public Animals()
        {
            InitializeComponent();
            MainPicker.Items.Add("Dog");
            MainPicker.Items.Add("Cat");
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(WelcomePage)}:  ctor");
        }

        void OnAppearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnAppearing)}");
        }

        void OnDisappearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnDisappearing)}");



        }
        public bool DoIHaveInternet()
        {
            return CrossConnectivity.Current.IsConnected;
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var name = MainPicker.Items[MainPicker.SelectedIndex];
            if (name == "Dog")
            {
                Dog();

            }
            else if (name == "Cat")
            {
                Cat();

            }
            async void Dog()
            {
                var client = new HttpClient();

                var dogApiAddress = "https://dog.ceo/api/breeds/image/random";
                var uri = new Uri(dogApiAddress);

                Doggy dogData = new Doggy();
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();
                    dogData = JsonConvert.DeserializeObject<Doggy>(jsonContent);
                }

                DoggyPic.Source = dogData.DogPhotoUrl;
            }
        }
        async void Cat()
        {
            var client = new HttpClient();

            var catApiAddress = "https://aws.random.cat/meow";
            var uri = new Uri(catApiAddress);

            Catty catData = new Catty();
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();
                catData = JsonConvert.DeserializeObject<Catty>(jsonContent);
            }

            DoggyPic.Source = catData.File;
        }
        void dogClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://en.wikipedia.org/wiki/Dog"));
        }
        void catClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://en.wikipedia.org/wiki/Cat"));
        }


    }



}
