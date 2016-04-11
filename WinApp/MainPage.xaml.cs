using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using tktTodoApp;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.PushNotifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WinApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : IAuthenticate
    {
        public MainPage()
        {
            this.InitializeComponent();
            tktTodoApp.App.Init(this);
            LoadApplication(new tktTodoApp.App());
        }
        // Define a authenticated user.
        private MobileServiceUser user;



        public async Task<bool> AuthenticateUser()
        {
            var success = false;
            try
            {
                // Sign in with Facebook login using a server-managed flow.
                if (user == null)
                {
                    user = await TodoItemManager.DefaultManager.CurrentClient.LoginAsync(MobileServiceAuthenticationProvider.Facebook);
                    if (user != null)
                    {
                        var messageDialog = new Windows.UI.Popups.MessageDialog(
                                string.Format("you are now logged in - {0}", user.UserId), "Authentication");


                        messageDialog.ShowAsync();
                    }
                }

                success = true;
                await InitNotificationsAsync();
            }
            catch (Exception ex)
            {
                var messageDialog = new Windows.UI.Popups.MessageDialog(ex.Message, "Authentication Failed");
                messageDialog.ShowAsync();
            }
            return success;
        }
        private async Task InitNotificationsAsync()
        {
            // Get a channel URI from WNS.
            var channel = await PushNotificationChannelManager
                .CreatePushNotificationChannelForApplicationAsync();
            //this.d
            //// Register the channel URI with Notification Hubs.
            var push = TodoItemManager.DefaultManager.CurrentClient.GetPush();
            await push.UnregisterAsync();
            await TodoItemManager.DefaultManager.CurrentClient.GetPush().RegisterAsync(channel.Uri);
            //AzurePushNotification.Plugin.AzurePushNotificationImplementation t = new AzurePushNotification.Plugin.AzurePushNotificationImplementation();
            //t.RegisterForAzurePushNotification();
        }


    }
}
