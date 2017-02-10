using System.ComponentModel;
using Xamarin.Forms;
using System.Runtime.InteropServices.WindowsRuntime;

namespace OpenFiles
{
	public partial class OpenFilesPage : ContentPage
	{
		public OpenFilesPage(string pdfLocation)
		{
			InitializeComponent();

			theWebView.Uri = pdfLocation;
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopModalAsync(true);
		}
	}
}
