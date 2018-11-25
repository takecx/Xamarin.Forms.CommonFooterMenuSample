using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.CommonFrameSample.Views;

namespace Xamarin.Forms.CommonFrameSample
{
	public partial class Menu3 : ContentView
	{
		public Menu3()
		{
			InitializeComponent();
		}

		async void PopupButton_Clicked(object sender, System.EventArgs e)
		{
			if (footerMenu.IsVisible == false)
			{
				await footerMenu.TranslateTo(0, footerMenu.Height, 0);
				footerMenu.IsVisible = !footerMenu.IsVisible;
				await footerMenu.TranslateTo(0, 0, 300);

				popupButton.IsVisible = false;
			}
		}

		/// <summary>
		/// Hides the footer menu.
		/// </summary>
		public async void HideFooterMenu()
		{
			if (footerMenu.IsVisible == true)
			{
				await footerMenu.TranslateTo(0, 0, 0);
				await footerMenu.TranslateTo(0, footerMenu.Height, 300);
				footerMenu.IsVisible = false;

				popupButton.IsVisible = true;
			}
		}

		void Button1_Clicked(object sender, System.EventArgs e)
		{
			//if(_ViewName != nameof(MainPage))
			Application.Current.MainPage.Navigation.PushAsync(new MainPage());
		}
		void Button2_Clicked(object sender, System.EventArgs e)
		{
			Application.Current.MainPage.Navigation.PushAsync(new Page1());
		}
		void Button3_Clicked(object sender, System.EventArgs e)
		{
			Application.Current.MainPage.Navigation.PushAsync(new Page2());
		}
		void Button4_Clicked(object sender, System.EventArgs e)
		{
			Application.Current.MainPage.Navigation.PushAsync(new Page3());
		}

	}
}
