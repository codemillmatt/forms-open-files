using Xamarin.Forms;
using System.Threading.Tasks;

namespace OpenFiles
{
	public partial class App : Application
	{
		NavigationPage _navigationRoot;
		public App()
		{
			InitializeComponent();

			_navigationRoot = new NavigationPage(new StartPage());

			MainPage = _navigationRoot;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}

		public void DisplayThePDF(string url)
		{
			var openFilePage = new OpenFilesPage(url);;

			_navigationRoot.Navigation.PushModalAsync(new NavigationPage(openFilePage));
		}
	}
}
