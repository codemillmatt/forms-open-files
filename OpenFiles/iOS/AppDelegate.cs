using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace OpenFiles.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		App mainForms;
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			mainForms = new App();

			LoadApplication(mainForms);							

			return base.FinishedLaunching(app, options);
		}

		public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
		{
			mainForms.DisplayThePDF(url.Path);

			return true;
		}
	}
}
