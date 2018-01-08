using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Helpers;
using System.Diagnostics;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using PCLStorage;



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

        public static List<string> list = new List<string>();
        //public static List<string> pathList = new List<string>();
        public static List<string> nameList = new List<string>();

        public static Image CreateImageLayout(string imageSourcePath)
        {

            Image image = new Image()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Start,
                BackgroundColor = Color.Transparent,
                Scale = 0.9,
                Source = ImageSource.FromFile(imageSourcePath)
            };

            return image;
        }

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

                string imageName = $"Photo{GlobalData.claimName}{DateTime.Now.ToShortTimeString()}";

                var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new
                    Plugin.Media.Abstractions.StoreCameraMediaOptions()
                {
                    SaveToAlbum = false, // change to true for storing images in galary
                    Directory = "Sample", // storing images to sample directory/Folder
                    Name = imageName, // file name for the image

                });
                
                if (photo == null)
                    return;


                list.Add(photo.Path);  // image path added in the list
                //pathList.Add(photo.AlbumPath);
                nameList.Add(imageName);

                // await DisplayAlert("File Location", $"Path:{photo.Path} Name {imageName}", "OK"); // Only for checking names of the images

                if (photo != null)
                {
                    PhotoImage.Source = ImageSource.FromStream(() =>
                    {
                        var stream = photo.GetStream();
                        //images.Add(stream.ToString());
                        photo.Dispose();
                        return stream;
                    });
                }

                if (list != null && list.Any())
                {
                    ScrollLayout.Children.Add(CreateImageLayout(list.Last()));
                    
                }

                //ScrollLayout.Children.Add();


            }
            catch (Exception ex)
            {

            }
        }      
    }
}