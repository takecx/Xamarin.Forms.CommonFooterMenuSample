using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Xamarin.Forms.CommonFrameSample.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{

		public MainPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "Main Page";
		}
	}
}
