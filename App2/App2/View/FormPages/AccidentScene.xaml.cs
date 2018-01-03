using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.View.FormPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccidentScene : ContentPage
	{
		public AccidentScene ()
		{
            BindingContext = this;
			InitializeComponent ();
		}


        public string PickerValue { get; set; }


        private void ChangeEvent(Object sender, ValueChangedEventArgs args)
        {
            PickerValue = AccidentPicker.SelectedItem.ToString();
            DisplayAlert("Warning", PickerValue, "Okay");


        }

        private async void SubmitVehicleNumber(Object sender, EventArgs args)
        {
            if (!String.IsNullOrWhiteSpace(VehicleNumberEntry.Text))
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