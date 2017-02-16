using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace OpenFiles.Droid
{
	[Activity(Label = "OpenFiles.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	[IntentFilter(new[] { Intent.ActionSend }, Categories = new[] { Intent.CategoryDefault }, DataMimeType = @"application/pdf")]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			if (Intent.Action == Intent.ActionSend)
			{
				var clip = Intent.ClipData;
				var pdf = clip.GetItemAt(0);

				Console.Write("hi");
			}

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());
		}


	}
}
