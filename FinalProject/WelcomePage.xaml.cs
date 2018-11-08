using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            var student = new StudentModel
            {
                Name = nameEntry.Text,
                Class = classEntry.Text,
                Grade = gradeEntry.Text,
            };
            await App.Database.SaveItemAsync(student);
        }

        async void Handle_GetAllDatabaseEntries(object sender, System.EventArgs e)
        {
            var allStudents = await App.Database.GetAllItems();
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
