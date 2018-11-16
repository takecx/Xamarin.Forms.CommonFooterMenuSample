using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.CommonFrameSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CommonFrame : ContentView
	{
		public static readonly BindableProperty MainContentProperty =
			BindableProperty.Create(nameof(MainContent), typeof(View), typeof(CommonFrame));

		public View MainContent
		{
			get { return (View)GetValue(MainContentProperty); }
			set { SetValue(MainContentProperty, value); }
		}

		public static readonly BindableProperty FooterMenuProperty =
	BindableProperty.Create(nameof(FooterMenu), typeof(View), typeof(CommonFrame));

		public View FooterMenu
		{
			get { return (View)GetValue(FooterMenuProperty); }
			set { SetValue(FooterMenuProperty, value); }
		}

		public CommonFrame()
		{
			InitializeComponent();
		}
	}
}
