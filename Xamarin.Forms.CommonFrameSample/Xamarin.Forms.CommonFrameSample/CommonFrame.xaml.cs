using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.CommonFrameSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CommonFrame : ContentView
	{
		#region BindableProperty
		public static readonly BindableProperty MainContentProperty =
			BindableProperty.Create(nameof(MainContent), typeof(View), typeof(CommonFrame));

		public View MainContent
		{
			get { return (View)GetValue(MainContentProperty); }
			set { SetValue(MainContentProperty, value); }
		}

		public static readonly BindableProperty MainContentBoundsProperty =
			BindableProperty.Create("MainContentBounds", typeof(Rectangle), typeof(ContentView), new Rectangle(0, 0, 1, 0.4));
		public Rectangle MainContentBounds
		{
			get { return (Rectangle)GetValue(MainContentBoundsProperty); }
			set { SetValue(MainContentBoundsProperty, value); }
		}

		public static readonly BindableProperty FooterMenuProperty =
			BindableProperty.Create(nameof(FooterMenu), typeof(View), typeof(CommonFrame));

		public View FooterMenu
		{
			get { return (View)GetValue(FooterMenuProperty); }
			set { SetValue(FooterMenuProperty, value); }
		}
		public static readonly BindableProperty FooterMenuBoundsProperty =
			BindableProperty.Create("FooterMenuBounds", typeof(Rectangle), typeof(ContentView), new Rectangle(0, 1, 1, 0.1));
		public Rectangle FooterMenuBounds
		{
			get { return (Rectangle)GetValue(FooterMenuBoundsProperty); }
			set { SetValue(FooterMenuBoundsProperty, value); }
		}

		#endregion

		public CommonFrame()
		{
			InitializeComponent();
		}
	}
}
