using WordForWord.ViewModels;
using WordForWord.Views;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;

namespace WordForWord
{
	public partial class App : Application
	{
		public App()
		{
			RegisterViews();
			MainPage = new NavigationPage((Page)ViewFactory.CreatePage<SignInViewModel, SignInPage>());
		}

		private void RegisterViews()
		{
			ViewFactory.Register<SignInPage, SignInViewModel>();
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
	}
}

