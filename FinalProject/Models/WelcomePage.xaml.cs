using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace FinalProject
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(WelcomePage)}:  ctor");

        }
        async void Handle_SendStudentDataToDatabase(object sender, System.EventArgs e)
        {

            var msg = new MessageModel
            {
                Name = nameEntry.Text,
                Number = classEntry.Text,
                Body = gradeEntry.Text
            };



            await App.Database.SaveItemAsync(msg);


        


            const string accountSid = "AC2c81b1ab4ed95232da1abda3c45e1866";
        const string authToken = "9e4546c5c23d297899248ca414d559ec";

        TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Dear: " + msg.Name +" remember to: "+ msg.Body,
                from: new Twilio.Types.PhoneNumber("+19738418619"),
                to: new Twilio.Types.PhoneNumber('"'+"+1"+msg.Number+'"')
            );

        Console.WriteLine(message.Sid);
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