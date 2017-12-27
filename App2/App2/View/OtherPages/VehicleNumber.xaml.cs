using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.View.OtherPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VehicleNumber : ContentPage
	{
		public VehicleNumber ()
		{
			InitializeComponent ();
		}

        private async void SubmitVehicleNumber(Object sender, EventArgs args)
        {
            if(!String.IsNullOrWhiteSpace(VehicleNumberEntry.Text))
            {
                // await Navigation.PushAsync(new );
                await DisplayAlert("Warning", "Working", "Okay");

            }
            else
            {
                VehicleNumberEntry.Focus();
            }

        }

    }
}