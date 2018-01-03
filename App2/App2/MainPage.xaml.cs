using App2.View.FormPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Permissions;  // Add this to use Xam.Media.Plugin
using Plugin.Permissions.Abstractions; // Add this to use Xam.Media.Plugin

namespace App2
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
                           

        }

        private void NewFormButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AccidentScene());
        }


    }
}
