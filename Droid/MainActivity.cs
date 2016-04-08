﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;
using Gcm.Client;
    
namespace tktTodoApp.Droid
{
	[Activity (Label = "tktTodoApp.Droid", 
		Icon = "@drawable/icon", 
		MainLauncher = true, 
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
		Theme = "@android:style/Theme.Holo.Light")]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
        public static MainActivity instance;

        protected override void OnCreate (Bundle bundle)
		{
            instance = this;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init (this, bundle);
			Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
			LoadApplication (new App ());

            RegisterWithGCM();
        }

        private void RegisterWithGCM()
        {
            // Check to ensure everything's set up right
            GcmClient.CheckDevice(this);
            GcmClient.CheckManifest(this);

            // Register for push notifications
            Log.Info("MainActivity", "Registering...");
            GcmClient.Register(this, Constants.SenderID);
        }
    }
}

