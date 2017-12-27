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
	public partial class BeforeAndAfterPage : ContentPage
	{
		public BeforeAndAfterPage ()
		{
			InitializeComponent ();
		}

        private void BeforeAndAfterButton(object sender, EventArgs args)
        {
            Navigation.PushAsync(new VehicleNumber());

        }
    }
}