using System;
using System.Collections.Generic;
using SampleXamarinForm.Models;
using Xamarin.Forms;

namespace SampleXamarinForm
{	
	public partial class SampleListObject : ContentPage
	{	
		public SampleListObject()
		{
			InitializeComponent();
			List<Employee> lstEmployee = new List<Employee>
			{
				new Employee{Name="Erick Kurniawan",Address="Redmond WA",
					Picture="monkey.png"},
				new Employee{Name="John Doe",Address="New York City",
					Picture="monkey.png"},
				new Employee{Name="Scott Guthrie",Address="Jakarta",
					Picture="monkey.png"}
			};
			lvEmployee.ItemsSource = lstEmployee;

            lvEmployee.ItemTapped += LvEmployee_ItemTapped;
            btnGridLayout.Clicked += BtnGridLayout_Clicked;
            btnBack.Clicked += BtnBack_Clicked;
		}

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
			await Navigation.PopAsync();
        }

        private async void BtnGridLayout_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new GridLayoutSample());
        }

        private async void LvEmployee_ItemTapped(object sender, ItemTappedEventArgs e)
        {
			var emp = (Employee)e.Item;
			await DisplayAlert("Keterangan", $"Name: {emp.Name} Address: {emp.Address}",
				"OK");
			((ListView)sender).SelectedItem = null;
        }
    }
}

