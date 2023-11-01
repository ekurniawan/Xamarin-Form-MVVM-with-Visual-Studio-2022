using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleXamarinForm
{	
	public partial class SampleBindingList : ContentPage
	{	
		public SampleBindingList ()
		{
			InitializeComponent ();
			List<string> items = new List<string> { "Erick", "Jhon", "Peter" };
			lvData.ItemsSource = items;

            lvData.ItemTapped += LvData_ItemTapped;
		}

        private async void LvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
			ListView myListView = (ListView)sender;
			await DisplayAlert("Tapped", e.Item.ToString() + " dipilih", "OK");
			myListView.SelectedItem = null;
        }
    }
}

