using Android.Widget;
using eplant.Droid;
using eplant.Models.Interface;
using Xamarin.Forms;

[assembly:Dependency(typeof(Message_Droid))]
namespace eplant.Droid
{
    public class Message_Droid : IMessage
    {
        public void LongAlert(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortAlert(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }
    }
}