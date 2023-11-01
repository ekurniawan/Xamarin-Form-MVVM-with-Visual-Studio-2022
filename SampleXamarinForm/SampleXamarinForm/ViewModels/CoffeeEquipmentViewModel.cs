using System;
using MvvmHelpers;
using SampleXamarinForm.Shared;

namespace SampleXamarinForm.ViewModels
{
	public class CoffeeEquipmentViewModel : ViewModelBase
	{
		public ObservableRangeCollection<Coffee> Coffee { get; set; }

		public CoffeeEquipmentViewModel()
		{
			Title = "Coffee Equipment";
			var image = "https://images.prismic.io/yesplz/75c1e42d-4bcc-40e1-abec-bf35816c088b_Group+2471.png";

			Coffee = new ObservableRangeCollection<Coffee>
			{
				new Coffee{Roaster="Filosofi Kopi",Name="Robusta Temanggung",
					Image=image},
				new Coffee{Roaster="Janji Jiwa",Name="Arabica Aceh Gayo",
					Image=image},
				new Coffee{Roaster="Kopi Kenangan",Name="Toraja Robusta",
					Image=image},
				new Coffee{Roaster="Starbuck",Name="Pike Market",
					Image=image},
				new Coffee{Roaster="Kopi Kenangan",Name="Kenya Kiambu",
					Image=image}
			};
		}
	}
}

