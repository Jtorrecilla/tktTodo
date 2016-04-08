using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Gms.Gcm;
using Android.Gms.Gcm.Iid;
using Android.Gms.Common;


//[assembly: Permission(Name = "@PACKAGE_NAME@.permission.C2D_MESSAGE")]
//[assembly: UsesPermission(Name = "@PACKAGE_NAME@.permission.C2D_MESSAGE")]
//[assembly: UsesPermission(Name = "com.google.android.c2dm.permission.RECEIVE")]

////GET_ACCOUNTS is only needed for android versions 4.0.3 and below
//[assembly: UsesPermission(Name = "android.permission.GET_ACCOUNTS")]
//[assembly: UsesPermission(Name = "android.permission.INTERNET")]
//[assembly: UsesPermission(Name = "android.permission.WAKE_LOCK")]
namespace tktTodoApp.Droid
{
    [Activity(Label = "tktTodoApp.Droid",
        Icon = "@drawable/icon",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        Theme = "@android:style/Theme.Holo.Light")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            LoadApplication(new App());

            if (IsPlayServicesAvailable())
            {
                var intent = new Intent(this, typeof(ClientApp.RegistrationIntentService));
                StartService(intent);
            }
        }

        public bool IsPlayServicesAvailable()
        {
            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (resultCode != ConnectionResult.Success)
            {
                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                {
                    //msgText.Text = GoogleApiAvailability.Instance.GetErrorString(resultCode)
                    DialogManager.CreateAndShowDialog(
                        GoogleApiAvailability.Instance.GetErrorString(resultCode),
                        "Error resolving Google Play Instane",
                        this);
                }
                else
                {
                    //msgText.Text = "Sorry, this device is not supported";
                    DialogManager.CreateAndShowDialog(
                        "Sorry, this device is not supported",
                        "Device not supported",
                        this);

                    Finish();
                }
                return false;
            }
            else
            {
                //msgText.Text = "Google Play Services is available.";
                DialogManager.CreateAndShowDialog(
                        "Google Play Services is available.",
                        "Google play services available",
                        this);

                return true;
            }
        }
    }
}

