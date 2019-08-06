
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android;
using Android.Support.V4.App;
using Android.Support.V4.Content;

namespace XamarinFormsCameraTest.Droid
{

    [Activity(Label = "XamarinFormsCameraTest", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            if (!ContextCompat.CheckSelfPermission(this, Manifest.Permission.Camera).Equals(Permission.Granted))
            {
                ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.Camera }, 1);
            }
            LoadApplication(new App());
        }
    }
}