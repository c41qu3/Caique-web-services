using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Shopping_Rural
{
	public partial class App : Application
	{
		public App ()
		{
            MainPage = new NavigationPage(new Tela_Cadastra_Produto())
            {
                BarBackgroundColor = Color.FromHex("#4169E1"),

            };
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
