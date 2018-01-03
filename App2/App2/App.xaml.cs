﻿using App2.View;
using App2.View.FormPages;
using App2.View.OtherPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2
{
	public partial class App : Application
	{
               

        public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new PasswordPage());
            
            
            //MainPage = new NavigationPage(new AccidentScene());
            //MainPage = new NavigationPage(new VehicleNumber());
            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new NavigationPage(new NewClaim("Testing", "Default"));
            //MainPage = new NavigationPage(new CaptureImage());





        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        
    }
}
