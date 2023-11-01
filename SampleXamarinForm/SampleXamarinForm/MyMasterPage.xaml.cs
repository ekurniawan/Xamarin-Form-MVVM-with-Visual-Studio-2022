using System;
using System.Collections.Generic;
using SampleXamarinForm.Models;
using Xamarin.Forms;

namespace SampleXamarinForm
{	
	public partial class MyMasterPage : MasterDetailPage
	{	
		public MyMasterPage ()
		{
			InitializeComponent ();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
		}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MyMenuItem)e.SelectedItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
            Detail = new NavigationPage(page);
            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }
    }
}

