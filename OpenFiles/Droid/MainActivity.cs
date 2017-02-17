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
		App _mainForms;
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			_mainForms = new App();

			LoadApplication(_mainForms);

			if (Intent.Action == Intent.ActionSend) 
			{
				var pdf = Intent.ClipData.GetItemAt(0);

				var uriFromExtras = Intent.GetParcelableExtra(Intent.ExtraStream) as Android.Net.Uri;
				var subject = Intent.GetStringExtra(Intent.ExtraSubject);

				var pdfStream = ContentResolver.OpenInputStream(pdf.Uri);

				var memOfPdf = new System.IO.MemoryStream();
				pdfStream.CopyTo(memOfPdf);

				var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
				var filePath = System.IO.Path.Combine(docsPath, "temp.pdf");

				System.IO.File.WriteAllBytes(filePath, memOfPdf.ToArray());

				_mainForms.DisplayThePDF(filePath);
			}
		}


	}
}
