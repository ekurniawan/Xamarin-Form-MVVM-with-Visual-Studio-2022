using System;
using System.Collections.Generic;
using SampleXamarinForm.Views;
using Xamarin.Forms;

namespace SampleXamarinForm
{	
	public partial class AppShell : Xamarin.Forms.Shell
	{	
		public AppShell ()
		{
			InitializeComponent ();

			Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
			Routing.RegisterRoute(nameof(CoffeeEquipmentPage), typeof(CoffeeEquipmentPage));
			Routing.RegisterRoute(nameof(SampleListObject), typeof(SampleListObject));
		}
	}
}

