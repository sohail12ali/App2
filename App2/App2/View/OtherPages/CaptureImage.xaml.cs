using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using App2.Helpers;
using System.Diagnostics;
using Plugin.Permissions.Abstractions;

namespace App2.View.OtherPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CaptureImage : ContentPage
    {
        public CaptureImage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        Image image = new Image();

        public async void OnCaptured(Object sender, EventArgs args)
        {
            try
            {



                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await DisplayAlert("Warning", "No Camera Available", "Ok");
                    return;
                }


                var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new
                    Plugin.Media.Abstractions.StoreCameraMediaOptions()
                {
                    SaveToAlbum = false, // change to true for storing images in galary
                    Directory = "Sample", // storing images to sample directory
                    Name = $"Photo{ GlobalData.claimName }{DateTime.Now.ToShortTimeString()}", // file name for the image 
                });

                if (photo == null)
                    return;

                await DisplayAlert("File Location", photo.Path, "OK");

                if (photo != null)
                {
                    PhotoImage.Source = ImageSource.FromStream(() =>
                    {
                        var stream = photo.GetStream();
                        photo.Dispose();
                        return stream;
                    });
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex);

            }




        }
    }
}