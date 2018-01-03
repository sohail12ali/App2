using App2.Helpers;
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
    public partial class NewClaim : ContentPage
    {
        public static string PickerValue { get; set; }

        public static string VehicleNumber { get; set; }


        public NewClaim(string pickerValue, string vehicleNumber)
        {
            PickerValue = pickerValue;

            VehicleNumber = vehicleNumber;

            string datatime = DateTime.Now.ToString("yyyy/MM/dd");

            GlobalData.claimName = $"{VehicleNumber}.{PickerValue}.{datatime}";


            InitializeComponent();

        }

        public async void CaptureImageButton(Object sender, EventArgs args)
        {
            await DisplayAlert("Warning", GlobalData.claimName, "Okay");

        }
        public async void UseSavedImageButton(Object sender, EventArgs args)
        {
            await DisplayAlert("Warning", GlobalData.claimName, "Okay");

        }



    }
}