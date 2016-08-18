using XLabs.Forms.Mvvm;

namespace WordForWord.ViewModels
{
	public class SignInViewModel : ViewModel
	{
		private string _message;

		public SignInViewModel()
		{
			Message = "Hello Xamarin Forms Labs MVVM Basics!!";
		}

		public string Message
		{
			get { return _message; }
			set { SetProperty(ref _message, value); }
		}
	}
}
