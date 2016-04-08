using System;

using Android.App;

namespace tktTodoApp.Droid
{
    public class DialogManager
    {
        public static void CreateAndShowDialog(String message, String title, Android.Content.Context applicationContext)
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(applicationContext);

            builder.SetMessage(message);
            builder.SetTitle(title);
            builder.Create().Show();
        }
    }
}