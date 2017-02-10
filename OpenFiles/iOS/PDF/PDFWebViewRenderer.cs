// Via Xamarin Documentation: https://developer.xamarin.com/recipes/cross-platform/xamarin-forms/controls/display-pdf/

using System;
using OpenFiles.iOS;
using OpenFiles;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using System.IO;
using Foundation;
using System.Net;

[assembly: ExportRenderer(typeof(PDFWebView), typeof(PDFWebViewRenderer))]
namespace OpenFiles.iOS
{
	public class PDFWebViewRenderer : ViewRenderer<PDFWebView, UIWebView>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<PDFWebView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
				SetNativeControl(new UIWebView());
			}
			if (e.OldElement != null)
			{
				// Cleanup
			}
			if (e.NewElement != null)
			{
				var customWebView = Element as PDFWebView;

				if (string.IsNullOrEmpty(customWebView.Uri))
					return;

				var url = NSUrl.FromFilename(customWebView.Uri);
				Control.LoadRequest(new NSUrlRequest(url));
				Control.ScalesPageToFit = true;
			}
		}
	}
}
