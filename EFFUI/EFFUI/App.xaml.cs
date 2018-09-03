using System;
using Xamarin.Forms;
using EFFUI.Views;
using Xamarin.Forms.Xaml;
using EFFUI.CodePages;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace EFFUI
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();


            //MainPage = new MainPage();
            //MainPage = new MapPage();
            MainPage = new TabPage { Padding = new Thickness(0, 40, 0, 0) };
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
