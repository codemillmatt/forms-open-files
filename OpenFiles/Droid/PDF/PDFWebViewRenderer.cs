using System;
using System.Net;
using OpenFiles;
using OpenFiles.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PDFWebView), typeof(PDFWebViewRenderer))]
namespace OpenFiles.Droid
{
	public class PDFWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null)
			{
				var customWebView = Element as PDFWebView;
				Control.Settings.AllowUniversalAccessFromFileURLs = true;
				Control.LoadUrl(string.Format("file:///android_asset/pdfjs/web/viewer.html?file={0}", string.Format("file:///android_asset/Content/{0}", WebUtility.UrlEncode(customWebView.Uri))));
			}
		}
	}
}
