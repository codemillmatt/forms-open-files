// Via Xamarin Documentation: https://developer.xamarin.com/recipes/cross-platform/xamarin-forms/controls/display-pdf/

using System;
using Xamarin.Forms;

namespace OpenFiles
{
	public class PDFWebView : WebView
	{
		public string Uri { get; set; }
	}
}
