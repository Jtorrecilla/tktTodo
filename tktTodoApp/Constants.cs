using System;

namespace tktTodoApp
{
	public static class Constants
	{
		// Replace strings with your mobile services and gateway URLs.
		public static string ApplicationURL = @"https://tkttodoapp.azurewebsites.net";

        public const string SenderID = "56068374112"; // Google API Project Number
        public const string ListenConnectionString = "Endpoint=sb://tokiotaxamarinhub.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=O56CUXViIAAUa3h5AxPML8MFBAcA2/aBdtTnQrXYUV8=";
        public const string NotificationHubName = "tnshub";
    }
}

