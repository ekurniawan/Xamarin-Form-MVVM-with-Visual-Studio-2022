using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;
using SampleXamarinForm.Shared;
using Xamarin.Forms;

namespace SampleXamarinForm.ViewModels
{
	public class CoffeeEquipmentViewModel : ViewModelBase
	{
		public ObservableRangeCollection<Coffee> Coffee { get; set; }
		public AsyncCommand RefreshCommand { get; }
		public AsyncCommand LoadMore { get; set; }
		public AsyncCommand<Coffee> SelectedCommand { get; set; }

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

			RefreshCommand = new AsyncCommand(Refresh);
			LoadMore = new AsyncCommand(GetMoreData);
			SelectedCommand = new AsyncCommand<Coffee>(Selected);
		}

        private async Task Selected(Coffee coffee)
        {
			if (coffee == null)
				return;
			await Application.Current.MainPage.DisplayAlert("Favorite Coffee",
				$"{coffee.Name} - {coffee.Roaster}","OK");
        }

        private bool myNotBusy;
        public bool MyNotBusy
        {
            get
            {
				return !IsBusy;
            }
           
        }

        private async Task GetMoreData()
        {
            var image = "https://images.prismic.io/yesplz/75c1e42d-4bcc-40e1-abec-bf35816c088b_Group+2471.png";

            List<Coffee> addMoreCoffee = new List<Coffee>
			{
                new Coffee{Roaster="Kopi Klotok",Name="Pike Market",
                    Image=image},
                new Coffee{Roaster="Fore",Name="Kenya Kiambu",
                    Image=image}
            };

			Coffee.AddRange(addMoreCoffee);
			await Task.Delay(1000);
        }

        private async Task Refresh()
        {
			IsBusy = true;
			await Task.Delay(2000);
			IsBusy = false;
        }
    }
}

