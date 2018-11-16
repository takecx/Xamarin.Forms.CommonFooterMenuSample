using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.CommonFrameSample.Views;

namespace Xamarin.Forms.CommonFrameSample
{
	public partial class menu1 : ContentView
	{
		//	private string _ViewName;
		//	public static readonly BindableProperty ViewNameProperty =
		//BindableProperty.Create(nameof(MainContent), typeof(View), typeof(CommonFrame));

		//public View MainContent
		//{
		//	get { return (View)GetValue(MainContentProperty); }
		//	set { SetValue(MainContentProperty, value); }
		//}

		public menu1()
		{
			InitializeComponent();
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
			throw new NotImplementedException();
		}
	}
}
