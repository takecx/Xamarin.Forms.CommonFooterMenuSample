﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin.Forms.CommonFrameSample
{
	public partial class Page3 : ContentPage
	{
		public Page3()
		{
			InitializeComponent();
		}

		void Handle_Tapped(object sender, System.EventArgs e)
		{
			popupMenu.HideFooterMenu();
		}
	}
}
