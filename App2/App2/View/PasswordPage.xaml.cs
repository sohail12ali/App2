using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Helpers;


namespace App2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordPage : ContentPage
    {
        
        public PasswordPage()
        {
            InitializeComponent();

        }

        public async void SubmitButtonClicked(Object sender, EventArgs args)
        {

            if (UsernameEntry.Text == null) UsernameEntry.Focus();
            else if (PasswordEntry.Text == null) PasswordEntry.Focus();
            else if (!GlobalData.VerifyData(UsernameEntry.Text, PasswordEntry.Text))
            {
                await DisplayAlert("Warning", " Username or Password is Incorrect ", "Okay");
            }
            else
            {
                await Navigation.PushAsync(new MainPage());
                Navigation.RemovePage(Navigation.NavigationStack[0]);

            }


        }
    }
}